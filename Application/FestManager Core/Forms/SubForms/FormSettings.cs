using System;
using System.Configuration;
using System.Windows.Forms;

namespace FestManager_Core.Forms.SubForms
{
    public partial class FormSettings : FestmanagerMdiChildForm
    {
        public const string ConnectionStringPfx = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonDatabase_Click(object sender, EventArgs e)
        {
            var result = openFileDialogDatabase.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxDatabase.Text = ConnectionStringPfx + openFileDialogDatabase.FileName;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

            connectionStringsSection.ConnectionStrings["FestManager_Bestellung.Properties.Settings.connectionString"].ConnectionString = textBoxDatabase.Text;
            config.Save();

            ConfigurationManager.RefreshSection("connectionStrings");

            Application.Restart();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
           textBoxDatabase.Text = Settings.ConnectionString;
        }
    }
}
