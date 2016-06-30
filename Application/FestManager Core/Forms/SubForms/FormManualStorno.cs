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
    public partial class FormManualStorno : Form
    {
        private int artikelBestellungId = 0;
        private int personalId = 0;

        public FormManualStorno()
        {
            InitializeComponent();
        }

        private void FormManualStorno_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.Personal_V". Sie können sie bei Bedarf verschieben oder entfernen.
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
            // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.PersonalArtikel". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.personalArtikelTableAdapter.Fill(this.festManagerDataSet.PersonalArtikel);

            DataTable t = this.personalArtikelTableAdapter.GetDataByPersonalId(personalId);
            this.personalArtikelDataGridView.DataSource = t; 
        }

        private void personalArtikelDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.artikelBestellungId = (int)this.personalArtikelDataGridView.Rows[e.RowIndex].Cells[0].Value;
            btnStornoArtikelBestellung.Visible = true;

            string detailsText = "[" + this.personalArtikelDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() + "]";
            detailsText += "  -  " + this.personalArtikelDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString() + "x ";
            detailsText += this.personalArtikelDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            detailsText += "   (um € " + this.personalArtikelDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() +")";
            labelArtikelBestellungDetails.Text = detailsText;
        }

        private void btnStornoArtikelBestellung_Click(object sender, EventArgs e)
        {
            FormDialog sicherheitsabfrage = new FormDialog();
            if (sicherheitsabfrage.ShowDialog(this) == DialogResult.OK)
            {
                // OK
                personalArtikelTableAdapter.DeleteByBestellungArtikelId(artikelBestellungId);
            }
            else
            {
                // Cancel
            }
            sicherheitsabfrage.Dispose();

            fillGridView();
            btnStornoArtikelBestellung.Visible = false;
            labelArtikelBestellungDetails.Text = "";
        }

    }
}