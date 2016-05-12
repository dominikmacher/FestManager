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
    public partial class FormBestellungenHistory : Form
    {
        private int actualBestellungId = 0;

        public FormBestellungenHistory()
        {
            InitializeComponent();
        }

        private void FormBestellungenHistory_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.BestellungenHistoryDetails_V". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.bestellungenHistoryDetails_VTableAdapter.Fill(this.festManagerDataSet.BestellungenHistoryDetails_V);
            // TODO: This line of code loads data into the 'festManagerDataSet.Artikel' table. You can move, or remove it, as needed.
            this.bestellungenHistory_VTableAdapter.Fill(this.festManagerDataSet.BestellungenHistory_V);

        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            //this.bestellungenHistory_VTableAdapter.Update(this.festManagerDataSet.BestellungenHistory_V);
        }

        private void zuruecksetzenButton_Click(object sender, EventArgs e)
        {
            this.bestellungenHistory_VTableAdapter.Fill(this.festManagerDataSet.BestellungenHistory_V);
        }

        private void bestellungenHistoryDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bestellungenHistoryDetailsDataGridView.Visible = true;
            buttonCancelBestellung.Visible = true;
            buttonPrintBestellung.Visible = true;
            this.actualBestellungId = (int)this.festManagerDataSet.BestellungenHistory_V.Rows[e.RowIndex]["BestellungId"];
            lblBestellDetails.Text = "Bestell-Details für #" + actualBestellungId.ToString() + ":";

            //this.bestellungenHistoryDetails_VTableAdapter.Fill(this.festManagerDataSet.BestellungenHistoryDetails_V);
            //this.festManagerDataSet.BestellungenHistoryDetails_V = ;
            DataTable t = this.bestellungenHistoryDetails_VTableAdapter.GetDataByBestellungId(actualBestellungId);
            this.bestellungenHistoryDetailsDataGridView.DataSource = t;
        }

        private void buttonPrintBestellung_Click(object sender, EventArgs e)
        {
            if (this.actualBestellungId > 0)
            {
                FestManager.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter ausgabestellen = new FestManager.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
                FestManager.Data.FestManagerDataSet.AusgabestelleDataTable ausgabe = (FestManager.Data.FestManagerDataSet.AusgabestelleDataTable)ausgabestellen.GetKassaData();

                if (ausgabe.Count > 0)
                {
                    printDocument.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
                    printDocument.PrinterSettings.Copies = 1;
                    
                    FestManager.Data.FestManagerDataSet.AusgabestelleRow row =
                        (FestManager.Data.FestManagerDataSet.AusgabestelleRow)ausgabe.Rows[0];

                    //int ausgabestelle = (int)row.AusgabestelleId;

                    FestManager.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter kbTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
                    FestManager.Data.FestManagerDataSet.KassenbonDataTable kbTable = new FestManager.Data.FestManagerDataSet.KassenbonDataTable();
                    kbTableAdapter.FillByBestellung(kbTable, this.actualBestellungId);
                    
                    if (kbTable.Rows.Count > 0)
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
                else
                {
                    MessageBox.Show("Fehler: Kein 'Kassa'-Drucker eingerichtet !!");
                }
            }
        }



        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FestManager.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter kbTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.KassenbonTableAdapter();
            FestManager.Data.FestManagerDataSet.KassenbonDataTable kbTable = new FestManager.Data.FestManagerDataSet.KassenbonDataTable();

            kbTableAdapter.FillByBestellung(kbTable, this.actualBestellungId);
            if (kbTable.Rows.Count > 0)
            {
                DateTime date = DateTime.Now;
                Kassenbon kb = new Kassenbon(e.Graphics, kbTable, "FF-Karlstetten - Fest " + date.ToString("yyyy"));
                // Important for Kassa-Prints:
                kb.isCopy = true;
                kb.Draw();
            }

        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            this.bestellungenHistory_VTableAdapter.Fill(this.festManagerDataSet.BestellungenHistory_V);
        }
        
    }
}