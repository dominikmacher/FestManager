using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using FestManager_Core.Forms;
using System.Collections.Specialized;
using System.Configuration;

namespace FestManager_Abrechnung
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

            TreeViewNode node1 = new TreeViewNode("Kellnerabrechnung", 10, 11);
            TreeViewNode node1_ = new TreeViewNode("Offene Abrechnungen", 10, 11);
            TreeViewNode node2 = new TreeViewNode("Manuelles Stornieren", 8, 9);
            TreeViewNode node3 = new TreeViewNode("Festmanager", 12, 13);
            node3.children.Add(node1);
            node3.children.Add(node1_);
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

            /*System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Kellnerabrechnung", 10, 11);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Manuelles Stornieren", 8, 9);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Festmanager", 12, 13, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Personal", 2, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Artikel", 4, 5);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ausgabestellen", 14, 15);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Einstellungen", 6, 7, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            treeNode1.ImageIndex = 10;
            treeNode1.Name = "kellnerabrechnungNode";
            treeNode1.SelectedImageIndex = 11;
            treeNode1.Text = "Kellnerabrechnung";
            treeNode2.ImageIndex = 8;
            treeNode2.Name = "ManualStornoNode";
            treeNode2.SelectedImageIndex = 9;
            treeNode2.Text = "Manuelles Stornieren";
            treeNode3.ImageIndex = 12;
            treeNode3.Name = "festmanagerNode";
            treeNode3.SelectedImageIndex = 13;
            treeNode3.Text = "Festmanager";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "personalNode";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Personal";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "artikelNode";
            treeNode5.SelectedImageIndex = 5;
            treeNode5.Text = "Artikel";
            treeNode6.ImageIndex = 14;
            treeNode6.Name = "ausgabestellenNode";
            treeNode6.SelectedImageIndex = 15;
            treeNode6.Text = "Ausgabestellen";
            treeNode7.ImageIndex = 6;
            treeNode7.Name = "einstellungenNode";
            treeNode7.SelectedImageIndex = 7;
            treeNode7.Text = "Einstellungen";
            this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7});*/

            Application.Run(new FormMain("Abrechnung", nodes));
        }
    }
}
