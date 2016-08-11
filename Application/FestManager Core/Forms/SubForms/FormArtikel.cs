using System;
using System.Windows.Forms;
using FestManager_Core.Properties;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormArtikel : FestmanagerMdiChildForm
    {
        public FormArtikel()
        {
            InitializeComponent();
        }

        private void FormArtikel_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'festManagerDataSet.Ausgabestelle' table. You can move, or remove it, as needed.
                ausgabestelleTableAdapter.Fill(festManagerDataSet.Ausgabestelle);
                // TODO: This line of code loads data into the 'festManagerDataSet.Artikel' table. You can move, or remove it, as needed.
                artikelTableAdapter.Fill(festManagerDataSet.Artikel);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            try { 
                artikelTableAdapter.Update(festManagerDataSet.Artikel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void zuruecksetzenButton_Click(object sender, EventArgs e)
        {
            try
            {
                artikelTableAdapter.Fill(festManagerDataSet.Artikel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
}

    }
}