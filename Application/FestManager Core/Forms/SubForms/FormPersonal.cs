using System;
using System.Windows.Forms;
using FestManager_Core.Properties;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            try { 
                personalTableAdapter.Fill(festManagerDataSet.Personal);
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
            try
            {
                personalTableAdapter.Update(festManagerDataSet.Personal);
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
                personalTableAdapter.Fill(festManagerDataSet.Personal);
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