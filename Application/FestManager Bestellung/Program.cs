using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using FestManager_Core.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace FestManager_Bestellung
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FestManager_Core.Properties.Settings.Default["connectionString"] = Properties.Settings.Default.connectionString;
            // Overwrite default settings:
            var appSettings = new StringCollection();
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                appSettings.Add(currentProperty.Name);
            }
            if (appSettings.Contains("organisation"))
            {
                FestManager_Core.Properties.Settings.Default["organisation"] = Properties.Settings.Default["organisation"];
            }
            if (appSettings.Contains("printDirektverkaufTwice"))
            {
                FestManager_Core.Properties.Settings.Default["printDirektverkaufTwice"] = Properties.Settings.Default["printDirektverkaufTwice"];
            }
            if (appSettings.Contains("printStornoOrders"))
            {
                FestManager_Core.Properties.Settings.Default["printStornoOrders"] = Properties.Settings.Default["printStornoOrders"];
            }
            if (appSettings.Contains("direktverkaufPersonalId"))
            {
                FestManager_Core.Properties.Settings.Default["direktverkaufPersonalId"] = Properties.Settings.Default["direktverkaufPersonalId"];
            }
            if (appSettings.Contains("direktverkaufAusgabestelleId"))
            {
                FestManager_Core.Properties.Settings.Default["direktverkaufAusgabestelleId"] = Properties.Settings.Default["direktverkaufAusgabestelleId"];
            }
            if (appSettings.Contains("stornoSymbol"))
            {
                FestManager_Core.Properties.Settings.Default["stornoSymbol"] = Properties.Settings.Default["stornoSymbol"];
            }
            if (appSettings.Contains("groupElementsBeforePrint"))
            {
                FestManager_Core.Properties.Settings.Default["groupElementsBeforePrint"] = Properties.Settings.Default["groupElementsBeforePrint"];
            }
            if (appSettings.Contains("einpackenSymbol"))
            {
                FestManager_Core.Properties.Settings.Default["einpackenSymbol"] = Properties.Settings.Default["einpackenSymbol"];
            }
            if (appSettings.Contains("tableNumbers"))
            {
                FestManager_Core.Properties.Settings.Default["tableNumbers"] = Properties.Settings.Default["tableNumbers"];
            }

            var bestellungNode = new TreeViewNode("Bestellung", 8, 9);
            var bestellungenHistoryNode = new TreeViewNode("Bestellungen History", 4, 5);

            var festmanagerNode = new TreeViewNode("Festmanager", 12, 13);
            festmanagerNode.children.Add(bestellungNode);
            festmanagerNode.children.Add(bestellungenHistoryNode);

            var personalNode = new TreeViewNode("Personal", 2, 3);
            var artikelNode = new TreeViewNode("Artikel", 4, 5);
            var ausgabestellenNode = new TreeViewNode("Ausgabestellen", 14, 15);

            var einstellungeNode = new TreeViewNode("Einstellungen", 6, 7);
            einstellungeNode.children.Add(personalNode);
            einstellungeNode.children.Add(artikelNode);
            einstellungeNode.children.Add(ausgabestellenNode);

            var infoNode = new TreeViewNode("Info", 0, 1);

            var nodes = new Collection<TreeViewNode>
            {
                festmanagerNode,
                einstellungeNode,
                infoNode
            };

            Application.Run(new FormMain("Bestellung", nodes));
        }
    }
}
