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
    public partial class FormArtikel : Form
    {
        public FormArtikel()
        {
            InitializeComponent();
        }

        private void FormArtikel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'festManagerDataSet.Ausgabestelle' table. You can move, or remove it, as needed.
            this.ausgabestelleTableAdapter.Fill(this.festManagerDataSet.Ausgabestelle);
            // TODO: This line of code loads data into the 'festManagerDataSet.Artikel' table. You can move, or remove it, as needed.
            this.artikelTableAdapter.Fill(this.festManagerDataSet.Artikel);

        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            this.artikelTableAdapter.Update(this.festManagerDataSet.Artikel);
        }

        private void zuruecksetzenButton_Click(object sender, EventArgs e)
        {
            this.artikelTableAdapter.Fill(this.festManagerDataSet.Artikel);
        }

    }
}