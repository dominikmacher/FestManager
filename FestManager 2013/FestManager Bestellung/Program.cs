using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using FestManager_Core.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace FestManager_Bestellung
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FestManager_Core.Properties.Settings.Default["connectionString"] = Properties.Settings.Default.connectionString;
            // Overwrite default settings:
            StringCollection appSettings = new StringCollection();
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

            TreeViewNode node1 = new TreeViewNode("Bestellung", 8, 9);
            TreeViewNode node2 = new TreeViewNode("Bestellungen History", 4, 5);
            TreeViewNode node3 = new TreeViewNode("Festmanager", 12, 13);
            node3.children.Add(node1);
            node3.children.Add(node2);
            TreeViewNode node4 = new TreeViewNode("Personal", 2, 3);
            TreeViewNode node5 = new TreeViewNode("Artikel", 4, 5);
            TreeViewNode node6 = new TreeViewNode("Ausgabestellen", 14, 15);
            TreeViewNode node7 = new TreeViewNode("Einstellungen", 6, 7);
            node7.children.Add(node4);
            node7.children.Add(node5);
            node7.children.Add(node6);
            TreeViewNode node8 = new TreeViewNode("Info", 0, 1);
            Collection<TreeViewNode> nodes = new Collection<TreeViewNode>();
            nodes.Add(node3);
            nodes.Add(node7);
            nodes.Add(node8);

            /*System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Bestellung", 8, 9);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Bestellungen History", 4, 5);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Festmanager", 12, 13, new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Personal", 2, 3);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Artikel", 4, 5);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Ausgabestellen", 14, 15);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Einstellungen", 6, 7, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            treeNode8.ImageIndex = 8;
            treeNode8.Name = "bestellungNode";
            treeNode8.SelectedImageIndex = 9;
            treeNode8.Text = "Bestellung";
            treeNode9.ImageIndex = 4;
            treeNode9.Name = "bestellungHistoryNode";
            treeNode9.SelectedImageIndex = 5;
            treeNode9.Text = "Bestellungen History";
            treeNode10.ImageIndex = 12;
            treeNode10.Name = "festmanagerNode";
            treeNode10.SelectedImageIndex = 13;
            treeNode10.Text = "Festmanager";
            treeNode11.ImageIndex = 2;
            treeNode11.Name = "personalNode";
            treeNode11.SelectedImageIndex = 3;
            treeNode11.Text = "Personal";
            treeNode12.ImageIndex = 4;
            treeNode12.Name = "artikelNode";
            treeNode12.SelectedImageIndex = 5;
            treeNode12.Text = "Artikel";
            treeNode13.ImageIndex = 14;
            treeNode13.Name = "ausgabestellenNode";
            treeNode13.SelectedImageIndex = 15;
            treeNode13.Text = "Ausgabestellen";
            treeNode14.ImageIndex = 6;
            treeNode14.Name = "einstellungenNode";
            treeNode14.SelectedImageIndex = 7;
            treeNode14.Text = "Einstellungen";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode14});*/

            Application.Run(new FormMain("Bestellung", nodes));
        }
    }
}
