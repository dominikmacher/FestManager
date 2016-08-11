using System;
using System.Windows.Forms;
using FestManager_Core.Properties;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormKellnerabrechnungOffen : FestmanagerMdiChildForm
    {
        public FormKellnerabrechnungOffen()
        {
            InitializeComponent();
        }

        private void FormKellnerabrechnungOffen_Load(object sender, EventArgs e)
        {
            try
            { 
                // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.Kellnerabrechnung_Offen". Sie können sie bei Bedarf verschieben oder entfernen.
                kellnerabrechnung_OffenTableAdapter.Fill(festManagerDataSet.Kellnerabrechnung_Offen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message, Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       
        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            try
            {
                kellnerabrechnung_OffenTableAdapter.Fill(festManagerDataSet.Kellnerabrechnung_Offen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message, Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        
    }
}