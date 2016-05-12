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

            personalIdComboBox.Focus();
        }

        private void FormBestellung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'festManagerDataSet.PersonalKuerzel_V' table. You can move, or remove it, as needed.
            this.personal_VTableAdapter.Fill(this.festManagerDataSet.Personal_V);

            newRecordset();
        }

        private void newRecordset()
        {
            // TODO: This line of code loads data into the 'festManagerDataSet.Artikel' table. You can move, or remove it, as needed.
            this.artikelTableAdapter.Fill(this.festManagerDataSet.Artikel);
            // TODO: This line of code loads data into the 'festManagerDataSet.Bestellung' table. You can move, or remove it, as needed.
            this.bestellungTableAdapter.Fill(this.festManagerDataSet.Bestellung);

            bestellungRow = this.festManagerDataSet.Bestellung.NewBestellungRow();

            this.zeitpunktTextBox.Text = DateTime.Now.ToString();
            this.bestellungIdTextBox.Text = bestellungRow.BestellungId.ToString();

            this.bestellungArtikelTableAdapter.FillByBestellungId(this.festManagerDataSet.BestellungArtikel, bestellungRow.BestellungId);

            personalIdComboBox.Focus();
        }

        private void abschliessenButton_Click(object sender, EventArgs e)
        {
            bestellungRow.Zeitpunkt = DateTime.Now;
            bestellungRow.Storniert = "N";
            bestellungRow.Gesamtpreis = 0;

            try
            {
                bestellungRow.PersonalId = (int)personalIdComboBox.SelectedValue;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ungültiger Kellner gewählt!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            FestManager.Data.FestManagerDataSet.BestellungArtikelDataTable table = festManagerDataSet.BestellungArtikel;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                bestellungRow.Gesamtpreis += decimal.Parse(table.Rows[i]["GesamtPreis"].ToString()) * decimal.Parse(table.Rows[i]["Menge"].ToString());
            }

            try
            {
                bestellungTableAdapter.Insert(bestellungRow.PersonalId, bestellungRow.Zeitpunkt, bestellungRow.Gesamtpreis, bestellungRow.Storniert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern der Bestellung!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                    
            bestellungArtikelTableAdapter.Update(festManagerDataSet.BestellungArtikel);

            FestManager.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter ausgabestellen = new FestManager.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
            FestManager.Data.FestManagerDataSet.AusgabestelleDataTable ausgabe = (FestManager.Data.FestManagerDataSet.AusgabestelleDataTable) ausgabestellen.GetData();
            
            printDocument.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            printDocument.PrinterSettings.Copies = 1;
            
            
            
            for (int i = 0; i < ausgabe.Rows.Count; i++)
            {

                FestManager.Data.FestManagerDataSet.AusgabestelleRow row = 
                    (FestManager.Data.FestManagerDataSet.AusgabestelleRow) ausgabe.Rows[i];

                this.ausgabestelle = (int)row.AusgabestelleId;

                FestManager.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter kbTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
                FestManager.Data.FestManagerDataSet.KassenbonDataTable kbTable = new FestManager.Data.FestManagerDataSet.KassenbonDataTable();
                kbTableAdapter.FillByBestellung(kbTable, bestellungRow.BestellungId, ausgabestelle);
                

                if (kbTable.Rows.Count > 0)
                {

                    MessageBox.Show(ausgabestelle.ToString());
                    this.printDocument.PrinterSettings.PrinterName = row.Drucker;
                    
                    DialogResult result = DialogResult.Retry;
                    while(result == DialogResult.Retry)
                    {
                        try
                        {
                            this.printDocument.Print();
                            result = DialogResult.OK;
                        }
                        catch (Exception exc)
                        {
                            result = MessageBox.Show("Fehler beim Drucken" + exc.Message, "Fehler", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            
            MessageBox.Show("Bestellung abgeschlossen!\nGesamtpreis in €: " + bestellungRow.Gesamtpreis.ToString());

            newRecordset();
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

            kbTableAdapter.FillByBestellung(kbTable, bestellungRow.BestellungId, ausgabestelle);
            if (kbTable.Rows.Count > 0)
            {
                Kassenbon kb = new Kassenbon(e.Graphics, kbTable, "MV-Karlstetten - Fest 2008");
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
            bestellungRow.Zeitpunkt = DateTime.Now;
            bestellungRow.Storniert = "Y";
            bestellungRow.Gesamtpreis = 0;

            try
            {
                bestellungRow.PersonalId = (int)personalIdComboBox.SelectedValue;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ungültiger Kellner gewählt!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            FestManager.Data.FestManagerDataSet.BestellungArtikelDataTable table = festManagerDataSet.BestellungArtikel;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                bestellungRow.Gesamtpreis += decimal.Parse(table.Rows[i]["GesamtPreis"].ToString());
            }

            try
            {

                bestellungTableAdapter.Insert(bestellungRow.PersonalId, bestellungRow.Zeitpunkt, bestellungRow.Gesamtpreis, bestellungRow.Storniert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern der Bestellung!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bestellungArtikelTableAdapter.Update(festManagerDataSet.BestellungArtikel);

            //this.festManagerDataSet.BestellungArtikel.Clear();

            MessageBox.Show("Bestellung storniert!");

            newRecordset();
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
                    artikelId = artikelTableAdapter.GetArtikelIdByShortCut(shortcutValue);
                    preis = artikelTableAdapter.GetEinzelpreisByShortCut(shortcutValue);
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