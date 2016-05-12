using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FestManager.Utils.Printing;

namespace FestManager.Forms
{
    public partial class FormBestellung : Form
    {
        private int ausgabestelle;
        private FestManager.Data.FestManagerDataSet.BestellungRow bestellungRow;

        public FormBestellung()
        {
            InitializeComponent();


        }

        private void FormBestellung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'festManagerDataSet.Artikel' table. You can move, or remove it, as needed.
            this.artikelTableAdapter.Fill(this.festManagerDataSet.Artikel);
            // TODO: This line of code loads data into the 'festManagerDataSet.Personal' table. You can move, or remove it, as needed.
            this.personalTableAdapter.Fill(this.festManagerDataSet.Personal);
            // TODO: This line of code loads data into the 'festManagerDataSet.Bestellung' table. You can move, or remove it, as needed.
            this.bestellungTableAdapter.Fill(this.festManagerDataSet.Bestellung);

            bestellungRow = this.festManagerDataSet.Bestellung.NewBestellungRow();

            this.zeitpunktTextBox.Text = DateTime.Now.ToString();
            this.bestellungIdTextBox.Text = bestellungRow.BestellungId.ToString();

            this.bestellungArtikelTableAdapter.FillByBestellungId(this.festManagerDataSet.BestellungArtikel, bestellungRow.BestellungId);

        }

        private void abschliessenButton_Click(object sender, EventArgs e)
        {
            bestellungRow.PersonalId = (int) personalIdComboBox.SelectedValue;
            bestellungRow.Zeitpunkt = DateTime.Now;
            bestellungRow.Storniert = "N";
            bestellungRow.Gesamtpreis = 0;
            FestManager.Data.FestManagerDataSet.BestellungArtikelDataTable table = festManagerDataSet.BestellungArtikel;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                bestellungRow.Gesamtpreis += decimal.Parse(table.Rows[i]["GesamtPreis"].ToString());
            }
            bestellungTableAdapter.Insert(bestellungRow.PersonalId, bestellungRow.Zeitpunkt, bestellungRow.Gesamtpreis, bestellungRow.Storniert);
            bestellungArtikelTableAdapter.Update(festManagerDataSet.BestellungArtikel);
            
            //printDocument.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            //printDocument.PrinterSettings.CanDuplex = false;
            //printDocument.PrinterSettings.Copies = 1;
            //printDocument.PrinterSettings.PrinterName
            
            FestManager.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter ausgabestellen = new FestManager.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
            DataTable ausgabe = (DataTable)ausgabestellen.GetData();
            for (int i = 0; i < ausgabe.Rows.Count; i++)
            {
                this.ausgabestelle = (int)ausgabe.Rows[i][0];
                this.printDocument.Print();
            }
            
            MessageBox.Show("Bestellung abgeschlossen!\nGesamtpreis in €: " + bestellungRow.Gesamtpreis.ToString());
        }

        private void resetView()
        {
            bestellungRow = this.festManagerDataSet.Bestellung.NewBestellungRow();
            this.bestellungArtikelTableAdapter.FillByBestellungId(this.festManagerDataSet.BestellungArtikel, bestellungRow.BestellungId);
        }


        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
            this.zeitpunktTextBox.Text = DateTime.Now.ToString();
            this.bestellungIdTextBox.Text = bestellungRow.BestellungId.ToString();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FestManager.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter kbTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
            FestManager.Data.FestManagerDataSet.KassenbonDataTable kbTable = new FestManager.Data.FestManagerDataSet.KassenbonDataTable();
            
            kbTableAdapter.FillByBestellung(kbTable, ausgabestelle, bestellungRow.BestellungId);
            if (kbTable.Rows.Count > 0)
            {
                Kassenbon kb = new Kassenbon(e.Graphics, kbTable, "FF Karlstetten - Fest 2008");
                kb.Draw();
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void artikelLadenButton_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'festManagerDataSet.BestellungArtikel' table. You can move, or remove it, as needed.
            //this.bestellungArtikelTableAdapter.FillByBestellungId(this.festManagerDataSet.BestellungArtikel, bestellungIdTextBox.Text);
        }

        private void artikelDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            

        }

        private void artikelDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
            
        }

        private void artikelDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void artikelDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            artikelDataGridView.Rows[e.RowIndex].Cells[0].Value = bestellungRow.BestellungId;
        }

        private void stornierenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bestellung storniert!");
        }

        private void FormBestellung_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void artikelDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void artikelDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 2 && artikelDataGridView.Rows[e.RowIndex].Cells[2].Value != null)
            {
                String shortcut = artikelDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                
                int shortcutValue = 0;
                try
                {
                    shortcutValue = Int32.Parse(shortcut);
                }
                catch (Exception)
                {
                    return;
                }

                int? artikelId = null;
                decimal? preis = 0;
                if (shortcutValue > 0)
                {
                    artikelId = artikelTableAdapter.GetArtikelIdByShortcut(shortcutValue);
                    preis = artikelTableAdapter.GetEinzelpreisByShortcurt(shortcutValue);
                }

                if (artikelId != null)
                {
                    artikelDataGridView.Rows[e.RowIndex].Cells[3].Value = artikelId;
                    artikelDataGridView.Rows[e.RowIndex].Cells[4].Value = preis * int.Parse(artikelDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                else
                {
                    artikelDataGridView.Rows[e.RowIndex].Cells[2].Value = null;
                    MessageBox.Show("Artikel nicht gefunden!");
                }
            }
        }
    }
}