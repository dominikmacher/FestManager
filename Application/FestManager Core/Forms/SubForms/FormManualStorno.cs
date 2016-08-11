using System;
using System.Data;
using System.Windows.Forms;
using FestManager_Core.Properties;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormManualStorno : FestmanagerMdiChildForm
    {
        private int _artikelBestellungId;
        private int _personalId;

        public FormManualStorno()
        {
            InitializeComponent();
        }

        private void FormManualStorno_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.Personal_V". Sie können sie bei Bedarf verschieben oder entfernen.
                personal_VTableAdapter.Fill(festManagerDataSet.Personal_V);
                _personalId = (int) personalComboBox.SelectedValue;
                FillGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void personalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _personalId = (int)personalComboBox.SelectedValue;
            FillGridView();
        }

        private void FillGridView()
        {
            try
            {
                // TODO: Diese Codezeile lädt Daten in die Tabelle "festManagerDataSet.PersonalArtikel". Sie können sie bei Bedarf verschieben oder entfernen.
                //this.personalArtikelTableAdapter.Fill(this.festManagerDataSet.PersonalArtikel);

                DataTable t = personalArtikelTableAdapter.GetDataByPersonalId(_personalId);
                personalArtikelDataGridView.DataSource = t;

            }
            catch (Exception ex)
            {
                MessageBox.Show(Resources.Database_Error_Message_Pfx + ex.Message,
                    Resources.Database_Error_Message_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void personalArtikelDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _artikelBestellungId = (int)personalArtikelDataGridView.Rows[e.RowIndex].Cells[0].Value;
            btnStornoArtikelBestellung.Visible = true;

            var detailsText = "[" + personalArtikelDataGridView.Rows[e.RowIndex].Cells[1].Value + "]";
            detailsText += "  -  " + personalArtikelDataGridView.Rows[e.RowIndex].Cells[4].Value + "x ";
            detailsText += personalArtikelDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            detailsText += "   (um € " + personalArtikelDataGridView.Rows[e.RowIndex].Cells[6].Value +")";
            labelArtikelBestellungDetails.Text = detailsText;
        }

        private void btnStornoArtikelBestellung_Click(object sender, EventArgs e)
        {
            var sicherheitsabfrage = new FormDialog();
            if (sicherheitsabfrage.ShowDialog(this) == DialogResult.OK)
            {
                // OK
                personalArtikelTableAdapter.DeleteByBestellungArtikelId(_artikelBestellungId);
            }
            else
            {
                // Cancel
            }
            sicherheitsabfrage.Dispose();

            FillGridView();
            btnStornoArtikelBestellung.Visible = false;
            labelArtikelBestellungDetails.Text = "";
        }

    }
}