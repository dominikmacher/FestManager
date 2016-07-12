using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using FestManager_Core.Forms;
using System.Configuration;
using System.Collections.Specialized;
using FestManager_Core;

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

            var settings = new FestManagerSettings()
            {
                ConnectionString = Properties.Settings.Default.connectionString,
            };

            // Overwrite default settings:
            var appSettings = new StringCollection();
            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {
                appSettings.Add(currentProperty.Name);
            }

            if (appSettings.Contains("organisation"))
            {
                settings.Organisation = (string) Properties.Settings.Default["organisation"];
            }
            if (appSettings.Contains("printDirektverkaufTwice"))
            {
                settings.PrintDirektverkaufTwice = (bool) Properties.Settings.Default["printDirektverkaufTwice"];
            }
            if (appSettings.Contains("printStornoOrders"))
            {
                settings.PrintStornoOrders = (bool) Properties.Settings.Default["printStornoOrders"];
            }
            if (appSettings.Contains("direktverkaufPersonalId"))
            {
                settings.DirektverkaufPersonalId = (int) Properties.Settings.Default["direktverkaufPersonalId"];
            }
            if (appSettings.Contains("direktverkaufAusgabestelleId"))
            {
                settings.DirektverkaufAusgabestelleId = (int) Properties.Settings.Default["direktverkaufAusgabestelleId"];
            }
            if (appSettings.Contains("stornoSymbol"))
            {
                settings.StornoSymbol = (string) Properties.Settings.Default["stornoSymbol"];
            }
            if (appSettings.Contains("groupElementsBeforePrint"))
            {
                settings.GroupElementsBeforePrint = (bool) Properties.Settings.Default["groupElementsBeforePrint"];
            }
            if (appSettings.Contains("einpackenSymbol"))
            {
                settings.EinpackenSymbol = (string) Properties.Settings.Default["einpackenSymbol"];
            }
            if (appSettings.Contains("tableNumbers"))
            {
                settings.TableNumbers = (bool) Properties.Settings.Default["tableNumbers"];
            }

            var bestellungNode = new TreeViewNode("Bestellung", 8, 9);
            var bestellungenHistoryNode = new TreeViewNode("Bestellungen History", 4, 5);

            var festmanagerNode = new TreeViewNode("Festmanager", 12, 13);
            festmanagerNode.Children.Add(bestellungNode);
            festmanagerNode.Children.Add(bestellungenHistoryNode);

            var personalNode = new TreeViewNode("Personal", 2, 3);
            var artikelNode = new TreeViewNode("Artikel", 4, 5);
            var ausgabestellenNode = new TreeViewNode("Ausgabestellen", 14, 15);

            var einstellungeNode = new TreeViewNode("Einstellungen", 6, 7);
            einstellungeNode.Children.Add(personalNode);
            einstellungeNode.Children.Add(artikelNode);
            einstellungeNode.Children.Add(ausgabestellenNode);

            var infoNode = new TreeViewNode("Info", 0, 1);

            var nodes = new Collection<TreeViewNode>
            {
                festmanagerNode,
                einstellungeNode,
                infoNode
            };

            FestManagerSettings.Default = settings;

            Application.Run(new FormMain("Bestellung", nodes, settings));
        }
    }
}
