using System;
using System.Windows.Forms;

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
            ausgabestelleTableAdapter.Fill(festManagerDataSet.Ausgabestelle);
            // TODO: This line of code loads data into the 'festManagerDataSet.Artikel' table. You can move, or remove it, as needed.
            artikelTableAdapter.Fill(festManagerDataSet.Artikel);

        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            artikelTableAdapter.Update(festManagerDataSet.Artikel);
        }

        private void zuruecksetzenButton_Click(object sender, EventArgs e)
        {
            artikelTableAdapter.Fill(festManagerDataSet.Artikel);
        }

    }
}