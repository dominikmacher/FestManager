using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormAuswertungen : Form
    {
        private string auswertung;
        private int personalNr = -1;

        public FormAuswertungen(string auswertung)
        {
            this.auswertung = auswertung;
            InitializeComponent();
            this.selPersonal.Visible = false;
            InitializePersonalComboBox();
            this.personalNr = -1;
        }

        private void InitializePersonalComboBox()
        {
            FestManager_Core.Data.FestManagerDataSetTableAdapters.PersonalTableAdapter adpt = new FestManager_Core.Data.FestManagerDataSetTableAdapters.PersonalTableAdapter();
            DataTable dt = (DataTable)adpt.GetData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.selPersonal.Items.Add(dt.Rows[i][1].ToString() + " - " + dt.Rows[i][2].ToString().ToUpper() + " " + dt.Rows[i][3].ToString());
            }
            this.selPersonal.SelectedIndexChanged += new System.EventHandler(selPersonal_SelectedIndexChanged);
        }

        private void FormAuswertungen_Load(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void ShowReport()
        {
            switch (auswertung)
            {
                case "Kellnerabrechnung":
                    this.selPersonal.Visible = true;
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    reportDataSource1.Name = "FestManagerDataSet_Artikel";
                    reportDataSource1.Value = this.ArtikelBindingSource;
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    reportDataSource4.Name = "FestManagerDataSet_Bestellung";
                    reportDataSource4.Value = this.BestellungBindingSource;
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    reportDataSource2.Name = "FestManagerDataSet_PersonalBestellung_V";
                    reportDataSource2.Value = this.PersonalBestellung_VBindingSource;
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    reportDataSource3.Name = "FestManagerDataSet_BestellungArtikel";
                    reportDataSource3.Value = this.BestellungArtikelBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "FestManager.Reporting.Kellnerabrechnung.rdlc";
                    this.PersonalBestellung_VTableAdapter.FillByPersonalNr(this.FestManagerDataSet.PersonalBestellung_V, personalNr);
                    break;
                case "Verkaufssummen":
                default:
                    break;
            }
            this.reportViewer1.RefreshReport();
        }

        private void selPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.personalNr = int.Parse((this.selPersonal.Items[this.selPersonal.SelectedIndex].ToString())[0].ToString());
            ShowReport();
        }
    }
}