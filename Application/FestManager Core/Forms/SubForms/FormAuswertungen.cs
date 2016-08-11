using System;
using System.Data;
using System.Windows.Forms;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormAuswertungen : FestmanagerMdiChildForm
    {
        private readonly string _auswertung;
        private int _personalNr;

        public FormAuswertungen(string auswertung)
        {
            _auswertung = auswertung;
            InitializeComponent();
            selPersonal.Visible = false;
            InitializePersonalComboBox();
            _personalNr = -1;
        }

        private void InitializePersonalComboBox()
        {
            var adpt = new Data.FestManagerDataSetTableAdapters.PersonalTableAdapter();
            var dt = (DataTable)adpt.GetData();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                selPersonal.Items.Add(dt.Rows[i][1] + " - " + dt.Rows[i][2].ToString().ToUpper() + " " + dt.Rows[i][3]);
            }
            selPersonal.SelectedIndexChanged += selPersonal_SelectedIndexChanged;
        }

        private void FormAuswertungen_Load(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void ShowReport()
        {
            switch (_auswertung)
            {
                case "Kellnerabrechnung":
                    selPersonal.Visible = true;
                    var reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource
                    {
                        Name = "FestManagerDataSet_Artikel",
                        Value = ArtikelBindingSource
                    };

                    var reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource
                    {
                        Name = "FestManagerDataSet_Bestellung",
                        Value = BestellungBindingSource
                    };
                    var reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource
                    {
                        Name = "FestManagerDataSet_PersonalBestellung_V",
                        Value = PersonalBestellung_VBindingSource
                    };
                    var reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource
                    {
                        Name = "FestManagerDataSet_BestellungArtikel",
                        Value = BestellungArtikelBindingSource
                    };
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "FestManager.Reporting.Kellnerabrechnung.rdlc";
                    PersonalBestellung_VTableAdapter.FillByPersonalNr(FestManagerDataSet.PersonalBestellung_V, _personalNr);
                    break;
            }
            reportViewer1.RefreshReport();
        }

        private void selPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            _personalNr = int.Parse((selPersonal.Items[selPersonal.SelectedIndex].ToString())[0].ToString());
            ShowReport();
        }
    }
}