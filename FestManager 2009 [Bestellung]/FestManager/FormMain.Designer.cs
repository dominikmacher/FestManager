namespace FestManager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bestellung", 8, 9);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bestellungen History", 4, 5);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeViewMain = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // treeViewMain
            // 
            this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewMain.ImageIndex = 0;
            this.treeViewMain.ImageList = this.imageList;
            this.treeViewMain.Location = new System.Drawing.Point(0, 0);
            this.treeViewMain.Name = "treeViewMain";
            treeNode1.ImageIndex = 8;
            treeNode1.Name = "bestellungNode";
            treeNode1.SelectedImageIndex = 9;
            treeNode1.Text = "Bestellung";
            treeNode2.ImageIndex = 4;
            treeNode2.Name = "bestellungHistoryNode";
            treeNode2.SelectedImageIndex = 5;
            treeNode2.Text = "Bestellungen History";
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
            treeNode7});
            this.treeViewMain.SelectedImageIndex = 0;
            this.treeViewMain.Size = new System.Drawing.Size(213, 431);
            this.treeViewMain.TabIndex = 4;
            this.treeViewMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMain_AfterSelect);
            this.treeViewMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewMain_NodeMouseClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.White;
            this.imageList.Images.SetKeyName(0, "calculator.png");
            this.imageList.Images.SetKeyName(1, "calculator_accept.png");
            this.imageList.Images.SetKeyName(2, "user.png");
            this.imageList.Images.SetKeyName(3, "user_accept.png");
            this.imageList.Images.SetKeyName(4, "shopping_cart.png");
            this.imageList.Images.SetKeyName(5, "shopping_cart_accept.png");
            this.imageList.Images.SetKeyName(6, "process.png");
            this.imageList.Images.SetKeyName(7, "process_accept.png");
            this.imageList.Images.SetKeyName(8, "note_edit.png");
            this.imageList.Images.SetKeyName(9, "note_accept.png");
            this.imageList.Images.SetKeyName(10, "chart.png");
            this.imageList.Images.SetKeyName(11, "chart_accept.png");
            this.imageList.Images.SetKeyName(12, "home.png");
            this.imageList.Images.SetKeyName(13, "home_next.png");
            this.imageList.Images.SetKeyName(14, "mail.png");
            this.imageList.Images.SetKeyName(15, "mail_accept.png");
            this.imageList.Images.SetKeyName(16, "printer.png");
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(462, 382);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 453);
            this.Controls.Add(this.treeViewMain);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "Festmanager 2009 [Bestellungen]";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TreeView treeViewMain;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}



