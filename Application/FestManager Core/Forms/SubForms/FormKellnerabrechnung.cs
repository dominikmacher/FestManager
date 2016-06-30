using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FestManager_Core.Utils.Printing;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormKellnerabrechnung : Form
    {
        private int artikelBestellungId = 0;
        private int personalId = 0;

        public FormKellnerabrechnung()
        {
            InitializeComponent();
        }

        private void FormKellnerabrechnung_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.KellnerabrechnungNachTagenAbgeschlossen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kellnerabrechnungNachTagenAbgeschlossenTableAdapter.Fill(this.festManagerDataSet.KellnerabrechnungNachTagenAbgeschlossen);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.KellnerabrechnungNachTagenOffen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kellnerabrechnungNachTagenOffenTableAdapter.Fill(this.festManagerDataSet.KellnerabrechnungNachTagenOffen);
            this.personal_VTableAdapter.Fill(this.festManagerDataSet.Personal_V);
            this.personalId = (int)personalComboBox.SelectedValue;
            fillGridView();
        }

        private void personalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.personalId = (int)personalComboBox.SelectedValue;
            fillGridView();
        }

        private void fillGridView()
        {
            decimal bestellungen = 0, kellnergroschen = 0;

            DataTable dt = this.kellnerabrechnungNachTagenOffenTableAdapter.GetDataByPersonalId(personalId);
            this.offeneAbrechnungenDataGridView.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bestellungen += (decimal)dt.Rows[i]["SummevonSumme"];
                kellnergroschen += (decimal)dt.Rows[i]["SummevonKellnergroschen"];
            }
            this.gesamtSummeBestellungenTextbox.Text = bestellungen.ToString();
            this.gesamtSummeKellnergroschenTextbox.Text = kellnergroschen.ToString();

            bestellungen = 0; kellnergroschen = 0;
            dt = this.kellnerabrechnungNachTagenAbgeschlossenTableAdapter.GetDataByPersonalId(personalId);
            this.abgeschlosseneAbrechnungenDataGridView.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bestellungen += (decimal)dt.Rows[i]["SummevonSumme"];
                kellnergroschen += (decimal)dt.Rows[i]["SummevonKellnergroschen"];
            }
            this.gesamtSummeClosedBestellungenTextbox.Text = bestellungen.ToString();
            this.gesamtSummeClosedKellnergroschenTextbox.Text = kellnergroschen.ToString();
            
        }

        private void buttonCloseOrders_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Alle offenen Abrechnungen werden als 'abgerechnet' markiert. Fortfahren?", "Abrechnungen dauerhaft abschließen", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                /**
                 * 1) Update DB
                 * 2) ReFill gridViews
                 */
                FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungTableAdapter bestellung = new Data.FestManagerDataSetTableAdapters.BestellungTableAdapter();
                bestellung.CloseBestellungenByPersonalId(personalId);
                fillGridView();
            }
            
        }

    }
}