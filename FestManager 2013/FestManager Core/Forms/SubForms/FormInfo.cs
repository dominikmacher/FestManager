using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

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
            string versionNr = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.labelVersionNr.Text += versionNr.Substring(0, versionNr.LastIndexOf('.'));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}