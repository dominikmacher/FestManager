using System;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormPrinter : FestmanagerMdiChildForm
    {
        public FormPrinter()
        {
            InitializeComponent();
        }

        private void FormPrinter_Load(object sender, EventArgs e)
        {
            foreach(string name in PrinterSettings.InstalledPrinters  ) {
                comboBox1.Items.Add(name);
            }
        }
    }
}