using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Data;
using System.Globalization;
using FestManager_Core.Data;

namespace FestManager_Core.Utils.Printing
{
    public class Kassenbon
    {
        private static int _width = 200;
        private static int _marginTop = 10;
        private static int _marginLeft = 10;

        /* Components */
        private Font _fontDefault;
        private Font _fontBold;
        private StringFormat _sfRight;
        private StringFormat _sfLeft;
        private StringFormat _sfCenter;

        private readonly FestManagerDataSet.KassenbonDataTable _table;
        private readonly string _title;

        private int _lineSpacing = 5;
        private Pen _defaultPen;
        private Brush _defaultBrush;

        public Graphics Graphic { get; }

        private void Init()
        {
            _fontDefault = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
            _fontBold = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
            _sfRight = new StringFormat {Alignment = StringAlignment.Far};
            _sfLeft = new StringFormat {Alignment = StringAlignment.Near};
            _sfCenter = new StringFormat {Alignment = StringAlignment.Center};
            _lineSpacing = (int) _fontDefault.GetHeight(Graphic) + 6;
            _defaultPen = new Pen(Color.Black, 1);
            _defaultBrush = Brushes.Black;
            
        }

        public Kassenbon(Graphics g, FestManagerDataSet.KassenbonDataTable t, string titleString)
        {
            Graphic = g;
            _table = t;
            _title = titleString;

            Init();
        }
        public Kassenbon(Graphics g, FestManagerDataSet.KassenbonDataTable t) {
            Graphic = g;
            _table = t;
            _title = Properties.Settings.Default.organisation + " - Fest " + DateTime.Now.ToString("yyyy");

            Init();
        }

        public void Draw()
        {
            Draw(false);
        }
        public void Draw(bool isCopy)
        {
            if (_table.Rows.Count > 0)
            {
                var firstRow = (FestManagerDataSet.KassenbonRow)_table.Rows[0];

                var y = _marginTop;
                AddHLine(_marginLeft, y);

                y += 0;
                AddString("Festmanager Kassenbon", _marginLeft + _width / 2, y, _fontBold, _sfCenter);

                y += _lineSpacing;
                AddString(_title, _marginLeft + _width / 2, y, _fontBold, _sfCenter);

                y += _lineSpacing;
                AddHLine(_marginLeft, y);

                y += _lineSpacing;
                AddString("Bedienung:", _marginLeft, y, _fontBold, _sfLeft);
                AddString(firstRow.PersonalNr + " - " + firstRow.Personal, _marginLeft + _width, y, _fontDefault, _sfRight);

                y += _lineSpacing;
                AddString("Datum/Uhrzeit:", _marginLeft, y, _fontBold, _sfLeft);
                AddString(firstRow.Zeitpunkt.ToString(CultureInfo.InvariantCulture), _marginLeft + _width, y, _fontDefault, _sfRight);

                if (!string.IsNullOrEmpty(firstRow.Tisch))
                {
                    y += _lineSpacing;
                    AddString("Tisch:", _marginLeft, y, _fontBold, _sfLeft);
                    AddString(firstRow.Tisch, _marginLeft + _width, y, _fontDefault, _sfRight);
                }

                y += _lineSpacing;
                AddString("Bestellung-Nr:", _marginLeft, y, _fontBold, _sfLeft);
                AddString(firstRow.BestellungId.ToString(), _marginLeft + _width, y, _fontDefault, _sfRight);

                y += _lineSpacing;
                AddString("Ausgabe:", _marginLeft, y, _fontBold, _sfLeft);
                if (isCopy)
                {
                    AddString("Kassa (Rechnungskopie)", _marginLeft + _width, y, _fontDefault, _sfRight);
                }
                else
                {
                    AddString(firstRow.Ausgabestelle + "(" + firstRow.AusgabestelleId + ")", _marginLeft + _width, y, _fontDefault, _sfRight);
                }

                y += _lineSpacing;
                AddHLine(_marginLeft, y);

                /* Artikel */
                y += _lineSpacing;
                
                // first group elements:
                var printTable = (DataTable)_table;
                var alreadyGroupedElements = new StringCollection();
                if (Properties.Settings.Default.groupElementsBeforePrint)
                {
                    printTable = new DataTable();
                    printTable.Columns.Add("Artikel", typeof(string));
                    printTable.Columns.Add("Menge", typeof(int));
                    printTable.Columns.Add("Einzelpreis", typeof(decimal));

                    //StringCollection alreadyGroupedElements = new StringCollection();

                    for (var i = 0; i < _table.Rows.Count; i++)
                    {
                        var row = (FestManagerDataSet.KassenbonRow)_table.Rows[i];
                        var artikel = row.Artikel;
                        if (String.Compare("Einpacken", artikel, StringComparison.OrdinalIgnoreCase) == 0)    // look for pressed Einpacken-buttons
                        {
                            continue;
                        }
                        else if (artikel.Contains("***"))    //skip "Leitungswasser" etc.
                        {   
                            continue;
                        }
                        else if (i<_table.Rows.Count-1)
                        {
                            var tmpRow = (FestManagerDataSet.KassenbonRow) _table.Rows[i+1];
                            if (tmpRow.Artikel.Contains("***"))     //skip Artikel with "Leitungswasser" etc.
                            {
                                var dr = printTable.NewRow();
                                dr["Artikel"] = row.Artikel;
                                dr["Menge"] = row.Menge;
                                dr["Einzelpreis"] = row.Einzelpreis;
                                printTable.Rows.Add(dr);
                                dr = printTable.NewRow();
                                dr["Artikel"] = tmpRow.Artikel;
                                dr["Menge"] = tmpRow.Menge;
                                dr["Einzelpreis"] = tmpRow.Einzelpreis;
                                printTable.Rows.Add(dr);
                                continue;
                            }
                        }
                        if (row.Menge < 0)
                            artikel += "_neg_";
                        
                        if (!alreadyGroupedElements.Contains(artikel))
                        {
                            alreadyGroupedElements.Add(artikel);
                            decimal artikelEinzelpreis = 0;
                            var artikelMenge = 0;
                            for (var j = i; j < _table.Rows.Count; j++)
                            {
                                var tmpRow = (FestManagerDataSet.KassenbonRow)_table.Rows[j];
                                var tmpArtikel = tmpRow.Artikel;
                                if (tmpRow.Menge < 0)
                                    tmpArtikel += "_neg_";

                                if (string.CompareOrdinal(tmpArtikel, artikel) != 0 && j != i) continue;

                                if (j < _table.Rows.Count - 1)
                                { 
                                    var tmpRow2 = (FestManagerDataSet.KassenbonRow)_table.Rows[j+1];
                                    if (tmpRow2.Artikel.Contains("***"))     //skip Artikel with "Leitungswasser" etc.
                                        continue;
                                }
                                artikelMenge += tmpRow.Menge;
                                artikelEinzelpreis = tmpRow.Einzelpreis;
                            }

                            var dr = printTable.NewRow();
                            dr["Artikel"] = row.Artikel;
                            dr["Menge"] = artikelMenge;
                            dr["Einzelpreis"] = artikelEinzelpreis;
                            printTable.Rows.Add(dr);
                        }
                    }
                }
                
                // then print:
                decimal summe = 0;
                for (var i = 0; i < printTable.Rows.Count; i++)
                {
                    var row = printTable.Rows[i];
                    var artikel = (string)row["Artikel"];
                    var menge = (int)row["Menge"];
                    var einzelpreis = (decimal)row["Einzelpreis"];

                    if (menge < 0 && !string.IsNullOrEmpty(Properties.Settings.Default.stornoSymbol)) 
                    {
                        if (!Properties.Settings.Default.printStornoOrders)
                            continue;

                        if (artikel.Length > 23)
                            artikel = artikel.Substring(0, 23);

                        artikel = Properties.Settings.Default.stornoSymbol + Properties.Settings.Default.stornoSymbol + Properties.Settings.Default.stornoSymbol + " " + artikel;
                    }
                    var gesamtpreis = einzelpreis * menge;
                    summe += gesamtpreis;
                    AddArtikel(menge, artikel, gesamtpreis, _marginLeft, y);
                    y += _lineSpacing;
                }

                /*if (einpacken)
                {
                    string artikel = artikel = Properties.Settings.Default.einpackenSymbol + Properties.Settings.Default.einpackenSymbol + " Einpacken " + Properties.Settings.Default.einpackenSymbol + Properties.Settings.Default.einpackenSymbol;
                    addArtikel(1, artikel, 0, marginLeft, y);
                    y += lineSpacing;
                }*/

                AddHLine(_marginLeft, y);

                /* Summe */
                AddSumme(summe, _marginLeft, y);

                /* Bestellung erledigt */
                y += 2 * _lineSpacing;

                AddString("Bestellung abgeschlossen", _marginLeft + _lineSpacing + 5, y, _fontDefault, _sfLeft);
                AddHLine(_marginLeft, y, _lineSpacing);
                AddHLine(_marginLeft, y + _lineSpacing, _lineSpacing);
                AddVLine(_marginLeft, y, y + _lineSpacing);
                AddVLine(_marginLeft + _lineSpacing, y, y + _lineSpacing);

                y += 2 * _lineSpacing;
                AddString("-", _marginLeft, y, _fontBold, _sfLeft);
            }
        }


