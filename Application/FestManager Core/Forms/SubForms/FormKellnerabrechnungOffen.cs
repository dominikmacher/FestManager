using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FestManager_Core.Utils.Printing;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormKellnerabrechnungOffen : Form
    {
        public FormKellnerabrechnungOffen()
        {
            InitializeComponent();
        }

        private void FormKellnerabrechnungOffen_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.Kellnerabrechnung_Offen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kellnerabrechnung_OffenTableAdapter.Fill(this.festManagerDataSet.Kellnerabrechnung_Offen);
        }

       
        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            this.kellnerabrechnung_OffenTableAdapter.Fill(this.festManagerDataSet.Kellnerabrechnung_Offen);
        }
        
    }
}