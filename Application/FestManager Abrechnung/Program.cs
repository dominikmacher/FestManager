using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using FestManager_Core.Forms;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using FestManager_Abrechnung.Properties;
using FestManager_Core;

namespace FestManager_Abrechnung
{
    internal static class Program
    {
        
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var kellnerabrechnungNode = new TreeViewNode("Kellnerabrechnung", 10, 11);
            var offeneAbrechnungenNode = new TreeViewNode("Offene Abrechnungen", 10, 11);
            var manuellesStornierenNode = new TreeViewNode("Manuelles Stornieren", 8, 9);

            var festManagerNode = new TreeViewNode("Festmanager", 12, 13);

            festManagerNode.Children.Add(kellnerabrechnungNode);
            festManagerNode.Children.Add(offeneAbrechnungenNode);
            festManagerNode.Children.Add(manuellesStornierenNode);

            var personalNode = new TreeViewNode("Personal", 2, 3);
            var artikelNode = new TreeViewNode("Artikel", 4, 5);
            var ausgabestellenNode = new TreeViewNode("Ausgabestellen", 14, 15);

            var einstellungenNode = new TreeViewNode("Einstellungen", 6, 7);

            einstellungenNode.Children.Add(personalNode);
            einstellungenNode.Children.Add(artikelNode);
            einstellungenNode.Children.Add(ausgabestellenNode);

            var infoNode = new TreeViewNode("Info", 0, 1);

            var nodes = new Collection<TreeViewNode>
            {
                festManagerNode,
                einstellungenNode,
                infoNode
            };

            var settingsPath = FormMain.DefaultSettingsPath;
            if (args.Length > 0)
            {
                settingsPath = args[0];
            }

            FestManagerSettings settings = null;

            try
            {
                settings = FestManagerSettings.Load(settingsPath);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(Resources.Fatal_Settings_not_found + settingsPath,
                    Resources.Fatal_Settings_not_found_Title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show(Resources.Fatal_Invalid_settings + settingsPath,
                    Resources.Fatal_Invalid_settings_Title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Application.Run(new FormMain("Abrechnung", nodes, settings));
        }
    }
}
