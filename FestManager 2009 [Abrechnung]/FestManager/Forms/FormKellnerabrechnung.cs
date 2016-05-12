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
    public partial class FormKellnerabrechnung : Form
    {
        private int artikelBestellungId = 0;
        private int personalId = 0;

        public FormKellnerabrechnung()
        {
            InitializeComponent();
        }

        private void FormManualStorno_Load(object sender, EventArgs e)
        {
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
            DataTable t = this.kellnerabrechnungNachTagenTableAdapter.GetDataByPersonalId(personalId);
            this.personalArtikelDataGridView.DataSource = t;
        }

        

    }
}