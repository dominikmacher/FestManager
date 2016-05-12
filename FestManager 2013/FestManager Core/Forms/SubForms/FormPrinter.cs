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
    public partial class FormPrinter : Form
    {
        public FormPrinter()
        {
            InitializeComponent();
        }

        private void FormPrinter_Load(object sender, EventArgs e)
        {
            foreach(String name in PrinterSettings.InstalledPrinters  ) {
                comboBox1.Items.Add(name);
            }
        }
    }
}