        private void AddString(string text, int x, int y, Font font, StringFormat sFormat)
        {
            Graphic.DrawString(
                text,
                font,
                _defaultBrush,
                new PointF(x, y),
                sFormat
            );                
        }

        private void AddHLine(int x, int y)
        {
            Graphic.DrawLine(
                _defaultPen,
                new Point(x, y),
                new Point(x + _width, y)
            );

        }

        private void AddHLine(int x, int y, int len)
        {
            Graphic.DrawLine(
                _defaultPen,
                new Point(x, y),
                new Point(x + len, y)
            );

        }

        private void AddVLine(int x, int y1, int y2)
        {
            Graphic.DrawLine(
                _defaultPen,
                new Point(x, y1),
                new Point(x, y2)
            );

        }

        private void AddArtikel(int anzahl, string bezeichnung, decimal gesamtpreis, int x, int y)
        {
            Graphic.DrawString(
                anzahl.ToString(),
                _fontDefault,
                _defaultBrush,
                new PointF(x + 20, y),
                _sfRight
            );

            Graphic.DrawString(
                bezeichnung,
                _fontDefault,
                _defaultBrush,
                new PointF(x + 25, y),
                _sfLeft
            );

            Graphic.DrawString(
                gesamtpreis.ToString("0.00") + " €",
                _fontDefault,
                _defaultBrush,
                new PointF(x + _width, y),
                _sfRight
            );


        }

        private void AddSumme(decimal gesamtpreis, int x, int y)
        {
            Graphic.DrawString(
                "Summe: ",
                _fontBold,
                _defaultBrush,
                new PointF(x + 25, y),
                _sfLeft
            );

            Graphic.DrawString(
                gesamtpreis.ToString("0.00") + " €",
                _fontBold,
                _defaultBrush,
                new PointF(x + _width, y),
                _sfRight
            );

            AddHLine(x + 25, y + _lineSpacing, _width - 25);
            AddHLine(x + 25, y + _lineSpacing + 2, _width - 25);

        }
        
    }
}
