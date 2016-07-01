using System;
using System.Windows.Forms;

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
            personalTableAdapter.Fill(festManagerDataSet.Personal);
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            personalTableAdapter.Update(festManagerDataSet.Personal);
        }

        private void zuruecksetzenButton_Click(object sender, EventArgs e)
        {
            personalTableAdapter.Fill(festManagerDataSet.Personal);
        }
    }
}