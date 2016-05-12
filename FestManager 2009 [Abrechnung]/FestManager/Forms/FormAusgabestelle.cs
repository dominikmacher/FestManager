using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace FestManager.Forms
{
    public partial class FormAusgabestelle : Form
    {
        public FormAusgabestelle()
        {
            InitializeComponent();
        }

        private void FormAusgabestelle_Load(object sender, EventArgs e)
        {
            this.ausgabestelleTableAdapter.Fill(this.festManagerDataSet.Ausgabestelle);

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