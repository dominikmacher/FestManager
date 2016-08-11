using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using FestManager_Core.Properties;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormKellnerabrechnung : FestmanagerMdiChildForm
    {
        private int _personalId;

        public FormKellnerabrechnung()
        {
            InitializeComponent();
        }

        private void FormKellnerabrechnung_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.KellnerabrechnungNachTagenAbgeschlossen". Sie können sie bei Bedarf verschieben oder entfernen.
                kellnerabrechnungNachTagenAbgeschlossenTableAdapter.Fill(
                    festManagerDataSet.KellnerabrechnungNachTagenAbgeschlossen);
                // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.KellnerabrechnungNachTagenOffen". Sie können sie bei Bedarf verschieben oder entfernen.
                kellnerabrechnungNachTagenOffenTableAdapter.Fill(festManagerDataSet.KellnerabrechnungNachTagenOffen);
                personal_VTableAdapter.Fill(festManagerDataSet.Personal_V);
                _personalId = (int) personalComboBox.SelectedValue;
                FillGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message, Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void personalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (personalComboBox.SelectedValue == null) return;

            _personalId = (int) personalComboBox.SelectedValue;
            FillGridView();
        }

        private void FillGridView()
        {
            decimal bestellungen = 0, kellnergroschen = 0;

            DataTable dt = kellnerabrechnungNachTagenOffenTableAdapter.GetDataByPersonalId(_personalId);
            offeneAbrechnungenDataGridView.DataSource = dt;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                bestellungen += (decimal)dt.Rows[i]["SummevonSumme"];
                kellnergroschen += (decimal)dt.Rows[i]["SummevonKellnergroschen"];
            }
            gesamtSummeBestellungenTextbox.Text = bestellungen.ToString(CultureInfo.InvariantCulture);
            gesamtSummeKellnergroschenTextbox.Text = kellnergroschen.ToString(CultureInfo.InvariantCulture);

            bestellungen = 0; kellnergroschen = 0;
            dt = kellnerabrechnungNachTagenAbgeschlossenTableAdapter.GetDataByPersonalId(_personalId);
            abgeschlosseneAbrechnungenDataGridView.DataSource = dt;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                bestellungen += (decimal)dt.Rows[i]["SummevonSumme"];
                kellnergroschen += (decimal)dt.Rows[i]["SummevonKellnergroschen"];
            }
            gesamtSummeClosedBestellungenTextbox.Text = bestellungen.ToString(CultureInfo.InvariantCulture);
            gesamtSummeClosedKellnergroschenTextbox.Text = kellnergroschen.ToString(CultureInfo.InvariantCulture);
            
        }

        private void buttonCloseOrders_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(Resources.FormKellnerabrechnung_buttonCloseOrders_Click_Continue_on_mark_all_open_orders_finalized, Resources.FormKellnerabrechnung_buttonCloseOrders_Click_Finalize_orders, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                /**
                 * 1) Update DB
                 * 2) ReFill gridViews
                 */
                var bestellung = new Data.FestManagerDataSetTableAdapters.BestellungTableAdapter();
                bestellung.CloseBestellungenByPersonalId(_personalId);
                FillGridView();
            }
            
        }

    }
}