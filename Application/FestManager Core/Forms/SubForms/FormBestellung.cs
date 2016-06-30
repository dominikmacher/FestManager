using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FestManager_Core.Utils.Printing;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormBestellung : Form
    {
        private int ausgabestelle;
        private bool printDirektverkaufTwice;
        private int direktverkauftPersonalId = 1;
        private int direktverkaufAusgabestelleId = 0;
        private bool printAll = false;
        private bool tischEnabled = true;
        private FestManager_Core.Data.FestManagerDataSet.BestellungRow bestellungRow;

        public FormBestellung()
        {
            InitializeComponent();
            this.printDirektverkaufTwice = Properties.Settings.Default.printDirektverkaufTwice;
            this.direktverkauftPersonalId = Properties.Settings.Default.direktverkaufPersonalId;
            this.direktverkaufAusgabestelleId = Properties.Settings.Default.direktverkaufAusgabestelleId;
            this.tischEnabled = Properties.Settings.Default.tableNumbers;
            personalIdComboBox.Focus();

            if (!this.tischEnabled)
            {
                tischLabel.Visible = false;
                tischTextBox.Visible = false;
            }

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
            newRecordset(false);
        }
        private void newRecordset(bool storno)
        {
            // TODO: This line of code loads data into the 'festManagerDataSet.Artikel' table. You can move, or remove it, as needed.
            this.artikelTableAdapter.FillGueltige(this.festManagerDataSet.Artikel);
            
            if (!storno)
            {
                // TODO: This line of code loads data into the 'festManagerDataSet.Bestellung' table. You can move, or remove it, as needed.
                this.bestellungTableAdapter.Fill(this.festManagerDataSet.Bestellung);
                bestellungRow = this.festManagerDataSet.Bestellung.NewBestellungRow();
            }
            this.zeitpunktTextBox.Text = DateTime.Now.ToString();
            this.tischTextBox.Text = "";
            this.rueckgaengigButton.Visible = false;
            this.bestellungIdTextBox.Text = bestellungRow.BestellungId.ToString();

            this.bestellungArtikelTableAdapter.FillByBestellungId(this.festManagerDataSet.BestellungArtikel, bestellungRow.BestellungId);

            personalIdComboBox.Focus();
        }

        private void calculateGesamtpreis()
        {
            bestellungRow.Gesamtpreis = 0;

            //FestManager_Core.Data.FestManagerDataSet.BestellungArtikelDataTable table = festManagerDataSet.BestellungArtikel;
            for (int i = 0; i < artikelDataGridView.Rows.Count-1; i++)
            {
                bestellungRow.Gesamtpreis += decimal.Parse(artikelDataGridView.Rows[i].Cells[4].Value.ToString());
            }
        }

        private void abschliessenButton_Click(object sender, EventArgs e)
        {
            bestellungRow.Zeitpunkt = DateTime.Now;
            bestellungRow.Storniert = "N";
            bestellungRow.Tisch = this.tischTextBox.Text;
            printAll = false;

            try
            {
                bestellungRow.PersonalId = (int)personalIdComboBox.SelectedValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ungültiger Kellner gewählt!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.calculateGesamtpreis();            

            try
            {
                bestellungTableAdapter.Insert(bestellungRow.PersonalId, bestellungRow.Zeitpunkt, bestellungRow.Gesamtpreis, bestellungRow.Tisch, bestellungRow.Storniert, "N");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern der Bestellung!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                    
            bestellungArtikelTableAdapter.Update(festManagerDataSet.BestellungArtikel);

            printBestellung();
            
            MessageBox.Show("Bestellung abgeschlossen!\nGesamtpreis in €: " + bestellungRow.Gesamtpreis.ToString());
            
            newRecordset();
        }


        private void printBestellung()
        {
            printBestellung(false);
        }
        private void printBestellung(bool secondPrint)
        {
            FestManager_Core.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter ausgabestellen = new FestManager_Core.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
            FestManager_Core.Data.FestManagerDataSet.AusgabestelleDataTable ausgabe = (FestManager_Core.Data.FestManagerDataSet.AusgabestelleDataTable)ausgabestellen.GetData();

            printDocument.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            printDocument.PrinterSettings.Copies = 1;

            if (!secondPrint)
            {
                for (int i = 0; i < ausgabe.Rows.Count; i++)
                {
                    FestManager_Core.Data.FestManagerDataSet.AusgabestelleRow row =
                        (FestManager_Core.Data.FestManagerDataSet.AusgabestelleRow)ausgabe.Rows[i];

                    printKassabon(row);
                }
            }

            if ((printDirektverkaufTwice && (int)this.personalIdComboBox.SelectedValue == this.direktverkauftPersonalId) || secondPrint)
            {
                printAll = true;
                ausgabestellen = new FestManager_Core.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
                ausgabe = (FestManager_Core.Data.FestManagerDataSet.AusgabestelleDataTable)ausgabestellen.GetKassaData();

                if (ausgabe.Count > this.direktverkaufAusgabestelleId)
                {
                    printDocument.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
                    printDocument.PrinterSettings.Copies = 1;

                    FestManager_Core.Data.FestManagerDataSet.AusgabestelleRow row =
                        (FestManager_Core.Data.FestManagerDataSet.AusgabestelleRow)ausgabe.Rows[this.direktverkaufAusgabestelleId];
                    
                    printKassabon(row);
                }
                else
                {
                    MessageBox.Show("Fehler: Kein 'Kassa'-Drucker eingerichtet !!");
                }
            }
        }

        private void printKassabon(Data.FestManagerDataSet.AusgabestelleRow row)
        {
            FestManager_Core.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter kbTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
            FestManager_Core.Data.FestManagerDataSet.KassenbonDataTable kbTable = new FestManager_Core.Data.FestManagerDataSet.KassenbonDataTable();

            if (bestellungRow.BestellungId == 0)
            {
                MessageBox.Show("Fehler: Bestellung wird nicht gedruckt! Bitte starten Sie die Applikation neu.");
            }
            if (printAll)
            {
                kbTableAdapter.FillByBestellung(kbTable, bestellungRow.BestellungId);
            }
            else
            {
                this.ausgabestelle = (int)row.AusgabestelleId;
                kbTableAdapter.FillByBestellungAndAusgabestelle(kbTable, bestellungRow.BestellungId, ausgabestelle);
            }
            
            
            if (kbTable.Rows.Count == 0) {
                //MessageBox.Show(this.ausgabestelle + ": huhu => " + bestellungRow.BestellungId.ToString());
            }
            if (kbTable.Rows.Count > 0)
            {
                bool print = true;
                if (!Properties.Settings.Default.printStornoOrders)
                {
                    print=false;
                    for (int i = 0; i < kbTable.Rows.Count; i++)
                    {
                        FestManager_Core.Data.FestManagerDataSet.KassenbonRow kbRow = (FestManager_Core.Data.FestManagerDataSet.KassenbonRow)kbTable.Rows[i];
                        if (kbRow.Menge >= 0)
                        {
                            print = true;
                            break;
                        }
                    }
                }

                if (print)
                {
                    this.printDocument.PrinterSettings.PrinterName = row.Drucker;

                    DialogResult result = DialogResult.Retry;
                    while (result == DialogResult.Retry)
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
            FestManager_Core.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter kbTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
            FestManager_Core.Data.FestManagerDataSet.KassenbonDataTable kbTable = new FestManager_Core.Data.FestManagerDataSet.KassenbonDataTable();

            if (printAll)
            {
                kbTableAdapter.FillByBestellung(kbTable, bestellungRow.BestellungId);
            }
            else
            {
                kbTableAdapter.FillByBestellungAndAusgabestelle(kbTable, bestellungRow.BestellungId, ausgabestelle);
            }
            if (kbTable.Rows.Count > 0)
            {
                Kassenbon kb = new Kassenbon(e.Graphics, kbTable);
                // Important for Kassa-Prints:
                kb.Draw(printAll);
            }
            
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void artikelDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            artikelDataGridView.Rows[e.RowIndex].Cells[0].Value = bestellungRow.BestellungId;
        }

        private void stornierenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bestellung wird nun storniert...");

            newRecordset(true);
        }

        private void artikelDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 1) && artikelDataGridView.Rows[e.RowIndex].Cells[2].Value != null)
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
                    artikelId = artikelTableAdapter.GetGueltigArtikelIdByShortCut(shortcutValue);
                    preis = artikelTableAdapter.GetEinzelpreisByShortCut(shortcutValue);
                }

                if (artikelId != null)
                {
                    artikelDataGridView.Rows[e.RowIndex].Cells[3].Value = artikelId;
                    artikelDataGridView.Rows[e.RowIndex].Cells[4].Value = preis * int.Parse(artikelDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    this.rueckgaengigButton.Visible = true;

                    calculateGesamtpreis();
                    this.gesamtpreisTextBox.Text = bestellungRow.Gesamtpreis.ToString();
                }
                else
                {
                    artikelDataGridView.Rows[e.RowIndex].Cells[2].Value = DBNull.Value;
                    MessageBox.Show("Artikel nicht gefunden!");

                    artikelDataGridView.Rows[e.RowIndex].Cells[1].Value = DBNull.Value;
                    artikelDataGridView.Rows[e.RowIndex].Cells[3].Value = DBNull.Value;
                    artikelDataGridView.Rows[e.RowIndex].Cells[4].Value = DBNull.Value;

                    bestellungArtikelBindingSource.CancelEdit();
                    artikelDataGridView.RefreshEdit();

                    SendKeys.Send("{LEFT}");
                    SendKeys.Send("{LEFT}");
                    SendKeys.Send("{LEFT}");
                }
            }
        }


        private void personalIdComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.tischEnabled)
                {
                    tischTextBox.Focus();
                }
                else
                {
                    artikelDataGridView.Focus();
                }
            }
            else Application.DoEvents();
        }

        private void tischTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                artikelDataGridView.Focus();
            }
            else Application.DoEvents();
        }

        private void printLastOrderButton_Click(object sender, EventArgs e)
        {
            int bkpBestellungId = bestellungRow.BestellungId;

            bestellungRow.BestellungId = (int)bestellungTableAdapter.GetMaxBestellungId();
            printBestellung(true);            

            bestellungRow.BestellungId = bkpBestellungId;
        }

        private void removeRow(bool removeCurrentRow)
        {
            if (artikelDataGridView.Rows.Count > 1)
            {
                if (removeCurrentRow == false)
                {
                    artikelDataGridView.Rows.RemoveAt(artikelDataGridView.Rows.Count - 2);
                }
                else 
                {
                    artikelDataGridView.Rows.RemoveAt(artikelDataGridView.Rows.Count - 1);
                }
                calculateGesamtpreis();
                this.gesamtpreisTextBox.Text = bestellungRow.Gesamtpreis.ToString();
            }
        }

        private void rueckgaengigButton_Click(object sender, EventArgs e)
        {
            removeRow(false);
            artikelDataGridView.Focus();
            artikelDataGridView.MultiSelect = false;
            artikelDataGridView.Rows[artikelDataGridView.Rows.Count-1].Cells[1].Selected = true;
        }

    }
}