using System;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using FestManager_Core.Data;
using FestManager_Core.Properties;
using FestManager_Core.Utils.Printing;
using NLog;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormBestellung : Form
    {

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public const int ColIdxMenge  = 1;
        public const int ColIdxKuerzel = 2;
        public const int ColIdxArtikel = 3;
        public const int ColIdxPreis = 4;


        private int _ausgabestelle;
        private readonly bool _printDirektverkaufTwice;
        private readonly int _direktverkauftPersonalId;
        private readonly int _direktverkaufAusgabestelleId;
        private readonly bool _printTwice;
        private readonly bool _tischEnabled;
        
        private bool _printAll;

        private FestManagerDataSet.BestellungRow _bestellungRow;
        private decimal _gesamtpreis;

        public FormBestellung()
        {
            Logger.Debug("FormBestellung()");

            InitializeComponent();
            _printTwice = FestManagerSettings.Default.PrintTwice;
            _printDirektverkaufTwice = FestManagerSettings.Default.PrintDirektverkaufTwice;
            _direktverkauftPersonalId = FestManagerSettings.Default.DirektverkaufPersonalId;
            _direktverkaufAusgabestelleId = FestManagerSettings.Default.DirektverkaufAusgabestelleId;
            _tischEnabled = FestManagerSettings.Default.TableNumbers;

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
            Logger.Debug("FormBestellung_Load()");

            // TODO: This line of code loads data into the 'festManagerDataSet.PersonalKuerzel_V' table. You can move, or remove it, as needed.
            try { 
                personal_VTableAdapter.Fill(festManagerDataSet.Personal_V);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            NewBestellung();

        }

        private void NewBestellung(bool storno = false)
        {
            Logger.Debug("NewBestellung()");

            try
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

                bestellungArtikelTableAdapter.FillByBestellungId(festManagerDataSet.BestellungArtikel,
                    _bestellungRow.BestellungId);

                artikelDataGridView.ResetBindings();

                personalIdComboBox.Focus();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
}

        private decimal CalculateGesamtpreis()
        {
            Logger.Debug("CalculateGesamtpreis()");

            decimal gesamtpreis = 0;

            //FestManager_Core.Data.FestManagerDataSet.BestellungArtikelDataTable table = festManagerDataSet.BestellungArtikel;

            foreach (DataGridViewRow row in artikelDataGridView.Rows)
            {
                decimal preis;

                if (row.IsNewRow)
                {
                    Logger.Debug("Skipping new row.");
                    continue;
                }

                if (row.Cells[ColIdxPreis].Value != null &&
                    decimal.TryParse(row.Cells[ColIdxPreis].Value.ToString(), out preis))
                {
                    gesamtpreis += preis;
                }
                else
                {
                    Logger.Debug("Preis on row " + row.Index + " is null or not convertible to a decimal value.");
                }
            }

            return gesamtpreis;
        }

        private void abschliessenButton_Click(object sender, EventArgs e)
        {
            Logger.Debug("abschliessenButton_Click()");

            _bestellungRow.Zeitpunkt = DateTime.Now;
            _bestellungRow.Storniert = "N";
            _bestellungRow.Tisch = tischTextBox.Text;
            _printAll = false;

            // Fix DataTable
            var bestellungArtikel = festManagerDataSet.BestellungArtikel;
            try
            {
                var rows =
                    (from object row in bestellungArtikel.Rows select row as FestManagerDataSet.BestellungArtikelRow)
                        .ToList();
                foreach (var row in rows)
                {
                    if (row.IsArtikelIdNull() || row.IsBestellungIdNull() || row.IsMengeNull())
                    {
                        bestellungArtikel.Rows.Remove(row);
                    }
                }

                if (bestellungArtikel.Rows.Count == 0)
                {
                    ShowError("Leere Bestellungen können nicht abgeschlossen werden!");
                    return;
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(Resources.FormBestellung_abschliessenButton_Click_Error_saving_order + ex.Message, Resources.FormBestellung_abschliessenButton_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _bestellungRow.PersonalId = (int)personalIdComboBox.SelectedValue;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(Resources.FormBestellung_abschliessenButton_Click_Invalid_Waiter_selected, Resources.FormBestellung_abschliessenButton_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _gesamtpreis = CalculateGesamtpreis();
                _bestellungRow.Gesamtpreis = _gesamtpreis;

            }
            catch (FormatException ex)
            {
                Logger.Error(ex);
                MessageBox.Show(Resources.FormBestellung_abschliessenButton_Click_Invalid_articles_selected,
                    Resources.FormBestellung_abschliessenButton_Click_Invalid_articles_selected_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bestellungTableAdapter.Insert(_bestellungRow.PersonalId, _bestellungRow.Zeitpunkt, _bestellungRow.Gesamtpreis, _bestellungRow.Tisch, _bestellungRow.Storniert, "N");
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(Resources.FormBestellung_abschliessenButton_Click_Error_saving_order, Resources.FormBestellung_abschliessenButton_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bestellungArtikelTableAdapter.Update(bestellungArtikel);
            }
            catch (OleDbException ex)
            {
                Logger.Error(ex);

                foreach (var errorObject in ex.Errors)
                {
                    var error = errorObject as OleDbError;
                    if (error != null)
                    {
                        Logger.Info("Message: " + error.Message + ", SQLState: " + error.SQLState + ", Source: " + error.Source);
                    }
                }

                MessageBox.Show(Resources.FormBestellung_abschliessenButton_Click_Error_saving_order, Resources.FormBestellung_abschliessenButton_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(Resources.FormBestellung_abschliessenButton_Click_Error_saving_order, Resources.FormBestellung_abschliessenButton_Click_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                PrintBestellung();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(
                    Resources.FormBestellung_abschliessenButton_Click_Unhandled_printing_error + ex.Message,
                    Resources.FormBestellung_abschliessenButton_Click_Unhandled_printing_error_Title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            MessageBox.Show(
                Resources.FormBestellung_abschliessenButton_Click_Order_placed + $"{_gesamtpreis:C}", 
                Resources.FormBestellung_abschliessenButton_Click_Order_placed_Title, 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            
            NewBestellung();
        }


        private void PrintBestellung(bool secondPrint = false)
        {
            Logger.Debug("PrintBestellung()");

            var ausgabestellen = new Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
            var ausgabe = ausgabestellen.GetData();

            printDocument.PrinterSettings = new PrinterSettings
            {
                Copies = 1
            };

            if (_bestellungRow.BestellungId == 0)
            {
                MessageBox.Show(Resources.FormBestellung_PrintKassabon_Critical_error_restart_application,
                    Resources.Critical_Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (!secondPrint)
            {
                for (var i = 0; i < ausgabe.Rows.Count; i++)
                {
                    var row =
                        (FestManagerDataSet.AusgabestelleRow) ausgabe.Rows[i];

                    PrintKassabon(row);
                }
            }

            if ((_printDirektverkaufTwice && (int)personalIdComboBox.SelectedValue == _direktverkauftPersonalId) || _printTwice || secondPrint)
            {
                _printAll = true;
                ausgabestellen = new Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
                ausgabe = ausgabestellen.GetKassaData();

                if (ausgabe.Count > _direktverkaufAusgabestelleId)
                {
                    printDocument.PrinterSettings = new PrinterSettings {Copies = 1};

                    var row =
                        (FestManagerDataSet.AusgabestelleRow)ausgabe.Rows[_direktverkaufAusgabestelleId];
                    
                    PrintKassabon(row);
                }
                else
                {
                    MessageBox.Show(Resources.FormBestellung_PrintBestellung_Error_no_POS_printer_configured, 
                        Resources.Error, MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }

        private void PrintKassabon(FestManagerDataSet.AusgabestelleRow row)
        {
            Logger.Debug("PrintKassabon()");

            try
            {
                var kbTableAdapter = new Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
                var kbTable = new FestManagerDataSet.KassenbonDataTable();

                if (_bestellungRow.BestellungId == 0)
                {
                    MessageBox.Show(Resources.FormBestellung_PrintKassabon_Critical_error_restart_application,
                        Resources.Critical_Error, 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
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

                if (kbTable.Rows.Count > 0)
                {
                    var print = true;
                    if (!FestManagerSettings.Default.PrintStornoOrders)
                    {
                        print = false;
                        for (var i = 0; i < kbTable.Rows.Count; i++)
                        {
                            var kbRow = (FestManagerDataSet.KassenbonRow) kbTable.Rows[i];
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

                        var result = DialogResult.Retry;
                        while (result == DialogResult.Retry)
                        {
                            try
                            {
                                printDocument.Print();
                                result = DialogResult.OK;
                            }
                            catch (InvalidPrinterException)
                            {
                                result = MessageBox.Show(
                                        Resources.Invalid_Printer,
                                        Resources.Invalid_Printer_Title,
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Error);
                                
                            }
                            catch (Exception ex)
                            {
                                result =
                                    MessageBox.Show(
                                        ex.Message,
                                        Resources.FormBestellung_PrintKassabon_Printing_error,
                                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Logger.Debug("printDocument_PrintPage()");

            var kbTableAdapter = new Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
            var kbTable = new FestManagerDataSet.KassenbonDataTable();

            try { 

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
                    var kb = new Kassenbon(e.Graphics, kbTable);
                    // Important for Kassa-Prints:
                    kb.Draw(_printAll);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void artikelDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Logger.Debug("artikelDataGridView_RowEnter()");

            try
            {
                artikelDataGridView.Rows[e.RowIndex].Cells[0].Value = _bestellungRow.BestellungId;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        private void stornierenButton_Click(object sender, EventArgs e)
        {
            Logger.Debug("stornierenButton_Click()");

            MessageBox.Show(Resources.FormBestellung_stornierenButton_Click_Order_will_be_canceled);

            NewBestellung(true);
        }
        
        private void personalIdComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            Logger.Debug("personalIdComboBox_KeyDown()");

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
            Logger.Debug("tischTextBox_KeyDown()");

            if (e.KeyCode == Keys.Enter)
            {
                artikelDataGridView.Focus();
            }
            else Application.DoEvents();
        }

        private void printLastOrderButton_Click(object sender, EventArgs e)
        {
            Logger.Debug("printLastOrderButton_Click()");

            var bkpBestellungId = _bestellungRow.BestellungId;

            _bestellungRow.BestellungId = (int)bestellungTableAdapter.GetMaxBestellungId();
            PrintBestellung(true);            

            _bestellungRow.BestellungId = bkpBestellungId;
        }

        private void RemoveRow(bool removeCurrentRow)
        {
            Logger.Debug("RemoveRow()");

            try
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

                    _gesamtpreis = CalculateGesamtpreis();
                    _bestellungRow.Gesamtpreis = _gesamtpreis;
                    UpdateGesamtpreisLabel(_gesamtpreis);
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
        }

        private void rueckgaengigButton_Click(object sender, EventArgs e)
        {
            Logger.Debug("rueckgaengigButton_Click()");

            RemoveRow(false);
            artikelDataGridView.Focus();
            artikelDataGridView.MultiSelect = false;
            artikelDataGridView.Rows[artikelDataGridView.Rows.Count-1].Cells[1].Selected = true;
        }

        private void artikelDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Logger.Debug("artikelDataGridView_CellEndEdit()");

            /*
            int shortcutValue;
            int? artikelId = null;
            decimal? preis = 0;

            var shortcut = artikelDataGridView.Rows[e.RowIndex].Cells[ColIdxKuerzel].Value.ToString();

            try
            {
                shortcutValue = int.Parse(shortcut);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Invalid_shortcut);
                artikelDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                return;
            }


            if (shortcutValue > 0)
            {
                artikelId = artikelTableAdapter.GetGueltigArtikelIdByShortCut(shortcutValue);
                preis = artikelTableAdapter.GetEinzelpreisByShortCut(shortcutValue);
            }

            if (artikelId != null)
            {
                artikelDataGridView.Rows[e.RowIndex].Cells[ColIdxArtikel].Value = artikelId;

                artikelDataGridView.Rows[e.RowIndex].Cells[ColIdxPreis].Value = preis * int.Parse(artikelDataGridView.Rows[e.RowIndex].Cells[ColIdxMenge].Value.ToString());
                rueckgaengigButton.Visible = true;

                CalculateGesamtpreis();
                gesamtpreisTextBox.Text = _bestellungRow.Gesamtpreis.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                //artikelDataGridView.Rows[e.RowIndex].Cells[ColIdxKuerzel].Value = DBNull.Value;
                MessageBox.Show(Resources.FormBestellung_artikelDataGridView_CellValidated_Product_not_found, Resources.FormBestellung_artikelDataGridView_CellValidated_Product_not_found_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
                artikelDataGridView.Rows[e.RowIndex].Cells[ColIdxMenge].Value = DBNull.Value;
                artikelDataGridView.Rows[e.RowIndex].Cells[ColIdxArtikel].Value = DBNull.Value;
                artikelDataGridView.Rows[e.RowIndex].Cells[ColIdxPreis].Value = DBNull.Value;

                bestellungArtikelBindingSource.CancelEdit();
                artikelDataGridView.RefreshEdit();

                SendKeys.Send("{LEFT}");
                SendKeys.Send("{LEFT}");
                SendKeys.Send("{LEFT}");
                
            }
            */
        }

        private void artikelDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Logger.Debug("artikelDataGridView_DataError()");
            Logger.Error(e.Exception, "DataError occured.");

            // Überprüfung an CellValidating event delegieren
            e.Cancel = true;
        }

        private void artikelDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Logger.Debug("artikelDataGridView_CellValidating()");

            try
            {
                // Cancel cell validation 
                if (e.ColumnIndex != ColIdxKuerzel && e.ColumnIndex != ColIdxMenge)
                {
                    return;
                }

                var value = e.FormattedValue;

                // Menge validieren und automatisch setzen falls notwendig
                if (e.ColumnIndex == ColIdxMenge)
                {
                    var menge = GetOrFixMenge(e.RowIndex, e.FormattedValue);
                    if (menge == null)
                    {
                        // Menge ist kein Integer
                        ShowError("Menge ist keine Zahl!");
                        e.Cancel = true;
                    }
                }
                // Artikel-Eingabe überprüfen
                else if (e.ColumnIndex == ColIdxKuerzel)
                {
                    int shortcut;
                    if (string.IsNullOrEmpty(value?.ToString()))
                    {
                        // Leere Ausdrücke dürfen vorkommen, Validierung muss dann auf Zeilenebene erfolgen
                    }
                    else if (!int.TryParse(value.ToString(), out shortcut))
                    {
                        // Shortcut ist kein Integer
                        ShowError("Kürzel ist keine Zahl!");
                        e.Cancel = true;
                    }
                    else
                    {
                        // Shortcut ist ein Integer
                        var artikelId = artikelTableAdapter.GetGueltigArtikelIdByShortCut(shortcut);
                        if (artikelId == null)
                        {
                            ShowError("Artikel ungültig");
                            e.Cancel = true;
                        }
                    }

                    if (!e.Cancel)
                    {
                        rueckgaengigButton.Visible = true;
                    }
                }

                if (!e.Cancel)
                {
                    HideError();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.FormBestellung_artikelDataGridView_CellValidating_Error_Pfx + ex.Message, Resources.Unknown_Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private int? GetOrFixMenge(int row, object formatedCellValue = null)
        {
            Logger.Debug("GetOrFixMenge()");

            object value;
            int? menge;

            if (formatedCellValue != null)
            {
                value = formatedCellValue;
            }
            else if (!TryGetCellValue(row, ColIdxMenge, out value))
            {
                return null;
            }

            int tmpMenge;
            // Autofix Menge (set to 1 if null)
            if (string.IsNullOrEmpty(value?.ToString()))
            {
                menge = 1;
                SetCellValue(row, ColIdxMenge, menge);
            }
            else if (!int.TryParse(value.ToString(), out tmpMenge))
            {
                return null;
            }
            else
            {
                menge = tmpMenge;
            }

            return menge;
        }

        private void artikelDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            Logger.Debug("artikelDataGridView_CellValidated()");
        }

        private void UpdateRow(int row, int menge, int artikel, decimal preis)
        {
            Logger.Debug("UpdateRow()");

            artikelDataGridView.Rows[row].Cells[ColIdxArtikel].Value = artikel;
            artikelDataGridView.Rows[row].Cells[ColIdxPreis].Value = preis * menge;
        }

        private bool TryGetCellValue(int rowIndex, int colIndex, out object value)
        {

            Logger.Debug("TryGetCellValue()");

            try
            {
                value = artikelDataGridView.Rows[rowIndex].Cells[colIndex].Value;
            }
            catch
            {
                value = null;
                return false;
            }

            return true;
        }

        private void SetCellValue(int rowIndex, int colIndex, object value)
        {
            Logger.Debug("SetCellValue()");

            artikelDataGridView.Rows[rowIndex].Cells[colIndex].Value = value;
        }

        private void ShowError(string error)
        {
            Logger.Debug("ShowError()");

            labelError.Visible = true;
            labelError.Text = error;
            labelError.BackColor = Color.Red;
            labelError.ForeColor = Color.White;
        }

        private void HideError()
        {
            Logger.Debug("HideError()");

            UpdateGesamtpreisLabel(_gesamtpreis);
        }

        private void artikelDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            Logger.Debug("artikelDataGridView_RowValidating()");

            try
            {
                var row = artikelDataGridView.Rows.SharedRow(e.RowIndex);

                if (row.IsNewRow) return;

                object value;
                if (!TryGetCellValue(e.RowIndex, ColIdxMenge, out value) || value == null)
                {
                    e.Cancel = true;
                    ShowError("Sie haben keine Menge erfasst!");
                }

                if (!TryGetCellValue(e.RowIndex, ColIdxKuerzel, out value) || value == null)
                {
                    e.Cancel = true;
                    ShowError("Sie haben keinen Artikel erfasst!");


                }

                if (!e.Cancel)
                {
                    HideError();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.FormBestellung_artikelDataGridView_CellValidating_Error_Pfx + ex.Message, Resources.Unknown_Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void artikelDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Logger.Trace("artikelDataGridView_CellFormatting()");

            if (artikelDataGridView.CurrentCell != null)
            {
                if (e.RowIndex == artikelDataGridView.CurrentCell.RowIndex &&
                    e.ColumnIndex == artikelDataGridView.CurrentCell.ColumnIndex)
                {
                    e.CellStyle.SelectionBackColor = Color.Green;
                    e.CellStyle.SelectionForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.SelectionBackColor = artikelDataGridView.DefaultCellStyle.SelectionBackColor;
                    e.CellStyle.SelectionForeColor = artikelDataGridView.DefaultCellStyle.SelectionForeColor;
                }
            }
        }

        private void artikelDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            Logger.Debug("artikelDataGridView_RowValidated()");

            try
            {

                object value;
                int shortcut;

                if (!TryGetCellValue(e.RowIndex, ColIdxKuerzel, out value) || value == null ||
                    !int.TryParse(value.ToString(), out shortcut))
                {
                    // Shortcut ist leer. Neuberechnung für Zeile abbrechen
                    return;
                }


                var artikelId = artikelTableAdapter.GetGueltigArtikelIdByShortCut(shortcut);
                var preis = artikelTableAdapter.GetEinzelpreisByShortCut(shortcut);
                var menge = GetOrFixMenge(e.RowIndex);

                if (menge == null || artikelId == null || preis == null)
                {
                    // This should not happen
                    Logger.Error("Menge, Artike or Preis is have no value.");
                    return;
                }

                UpdateRow(e.RowIndex, menge.Value, artikelId.Value, preis.Value);

                _gesamtpreis = CalculateGesamtpreis();

                UpdateGesamtpreisLabel(_gesamtpreis);

            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }

        }

        private void UpdateGesamtpreisLabel(decimal gesamtPreis)
        {
            Logger.Debug("UpdateGesamtpreisLabel()");

            labelError.Visible = true;
            labelError.Text = $"{gesamtPreis:C}";
            labelError.BackColor = Color.LightGreen;
            labelError.ForeColor = Color.Black;
        }

        private void artikelDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Logger.Debug("artikelDataGridView_RowsRemoved()");

            _gesamtpreis = CalculateGesamtpreis();
            UpdateGesamtpreisLabel(_gesamtpreis);
        }
    }
}