using System;
using System.Windows.Forms;

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
            // TODO: Diese Codezeile l�dt Daten in die Tabelle "festManagerDataSet.Kellnerabrechnung_Offen". Sie k�nnen sie bei Bedarf verschieben oder entfernen.
            kellnerabrechnung_OffenTableAdapter.Fill(festManagerDataSet.Kellnerabrechnung_Offen);
        }

       
        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            kellnerabrechnung_OffenTableAdapter.Fill(festManagerDataSet.Kellnerabrechnung_Offen);
        }
        
    }
}