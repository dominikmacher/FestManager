using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Drawing;
using System.Data;
using FestManager_Core.Data;
using FestManager_Core.Data.FestManagerDataSetTableAdapters;

namespace FestManager_Core.Utils.Printing
{
    public class Kassenbon
    {
        private static int width = 200;
        private static int marginTop = 10;
        private static int marginLeft = 10;

        /* Components */
        private Font fontDefault;
        private Font fontBold;
        private StringFormat sfRight;
        private StringFormat sfLeft;
        private StringFormat sfCenter;
        private Graphics graphics;
        private FestManagerDataSet.KassenbonDataTable table;
        private String title;
        private int lineSpacing = 5;
        private Pen defaultPen;
        private Brush defaultBrush;

        public Graphics Graphic
        {
            get { return graphics; }
        }

        private void init()
        {
            fontDefault = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);


            fontBold = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
            

            sfRight = new StringFormat();
            sfRight.Alignment = StringAlignment.Far;

            sfLeft = new StringFormat();
            sfLeft.Alignment = StringAlignment.Near;

            sfCenter = new StringFormat();
            sfCenter.Alignment = StringAlignment.Center;

            lineSpacing = (int) fontDefault.GetHeight(graphics) + 6;

            defaultPen = new Pen(Color.Black, 1);

            defaultBrush = Brushes.Black;
            
        }

        public Kassenbon(Graphics g, FestManagerDataSet.KassenbonDataTable t, String titleString)
        {
            graphics = g;
            table = t;
            title = titleString;

            init();
        }
        public Kassenbon(Graphics g, FestManagerDataSet.KassenbonDataTable t) {
            graphics = g;
            table = t;
            title = Properties.Settings.Default.organisation + " - Fest " + DateTime.Now.ToString("yyyy");

            init();
        }

