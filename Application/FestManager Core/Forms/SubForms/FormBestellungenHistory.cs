using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using FestManager_Core.Properties;
using FestManager_Core.Utils.Printing;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormBestellungenHistory : Form
    {
        private int _actualBestellungId;

        public FormBestellungenHistory()
        {
            InitializeComponent();
            //this.buttonCancelBestellung.Enabled = false;
        }

        private void FormBestellungenHistory_Load(object sender, EventArgs e)
        {
            try { 
                // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.BestellungenHistoryDetails_V". Sie können sie bei Bedarf verschieben oder entfernen.
                //this.bestellungenHistoryDetails_VTableAdapter.Fill(this.festManagerDataSet.BestellungenHistoryDetails_V);
                // TODO: This line of code loads data into the 'festManagerDataSet.Artikel' table. You can move, or remove it, as needed.
                bestellungenHistory_VTableAdapter.Fill(festManagerDataSet.BestellungenHistory_V);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void bestellungenHistoryDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bestellungenHistoryDetailsDataGridView.Visible = true;
            buttonCancelBestellung.Visible = true;
            buttonPrintBestellung.Visible = true;
            _actualBestellungId = (int)festManagerDataSet.BestellungenHistory_V.Rows[e.RowIndex]["BestellungId"];
            lblBestellDetails.Text = Resources.FormBestellungenHistory_bestellungenHistoryDataGridView_CellDoubleClick_Order_details_for + _actualBestellungId.ToString() + @":";

            try
            {

                //this.bestellungenHistoryDetails_VTableAdapter.Fill(this.festManagerDataSet.BestellungenHistoryDetails_V);
                //this.festManagerDataSet.BestellungenHistoryDetails_V = ;
                DataTable t = bestellungenHistoryDetails_VTableAdapter.GetDataByBestellungId(_actualBestellungId);
                bestellungenHistoryDetailsDataGridView.DataSource = t;

            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
}

        private void buttonPrintBestellung_Click(object sender, EventArgs e)
        {
            try
            {
                if (_actualBestellungId > 0)
                {
                    var ausgabestellen = new Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
                    var ausgabe = ausgabestellen.GetKassaData();

                    if (ausgabe.Count > 0)
                    {
                        printDocument.PrinterSettings = new System.Drawing.Printing.PrinterSettings {Copies = 1};

                        var row =
                            (Data.FestManagerDataSet.AusgabestelleRow) ausgabe.Rows[0];

                        //int ausgabestelle = (int)row.AusgabestelleId;

                        var kbTableAdapter = new Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
                        var kbTable = new Data.FestManagerDataSet.KassenbonDataTable();
                        kbTableAdapter.FillByBestellung(kbTable, _actualBestellungId);

                        if (kbTable.Rows.Count > 0)
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
                                catch (InvalidAsynchronousStateException exc)
                                {
                                    result =
                                        MessageBox.Show(
                                            Resources.FormBestellungenHistory_buttonPrintBestellung_Click_Printing_error +
                                            exc.Message, Resources.Error, MessageBoxButtons.RetryCancel,
                                            MessageBoxIcon.Warning);
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show(
                            Resources.FormBestellungenHistory_buttonPrintBestellung_Click_Error_no_POS_printer);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var kbTableAdapter = new Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
            var kbTable = new Data.FestManagerDataSet.KassenbonDataTable();

            kbTableAdapter.FillByBestellung(kbTable, _actualBestellungId);
            if (kbTable.Rows.Count > 0)
            {
                var kb = new Kassenbon(e.Graphics, kbTable);
                // Important for Kassa-Prints:
                kb.Draw(true);
            }

        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            bestellungenHistory_VTableAdapter.Fill(festManagerDataSet.BestellungenHistory_V);
        }
        
    }
}