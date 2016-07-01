using System;
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
            var dt = new Data.FestManagerDataSet.AusgabestelleDataTable();
            ausgabestelleTableAdapter.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var installedPrinter = "";
                foreach (string printerName in PrinterSettings.InstalledPrinters)
                {
                    if (string.IsNullOrEmpty(installedPrinter))
                    {
                        installedPrinter = printerName;
                    }
                    if (string.Compare(dt.Rows[i]["Drucker"].ToString(), printerName, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        installedPrinter = printerName;
                    }
                }

                dt.Rows[i]["Drucker"] = installedPrinter;
                festManagerDataSet.Ausgabestelle.ImportRow((Data.FestManagerDataSet.AusgabestelleRow)dt.Rows[i]);

                //MessageBox.Show();
            }

            //this.ausgabestelleTableAdapter.Update(

            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                festManagerDataSet.Printer.AddPrinterRow(printerName);
            }

            // TODO: This line of code loads data into the 'festManagerDataSet.Ausgabestelle' table. You can move, or remove it, as needed.
            //this.ausgabestelleTableAdapter.Fill(this.festManagerDataSet.Ausgabestelle);            
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            ausgabestelleTableAdapter.Update(festManagerDataSet.Ausgabestelle);
        }

        private void zuruecksetzenButton_Click(object sender, EventArgs e)
        {
            ausgabestelleTableAdapter.Fill(festManagerDataSet.Ausgabestelle);
        }
    }
}