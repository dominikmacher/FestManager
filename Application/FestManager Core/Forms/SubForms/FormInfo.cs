using System;
using System.Windows.Forms;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent(); 
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            var versionNr = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            labelVersionNr.Text += versionNr.Substring(0, versionNr.LastIndexOf('.'));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}