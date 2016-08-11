using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FestManager.Forms
{
    public partial class FormEinheit : Form
    {
        public FormEinheit()
        {
            InitializeComponent();
        }

        private void FormEinheit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'festManagerDataSet.Einheit' table. You can move, or remove it, as needed.
            this.einheitTableAdapter.Fill(this.festManagerDataSet.Einheit);

        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            this.einheitTableAdapter.Update(this.festManagerDataSet.Einheit);
        }

        private void zuruecksetzenButton_Click(object sender, EventArgs e)
        {
            this.einheitTableAdapter.Fill(this.festManagerDataSet.Einheit);
        }
    }
}