        public void Draw()
        {
            Draw(false);
        }
        public void Draw(bool isCopy)
        {
            if (table.Rows.Count > 0)
            {
                FestManagerDataSet.KassenbonRow firstRow = (FestManagerDataSet.KassenbonRow)table.Rows[0];

                int y = marginTop;
                addHLine(marginLeft, y);

                y += 0;
                addString("Festmanager Kassenbon", marginLeft + width / 2, y, fontBold, sfCenter);

                y += lineSpacing;
                addString(title, marginLeft + width / 2, y, fontBold, sfCenter);

                y += lineSpacing;
                addHLine(marginLeft, y);

                PersonalTableAdapter personal = new PersonalTableAdapter();

                y += lineSpacing;
                addString("Bedienung:", marginLeft, y, fontBold, sfLeft);
                addString(firstRow.PersonalNr + " - " + firstRow.Personal, marginLeft + width, y, fontDefault, sfRight);

                y += lineSpacing;
                addString("Datum/Uhrzeit:", marginLeft, y, fontBold, sfLeft);
                addString(firstRow.Zeitpunkt.ToString(), marginLeft + width, y, fontDefault, sfRight);

                if (!String.IsNullOrEmpty(firstRow.Tisch.ToString()))
                {
                    y += lineSpacing;
                    addString("Tisch:", marginLeft, y, fontBold, sfLeft);
                    addString(firstRow.Tisch.ToString(), marginLeft + width, y, fontDefault, sfRight);
                }

                y += lineSpacing;
                addString("Bestellung-Nr:", marginLeft, y, fontBold, sfLeft);
                addString(firstRow.BestellungId.ToString(), marginLeft + width, y, fontDefault, sfRight);

                y += lineSpacing;
                addString("Ausgabe:", marginLeft, y, fontBold, sfLeft);
                if (isCopy)
                {
                    addString("Kassa (Rechnungskopie)", marginLeft + width, y, fontDefault, sfRight);
                }
                else
                {
                    addString(firstRow.Ausgabestelle + "(" + firstRow.AusgabestelleId.ToString() + ")", marginLeft + width, y, fontDefault, sfRight);
                }

                y += lineSpacing;
                addHLine(marginLeft, y);

                /* Artikel */
                y += lineSpacing;
                
                // first group elements:
                bool einpacken = false;
                DataTable printTable = (DataTable)this.table;
                StringCollection alreadyGroupedElements = new StringCollection();
                if (Properties.Settings.Default.groupElementsBeforePrint)
                {
                    printTable = new DataTable();
                    printTable.Columns.Add("Artikel", typeof(String));
                    printTable.Columns.Add("Menge", typeof(Int32));
                    printTable.Columns.Add("Einzelpreis", typeof(Decimal));

                    //StringCollection alreadyGroupedElements = new StringCollection();

                    for (int i = 0; i < this.table.Rows.Count; i++)
                    {
                        FestManagerDataSet.KassenbonRow row = (FestManagerDataSet.KassenbonRow)this.table.Rows[i];
                        string artikel = row.Artikel;
                        if (String.Compare("Einpacken", artikel, true) == 0)    // look for pressed Einpacken-buttons
                        {
                            einpacken = true;
                            continue;
                        }
                        else if (artikel.Contains("***"))    //skip "Leitungswasser" etc.
                        {   
                            continue;
                        }
                        else if (i<this.table.Rows.Count-1)
                        {
                            FestManagerDataSet.KassenbonRow tmpRow = (FestManagerDataSet.KassenbonRow)this.table.Rows[i+1];
                            if (tmpRow.Artikel.Contains("***"))     //skip Artikel with "Leitungswasser" etc.
                            {
                                DataRow dr = printTable.NewRow();
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
                            int artikelMenge = 0;
                            for (int j = i; j < this.table.Rows.Count; j++)
                            {
                                FestManagerDataSet.KassenbonRow tmpRow = (FestManagerDataSet.KassenbonRow)this.table.Rows[j];
                                string tmpArtikel = tmpRow.Artikel;
                                if (tmpRow.Menge < 0)
                                    tmpArtikel += "_neg_";

                                if (String.Compare(tmpArtikel, artikel) == 0 || j == i)
                                {
                                    if (j < this.table.Rows.Count - 1)
                                    { 
                                        FestManagerDataSet.KassenbonRow tmpRow2 = (FestManagerDataSet.KassenbonRow)this.table.Rows[j+1];
                                        if (tmpRow2.Artikel.Contains("***"))     //skip Artikel with "Leitungswasser" etc.
                                            continue;
                                    }
                                    artikelMenge += tmpRow.Menge;
                                    artikelEinzelpreis = tmpRow.Einzelpreis;
                                }
                            }

                            DataRow dr = printTable.NewRow();
                            dr["Artikel"] = row.Artikel;
                            dr["Menge"] = artikelMenge;
                            dr["Einzelpreis"] = artikelEinzelpreis;
                            printTable.Rows.Add(dr);
                        }
                    }
                }
                
                // then print:
                decimal summe = 0;
                for (int i = 0; i < printTable.Rows.Count; i++)
                {
                    DataRow row = printTable.Rows[i];
                    string artikel = (string)row["Artikel"];
                    int menge = (int)row["Menge"];
                    decimal einzelpreis = (decimal)row["Einzelpreis"];

                    if (menge < 0 && !String.IsNullOrEmpty(Properties.Settings.Default.stornoSymbol)) 
                    {
                        if (!Properties.Settings.Default.printStornoOrders)
                            continue;

                        if (artikel.Length > 23)
                            artikel = artikel.Substring(0, 23);

                        artikel = Properties.Settings.Default.stornoSymbol + Properties.Settings.Default.stornoSymbol + Properties.Settings.Default.stornoSymbol + " " + artikel;
                    }
                    decimal gesamtpreis = einzelpreis * menge;
                    summe += gesamtpreis;
                    addArtikel(menge, artikel, gesamtpreis, marginLeft, y);
                    y += lineSpacing;
                }

                if (einpacken)
                {
                    string artikel = artikel = Properties.Settings.Default.einpackenSymbol + Properties.Settings.Default.einpackenSymbol + " Einpacken " + Properties.Settings.Default.einpackenSymbol + Properties.Settings.Default.einpackenSymbol;
                    addArtikel(1, artikel, 0, marginLeft, y);
                    y += lineSpacing;
                }

                addHLine(marginLeft, y);

                /* Summe */
                addSumme(summe, marginLeft, y);

                /* Bestellung erledigt */
                y += 2 * lineSpacing;

                addString("Bestellung abgeschlossen", marginLeft + lineSpacing + 5, y, fontDefault, sfLeft);
                addHLine(marginLeft, y, lineSpacing);
                addHLine(marginLeft, y + lineSpacing, lineSpacing);
                addVLine(marginLeft, y, y + lineSpacing);
                addVLine(marginLeft + lineSpacing, y, y + lineSpacing);

                y += 2 * lineSpacing;
                addString("-", marginLeft, y, fontBold, sfLeft);
            }
        }


        private void addString(String text, int x, int y, Font font, StringFormat sFormat)
        {
            graphics.DrawString(
                text,
                font,
                defaultBrush,
                new PointF(x, y),
                sFormat
            );                
        }

        private void addHLine(int x, int y)
        {
            graphics.DrawLine(
                defaultPen,
                new Point(x, y),
                new Point(x + width, y)
            );

        }

        private void addHLine(int x, int y, int len)
        {
            graphics.DrawLine(
                defaultPen,
                new Point(x, y),
                new Point(x + len, y)
            );

        }

        private void addVLine(int x, int y1, int y2)
        {
            graphics.DrawLine(
                defaultPen,
                new Point(x, y1),
                new Point(x, y2)
            );

        }

        private void addArtikel(int anzahl, string bezeichnung, decimal gesamtpreis, int x, int y)
        {
            graphics.DrawString(
                anzahl.ToString(),
                fontDefault,
                defaultBrush,
                new PointF((float) x + 20, (float) y),
                sfRight
            );

            graphics.DrawString(
                bezeichnung,
                fontDefault,
                defaultBrush,
                new PointF(x + 25, y),
                sfLeft
            );

            graphics.DrawString(
                gesamtpreis.ToString("0.00") + " €",
                fontDefault,
                defaultBrush,
                new PointF(x + width, y),
                sfRight
            );


        }

        private void addSumme(decimal gesamtpreis, int x, int y)
        {
            graphics.DrawString(
                "Summe: ",
                fontBold,
                defaultBrush,
                new PointF(x + 25, y),
                sfLeft
            );

            graphics.DrawString(
                gesamtpreis.ToString("0.00") + " €",
                fontBold,
                defaultBrush,
                new PointF(x + width, y),
                sfRight
            );

            addHLine(x + 25, y + lineSpacing, width - 25);
            addHLine(x + 25, y + lineSpacing + 2, width - 25);

        }
        
    }
}
