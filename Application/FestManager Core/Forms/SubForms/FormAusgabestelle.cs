using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormAusgabestelle : Form
    {
        public FormAusgabestelle()
        {
            InitializeComponent();
        }

        private void FormAusgabestelle_Load(object sender, EventArgs e)
        {
            Data.FestManagerDataSet.AusgabestelleDataTable dt = new Data.FestManagerDataSet.AusgabestelleDataTable();
            this.ausgabestelleTableAdapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string installedPrinter = "";
                foreach (String printerName in PrinterSettings.InstalledPrinters)
                {
                    if (String.IsNullOrEmpty(installedPrinter))
                    {
                        installedPrinter = printerName;
                    }
                    if (String.Compare(dt.Rows[i]["Drucker"].ToString(), printerName, true) == 0)
                    {
                        installedPrinter = printerName;
                    }
                }

                dt.Rows[i]["Drucker"] = installedPrinter;
                this.festManagerDataSet.Ausgabestelle.ImportRow((Data.FestManagerDataSet.AusgabestelleRow)dt.Rows[i]);

                //MessageBox.Show();
            }

            //this.ausgabestelleTableAdapter.Update(

            foreach (String printerName in PrinterSettings.InstalledPrinters)
            {
                this.festManagerDataSet.Printer.AddPrinterRow(printerName);
            }

            // TODO: This line of code loads data into the 'festManagerDataSet.Ausgabestelle' table. You can move, or remove it, as needed.
            //this.ausgabestelleTableAdapter.Fill(this.festManagerDataSet.Ausgabestelle);            
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            this.ausgabestelleTableAdapter.Update(this.festManagerDataSet.Ausgabestelle);
        }

        private void zuruecksetzenButton_Click(object sender, EventArgs e)
        {
            this.ausgabestelleTableAdapter.Fill(this.festManagerDataSet.Ausgabestelle);
        }
    }
}