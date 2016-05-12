using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FestManager.Forms
{
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            this.personalTableAdapter.Fill(this.festManagerDataSet.Personal);
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            this.personalTableAdapter.Update(this.festManagerDataSet.Personal);
        }

        private void zuruecksetzenButton_Click(object sender, EventArgs e)
        {
            this.personalTableAdapter.Fill(this.festManagerDataSet.Personal);
        }
    }
}