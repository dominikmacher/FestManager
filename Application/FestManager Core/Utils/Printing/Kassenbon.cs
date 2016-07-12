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
        private static readonly int Width = 200;
        private static readonly int MarginTop = 10;
        private static readonly int MarginLeft = 10;

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
            _title = FestManagerSettings.Default.Organisation + " - Fest " + DateTime.Now.ToString("yyyy");

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

                var y = MarginTop;
                AddHLine(MarginLeft, y);

                y += 0;
                AddString("Festmanager Kassenbon", MarginLeft + Width / 2, y, _fontBold, _sfCenter);

                y += _lineSpacing;
                AddString(_title, MarginLeft + Width / 2, y, _fontBold, _sfCenter);

                y += _lineSpacing;
                AddHLine(MarginLeft, y);

                y += _lineSpacing;
                AddString("Bedienung:", MarginLeft, y, _fontBold, _sfLeft);
                AddString(firstRow.PersonalNr + " - " + firstRow.Personal, MarginLeft + Width, y, _fontDefault, _sfRight);

                y += _lineSpacing;
                AddString("Datum/Uhrzeit:", MarginLeft, y, _fontBold, _sfLeft);
                AddString(firstRow.Zeitpunkt.ToString(CultureInfo.InvariantCulture), MarginLeft + Width, y, _fontDefault, _sfRight);

                if (!string.IsNullOrEmpty(firstRow.Tisch))
                {
                    y += _lineSpacing;
                    AddString("Tisch:", MarginLeft, y, _fontBold, _sfLeft);
                    AddString(firstRow.Tisch, MarginLeft + Width, y, _fontDefault, _sfRight);
                }

                y += _lineSpacing;
                AddString("Bestellung-Nr:", MarginLeft, y, _fontBold, _sfLeft);
                AddString(firstRow.BestellungId.ToString(), MarginLeft + Width, y, _fontDefault, _sfRight);

                y += _lineSpacing;
                AddString("Ausgabe:", MarginLeft, y, _fontBold, _sfLeft);
                if (isCopy)
                {
                    AddString("Kassa (Rechnungskopie)", MarginLeft + Width, y, _fontDefault, _sfRight);
                }
                else
                {
                    AddString(firstRow.Ausgabestelle + "(" + firstRow.AusgabestelleId + ")", MarginLeft + Width, y, _fontDefault, _sfRight);
                }

                y += _lineSpacing;
                AddHLine(MarginLeft, y);

                /* Artikel */
                y += _lineSpacing;
                
                // first group elements:
                var printTable = (DataTable)_table;
                var alreadyGroupedElements = new StringCollection();
                if (FestManagerSettings.Default.GroupElementsBeforePrint)
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
                        if (string.Compare("Einpacken", artikel, StringComparison.OrdinalIgnoreCase) == 0)    // look for pressed Einpacken-buttons
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

                    if (menge < 0 && !string.IsNullOrEmpty(FestManagerSettings.Default.StornoSymbol)) 
                    {
                        if (!FestManagerSettings.Default.PrintStornoOrders)
                            continue;

                        if (artikel.Length > 23)
                            artikel = artikel.Substring(0, 23);

                        artikel = FestManagerSettings.Default.StornoSymbol + FestManagerSettings.Default.StornoSymbol + FestManagerSettings.Default.StornoSymbol + " " + artikel;
                    }
                    var gesamtpreis = einzelpreis * menge;
                    summe += gesamtpreis;
                    AddArtikel(menge, artikel, gesamtpreis, MarginLeft, y);
                    y += _lineSpacing;
                }

                /*if (einpacken)
                {
                    string artikel = artikel = Properties.Settings.Default.einpackenSymbol + Properties.Settings.Default.einpackenSymbol + " Einpacken " + Properties.Settings.Default.einpackenSymbol + Properties.Settings.Default.einpackenSymbol;
                    addArtikel(1, artikel, 0, marginLeft, y);
                    y += lineSpacing;
                }*/

                AddHLine(MarginLeft, y);

                /* Summe */
                AddSumme(summe, MarginLeft, y);

                /* Bestellung erledigt */
                y += 2 * _lineSpacing;

                AddString("Bestellung abgeschlossen", MarginLeft + _lineSpacing + 5, y, _fontDefault, _sfLeft);
                AddHLine(MarginLeft, y, _lineSpacing);
                AddHLine(MarginLeft, y + _lineSpacing, _lineSpacing);
                AddVLine(MarginLeft, y, y + _lineSpacing);
                AddVLine(MarginLeft + _lineSpacing, y, y + _lineSpacing);

                y += 2 * _lineSpacing;
                AddString("-", MarginLeft, y, _fontBold, _sfLeft);
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
                new Point(x + Width, y)
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
                new PointF(x + Width, y),
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
                new PointF(x + Width, y),
                _sfRight
            );

            AddHLine(x + 25, y + _lineSpacing, Width - 25);
            AddHLine(x + 25, y + _lineSpacing + 2, Width - 25);

        }
        
    }
}
