using System;
using System.Globalization;
using System.Windows.Forms;
using FestManager_Core.Properties;
using FestManager_Core.Utils.Printing;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormBestellung : Form
    {
        private int _ausgabestelle;
        private readonly bool _printDirektverkaufTwice;
        private readonly int _direktverkauftPersonalId;
        private readonly int _direktverkaufAusgabestelleId;
        private bool _printAll;
        private readonly bool _tischEnabled;
        private Data.FestManagerDataSet.BestellungRow _bestellungRow;

        public FormBestellung()
        {
            InitializeComponent();
            _printDirektverkaufTwice = Settings.Default.printDirektverkaufTwice;
            _direktverkauftPersonalId = Settings.Default.direktverkaufPersonalId;
            _direktverkaufAusgabestelleId = Settings.Default.direktverkaufAusgabestelleId;
            _tischEnabled = Settings.Default.tableNumbers;
            personalIdComboBox.Focus();

            if (!_tischEnabled)
            {
                tischLabel.Visible = false;
                tischTextBox.Visible = false;
            }

            personalIdComboBox.Focus();
        }

        private void FormBestellung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'festManagerDataSet.PersonalKuerzel_V' table. You can move, or remove it, as needed.
            personal_VTableAdapter.Fill(festManagerDataSet.Personal_V);

            NewRecordset();
        }

        private void NewRecordset()
        {
            NewRecordset(false);
        }
        private void NewRecordset(bool storno)
        {
            // TODO: This line of code loads data into the 'festManagerDataSet.Artikel' table. You can move, or remove it, as needed.
            artikelTableAdapter.FillGueltige(festManagerDataSet.Artikel);
            
            if (!storno)
            {
                // TODO: This line of code loads data into the 'festManagerDataSet.Bestellung' table. You can move, or remove it, as needed.
                bestellungTableAdapter.Fill(festManagerDataSet.Bestellung);
                _bestellungRow = festManagerDataSet.Bestellung.NewBestellungRow();
            }
            zeitpunktTextBox.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            tischTextBox.Text = "";
            rueckgaengigButton.Visible = false;
            bestellungIdTextBox.Text = _bestellungRow.BestellungId.ToString();

            bestellungArtikelTableAdapter.FillByBestellungId(festManagerDataSet.BestellungArtikel, _bestellungRow.BestellungId);

            personalIdComboBox.Focus();
        }

        private void CalculateGesamtpreis()
        {
            _bestellungRow.Gesamtpreis = 0;

            //FestManager_Core.Data.FestManagerDataSet.BestellungArtikelDataTable table = festManagerDataSet.BestellungArtikel;
            for (int i = 0; i < artikelDataGridView.Rows.Count-1; i++)
            {
                _bestellungRow.Gesamtpreis += decimal.Parse(artikelDataGridView.Rows[i].Cells[4].Value.ToString());
            }
        }

        private void abschliessenButton_Click(object sender, EventArgs e)
        {
            _bestellungRow.Zeitpunkt = DateTime.Now;
            _bestellungRow.Storniert = "N";
            _bestellungRow.Tisch = tischTextBox.Text;
            _printAll = false;

            try
            {
                _bestellungRow.PersonalId = (int)personalIdComboBox.SelectedValue;
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.FormBestellung_abschliessenButton_Click_Invalid_Waiter_selected, Resources.FormBestellung_abschliessenButton_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CalculateGesamtpreis();            

            try
            {
                bestellungTableAdapter.Insert(_bestellungRow.PersonalId, _bestellungRow.Zeitpunkt, _bestellungRow.Gesamtpreis, _bestellungRow.Tisch, _bestellungRow.Storniert, "N");
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.FormBestellung_abschliessenButton_Click_Error_saving_order, Resources.FormBestellung_abschliessenButton_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                    
            bestellungArtikelTableAdapter.Update(festManagerDataSet.BestellungArtikel);

            PrintBestellung();
            
            MessageBox.Show(Resources.FormBestellung_abschliessenButton_Click_Order_placed + _bestellungRow.Gesamtpreis.ToString(CultureInfo.InvariantCulture));
            
            NewRecordset();
        }


        private void PrintBestellung()
        {
            PrintBestellung(false);
        }
        private void PrintBestellung(bool secondPrint)
        {
            Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter ausgabestellen = new Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
            Data.FestManagerDataSet.AusgabestelleDataTable ausgabe = ausgabestellen.GetData();

            printDocument.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            printDocument.PrinterSettings.Copies = 1;

            if (!secondPrint)
            {
                for (int i = 0; i < ausgabe.Rows.Count; i++)
                {
                    Data.FestManagerDataSet.AusgabestelleRow row =
                        (Data.FestManagerDataSet.AusgabestelleRow)ausgabe.Rows[i];

                    PrintKassabon(row);
                }
            }

            if ((_printDirektverkaufTwice && (int)personalIdComboBox.SelectedValue == _direktverkauftPersonalId) || secondPrint)
            {
                _printAll = true;
                ausgabestellen = new Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
                ausgabe = ausgabestellen.GetKassaData();

                if (ausgabe.Count > _direktverkaufAusgabestelleId)
                {
                    printDocument.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
                    printDocument.PrinterSettings.Copies = 1;

                    Data.FestManagerDataSet.AusgabestelleRow row =
                        (Data.FestManagerDataSet.AusgabestelleRow)ausgabe.Rows[_direktverkaufAusgabestelleId];
                    
                    PrintKassabon(row);
                }
                else
                {
                    MessageBox.Show(Resources.FormBestellung_PrintBestellung_Error_no_POS_printer_configured);
                }
            }
        }

        private void PrintKassabon(Data.FestManagerDataSet.AusgabestelleRow row)
        {
            Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter kbTableAdapter = new Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
            Data.FestManagerDataSet.KassenbonDataTable kbTable = new Data.FestManagerDataSet.KassenbonDataTable();

            if (_bestellungRow.BestellungId == 0)
            {
                MessageBox.Show(Resources.FormBestellung_PrintKassabon_Critical_error_restart_application);
            }
            if (_printAll)
            {
                kbTableAdapter.FillByBestellung(kbTable, _bestellungRow.BestellungId);
            }
            else
            {
                _ausgabestelle = row.AusgabestelleId;
                kbTableAdapter.FillByBestellungAndAusgabestelle(kbTable, _bestellungRow.BestellungId, _ausgabestelle);
            }
            
            
            if (kbTable.Rows.Count == 0) {
                //MessageBox.Show(this.ausgabestelle + ": huhu => " + bestellungRow.BestellungId.ToString());
            }
            if (kbTable.Rows.Count > 0)
            {
                var print = true;
                if (!Settings.Default.printStornoOrders)
                {
                    print=false;
                    for (int i = 0; i < kbTable.Rows.Count; i++)
                    {
                        Data.FestManagerDataSet.KassenbonRow kbRow = (Data.FestManagerDataSet.KassenbonRow)kbTable.Rows[i];
                        if (kbRow.Menge >= 0)
                        {
                            print = true;
                            break;
                        }
                    }
                }

                if (print)
                {
                    printDocument.PrinterSettings.PrinterName = row.Drucker;

                    DialogResult result = DialogResult.Retry;
                    while (result == DialogResult.Retry)
                    {
                        try
                        {
                            printDocument.Print();
                            result = DialogResult.OK;
                        }
                        catch (Exception exc)
                        {
                            result = MessageBox.Show(Resources.FormBestellung_PrintKassabon_Printing_error + exc.Message, Resources.FormBestellung_abschliessenButton_Click_Error, MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }


        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter kbTableAdapter = new Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
            Data.FestManagerDataSet.KassenbonDataTable kbTable = new Data.FestManagerDataSet.KassenbonDataTable();

            if (_printAll)
            {
                kbTableAdapter.FillByBestellung(kbTable, _bestellungRow.BestellungId);
            }
            else
            {
                kbTableAdapter.FillByBestellungAndAusgabestelle(kbTable, _bestellungRow.BestellungId, _ausgabestelle);
            }
            if (kbTable.Rows.Count > 0)
            {
                Kassenbon kb = new Kassenbon(e.Graphics, kbTable);
                // Important for Kassa-Prints:
                kb.Draw(_printAll);
            }
            
        }

        private void artikelDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            artikelDataGridView.Rows[e.RowIndex].Cells[0].Value = _bestellungRow.BestellungId;
        }

        private void stornierenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.FormBestellung_stornierenButton_Click_Order_will_be_canceled);

            NewRecordset(true);
        }

        private void artikelDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 1) && artikelDataGridView.Rows[e.RowIndex].Cells[2].Value != null)
            {
                String shortcut = artikelDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                
                int shortcutValue;
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
                    rueckgaengigButton.Visible = true;

                    CalculateGesamtpreis();
                    gesamtpreisTextBox.Text = _bestellungRow.Gesamtpreis.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    artikelDataGridView.Rows[e.RowIndex].Cells[2].Value = DBNull.Value;
                    MessageBox.Show(Resources.FormBestellung_artikelDataGridView_CellValidated_Product_not_found);

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
                if (_tischEnabled)
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
            int bkpBestellungId = _bestellungRow.BestellungId;

            _bestellungRow.BestellungId = (int)bestellungTableAdapter.GetMaxBestellungId();
            PrintBestellung(true);            

            _bestellungRow.BestellungId = bkpBestellungId;
        }

        private void RemoveRow(bool removeCurrentRow)
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
                CalculateGesamtpreis();
                gesamtpreisTextBox.Text = _bestellungRow.Gesamtpreis.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void rueckgaengigButton_Click(object sender, EventArgs e)
        {
            RemoveRow(false);
            artikelDataGridView.Focus();
            artikelDataGridView.MultiSelect = false;
            artikelDataGridView.Rows[artikelDataGridView.Rows.Count-1].Cells[1].Selected = true;
        }

    }
}