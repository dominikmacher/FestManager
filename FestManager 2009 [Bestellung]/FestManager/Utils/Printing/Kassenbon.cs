using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using FestManager.Data;
using FestManager.Data.FestManagerDataSetTableAdapters;

namespace FestManager.Utils.Printing
{
    class Kassenbon
    {
        private static int width = 200;
        private static int marginTop = 10;
        private static int marginLeft = 10;

        public bool isCopy = false;

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

        public void Draw()
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

                y += lineSpacing;
                addString("Bestellung-Nr:", marginLeft, y, fontBold, sfLeft);
                addString(firstRow.BestellungId.ToString(), marginLeft + width, y, fontDefault, sfRight);

                y += lineSpacing;
                addString("Ausgabe:", marginLeft, y, fontBold, sfLeft);
                if (this.isCopy)
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
                /*
                addArtikel(1, "Grillhenderl", (decimal) 3.50000, marginLeft, y);
                y += lineSpacing;
                */

                decimal summe = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    FestManagerDataSet.KassenbonRow row = (FestManagerDataSet.KassenbonRow)table.Rows[i];
                    decimal gesamtpreis = row.Einzelpreis * row.Menge;
                    summe += gesamtpreis;
                    addArtikel(row.Menge, row.Artikel, gesamtpreis, marginLeft, y);
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
