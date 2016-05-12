namespace FestManager.Forms
{
    partial class FormBestellung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBestellung));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.stornierenButton = new System.Windows.Forms.Button();
            this.abschliessenButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.artikelDataGridView = new System.Windows.Forms.DataGridView();
            this.bestellungIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mengeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortcutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.festManagerDataSet = new FestManager.Data.FestManagerDataSet();
            this.gesamtpreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestellungArtikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storniertLabel = new System.Windows.Forms.Label();
            this.storniertComboBox = new System.Windows.Forms.ComboBox();
            this.gesamtpreisTextBox = new System.Windows.Forms.TextBox();
            this.gesamtpreisLabel = new System.Windows.Forms.Label();
            this.zeitpunktTextBox = new System.Windows.Forms.TextBox();
            this.zeitpunktLabel = new System.Windows.Forms.Label();
            this.personalIdLabel = new System.Windows.Forms.Label();
            this.personalIdComboBox = new System.Windows.Forms.ComboBox();
            this.personalVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bestellungIdLabel = new System.Windows.Forms.Label();
            this.bestellungIdTextBox = new System.Windows.Forms.TextBox();
            this.personalVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.bestellungArtikelTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.BestellungArtikelTableAdapter();
            this.artikelTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.ArtikelTableAdapter();
            this.bestellungTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.BestellungTableAdapter();
            this.personal_VTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.Personal_VTableAdapter();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.actionsPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungArtikelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.actionsPanel);
            this.toolStripContainer.ContentPanel.Controls.Add(this.contentPanel);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(924, 464);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(924, 489);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Enabled = false;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.stornierenButton);
            this.actionsPanel.Controls.Add(this.abschliessenButton);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsPanel.Location = new System.Drawing.Point(0, 422);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(924, 42);
            this.actionsPanel.TabIndex = 1;
            // 
            // stornierenButton
            // 
            this.stornierenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stornierenButton.Location = new System.Drawing.Point(666, 5);
            this.stornierenButton.Name = "stornierenButton";
            this.stornierenButton.Size = new System.Drawing.Size(120, 23);
            this.stornierenButton.TabIndex = 2;
            this.stornierenButton.Text = "&stornieren";
            this.stornierenButton.UseVisualStyleBackColor = true;
            this.stornierenButton.Click += new System.EventHandler(this.stornierenButton_Click);
            // 
            // abschliessenButton
            // 
            this.abschliessenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.abschliessenButton.Location = new System.Drawing.Point(792, 5);
            this.abschliessenButton.Name = "abschliessenButton";
            this.abschliessenButton.Size = new System.Drawing.Size(120, 23);
            this.abschliessenButton.TabIndex = 3;
            this.abschliessenButton.Text = "&abschließen";
            this.abschliessenButton.UseVisualStyleBackColor = true;
            this.abschliessenButton.Click += new System.EventHandler(this.abschliessenButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.artikelDataGridView);
            this.contentPanel.Controls.Add(this.storniertLabel);
            this.contentPanel.Controls.Add(this.storniertComboBox);
            this.contentPanel.Controls.Add(this.gesamtpreisTextBox);
            this.contentPanel.Controls.Add(this.gesamtpreisLabel);
            this.contentPanel.Controls.Add(this.zeitpunktTextBox);
            this.contentPanel.Controls.Add(this.zeitpunktLabel);
            this.contentPanel.Controls.Add(this.personalIdLabel);
            this.contentPanel.Controls.Add(this.personalIdComboBox);
            this.contentPanel.Controls.Add(this.bestellungIdLabel);
            this.contentPanel.Controls.Add(this.bestellungIdTextBox);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(924, 464);
            this.contentPanel.TabIndex = 0;
            // 
            // artikelDataGridView
            // 
            this.artikelDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.artikelDataGridView.AutoGenerateColumns = false;
            this.artikelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artikelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bestellungIdDataGridViewTextBoxColumn,
            this.mengeDataGridViewTextBoxColumn,
            this.shortcutDataGridViewTextBoxColumn,
            this.artikelIdDataGridViewTextBoxColumn,
            this.gesamtpreisDataGridViewTextBoxColumn});
            this.artikelDataGridView.DataSource = this.bestellungArtikelBindingSource;
            this.artikelDataGridView.Location = new System.Drawing.Point(15, 70);
            this.artikelDataGridView.Name = "artikelDataGridView";
            this.artikelDataGridView.Size = new System.Drawing.Size(897, 308);
            this.artikelDataGridView.TabIndex = 1;
            this.artikelDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.artikelDataGridView_CellValidated);
            this.artikelDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.artikelDataGridView_CellValueChanged);
            this.artikelDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.artikelDataGridView_RowEnter);
            this.artikelDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.artikelDataGridView_RowsAdded);
            this.artikelDataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.artikelDataGridView_UserAddedRow);
            this.artikelDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.artikelDataGridView_KeyPress);
            // 
            // bestellungIdDataGridViewTextBoxColumn
            // 
            this.bestellungIdDataGridViewTextBoxColumn.DataPropertyName = "BestellungId";
            this.bestellungIdDataGridViewTextBoxColumn.HeaderText = "Bestellung-ID";
            this.bestellungIdDataGridViewTextBoxColumn.Name = "bestellungIdDataGridViewTextBoxColumn";
            this.bestellungIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // mengeDataGridViewTextBoxColumn
            // 
            this.mengeDataGridViewTextBoxColumn.DataPropertyName = "Menge";
            this.mengeDataGridViewTextBoxColumn.HeaderText = "Menge";
            this.mengeDataGridViewTextBoxColumn.Name = "mengeDataGridViewTextBoxColumn";
            // 
            // shortcutDataGridViewTextBoxColumn
            // 
            this.shortcutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.shortcutDataGridViewTextBoxColumn.HeaderText = "Kürzel";
            this.shortcutDataGridViewTextBoxColumn.Name = "shortcutDataGridViewTextBoxColumn";
            this.shortcutDataGridViewTextBoxColumn.Width = 61;
            // 
            // artikelIdDataGridViewTextBoxColumn
            // 
            this.artikelIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artikelIdDataGridViewTextBoxColumn.DataPropertyName = "ArtikelId";
            this.artikelIdDataGridViewTextBoxColumn.DataSource = this.artikelBindingSource;
            this.artikelIdDataGridViewTextBoxColumn.DisplayMember = "Bezeichnung";
            this.artikelIdDataGridViewTextBoxColumn.HeaderText = "Artikel";
            this.artikelIdDataGridViewTextBoxColumn.Name = "artikelIdDataGridViewTextBoxColumn";
            this.artikelIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.artikelIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.artikelIdDataGridViewTextBoxColumn.ValueMember = "ArtikelId";
            // 
            // artikelBindingSource
            // 
            this.artikelBindingSource.DataMember = "Artikel";
            this.artikelBindingSource.DataSource = this.festManagerDataSet;
            // 
            // festManagerDataSet
            // 
            this.festManagerDataSet.DataSetName = "FestManagerDataSet";
            this.festManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gesamtpreisDataGridViewTextBoxColumn
            // 
            this.gesamtpreisDataGridViewTextBoxColumn.DataPropertyName = "Gesamtpreis";
            this.gesamtpreisDataGridViewTextBoxColumn.HeaderText = "Gesamtpreis";
            this.gesamtpreisDataGridViewTextBoxColumn.Name = "gesamtpreisDataGridViewTextBoxColumn";
            // 
            // bestellungArtikelBindingSource
            // 
            this.bestellungArtikelBindingSource.DataMember = "BestellungArtikel";
            this.bestellungArtikelBindingSource.DataSource = this.festManagerDataSet;
            // 
            // storniertLabel
            // 
            this.storniertLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.storniertLabel.AutoSize = true;
            this.storniertLabel.Location = new System.Drawing.Point(683, 40);
            this.storniertLabel.Name = "storniertLabel";
            this.storniertLabel.Size = new System.Drawing.Size(49, 13);
            this.storniertLabel.TabIndex = 9;
            this.storniertLabel.Text = "Storniert:";
            this.storniertLabel.Visible = false;
            // 
            // storniertComboBox
            // 
            this.storniertComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.storniertComboBox.Enabled = false;
            this.storniertComboBox.FormattingEnabled = true;
            this.storniertComboBox.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.storniertComboBox.Location = new System.Drawing.Point(791, 40);
            this.storniertComboBox.Name = "storniertComboBox";
            this.storniertComboBox.Size = new System.Drawing.Size(121, 21);
            this.storniertComboBox.TabIndex = 8;
            this.storniertComboBox.Visible = false;
            // 
            // gesamtpreisTextBox
            // 
            this.gesamtpreisTextBox.Location = new System.Drawing.Point(791, 385);
            this.gesamtpreisTextBox.Name = "gesamtpreisTextBox";
            this.gesamtpreisTextBox.Size = new System.Drawing.Size(121, 20);
            this.gesamtpreisTextBox.TabIndex = 7;
            // 
            // gesamtpreisLabel
            // 
            this.gesamtpreisLabel.AutoSize = true;
            this.gesamtpreisLabel.Location = new System.Drawing.Point(700, 388);
            this.gesamtpreisLabel.Name = "gesamtpreisLabel";
            this.gesamtpreisLabel.Size = new System.Drawing.Size(68, 13);
            this.gesamtpreisLabel.TabIndex = 6;
            this.gesamtpreisLabel.Text = "Gesamtpreis:";
            // 
            // zeitpunktTextBox
            // 
            this.zeitpunktTextBox.Enabled = false;
            this.zeitpunktTextBox.Location = new System.Drawing.Point(91, 40);
            this.zeitpunktTextBox.Name = "zeitpunktTextBox";
            this.zeitpunktTextBox.ReadOnly = true;
            this.zeitpunktTextBox.Size = new System.Drawing.Size(245, 20);
            this.zeitpunktTextBox.TabIndex = 5;
            // 
            // zeitpunktLabel
            // 
            this.zeitpunktLabel.AutoSize = true;
            this.zeitpunktLabel.Location = new System.Drawing.Point(12, 43);
            this.zeitpunktLabel.Name = "zeitpunktLabel";
            this.zeitpunktLabel.Size = new System.Drawing.Size(55, 13);
            this.zeitpunktLabel.TabIndex = 4;
            this.zeitpunktLabel.Text = "Zeitpunkt:";
            // 
            // personalIdLabel
            // 
            this.personalIdLabel.AutoSize = true;
            this.personalIdLabel.Location = new System.Drawing.Point(12, 16);
            this.personalIdLabel.Name = "personalIdLabel";
            this.personalIdLabel.Size = new System.Drawing.Size(51, 13);
            this.personalIdLabel.TabIndex = 3;
            this.personalIdLabel.Text = "Personal:";
            // 
            // personalIdComboBox
            // 
            this.personalIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.personalIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.personalIdComboBox.DataSource = this.personalVBindingSource1;
            this.personalIdComboBox.DisplayMember = "Personal";
            this.personalIdComboBox.FormattingEnabled = true;
            this.personalIdComboBox.Location = new System.Drawing.Point(91, 13);
            this.personalIdComboBox.Name = "personalIdComboBox";
            this.personalIdComboBox.Size = new System.Drawing.Size(245, 21);
            this.personalIdComboBox.TabIndex = 0;
            this.personalIdComboBox.ValueMember = "PersonalId";
            this.personalIdComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.personalIdComboBox_KeyDown);
            // 
            // personalVBindingSource1
            // 
            this.personalVBindingSource1.DataMember = "Personal_V";
            this.personalVBindingSource1.DataSource = this.festManagerDataSet;
            // 
            // bestellungIdLabel
            // 
            this.bestellungIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bestellungIdLabel.AutoSize = true;
            this.bestellungIdLabel.Location = new System.Drawing.Point(683, 16);
            this.bestellungIdLabel.Name = "bestellungIdLabel";
            this.bestellungIdLabel.Size = new System.Drawing.Size(73, 13);
            this.bestellungIdLabel.TabIndex = 1;
            this.bestellungIdLabel.Text = "Bestellung-ID:";
            this.bestellungIdLabel.Visible = false;
            // 
            // bestellungIdTextBox
            // 
            this.bestellungIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bestellungIdTextBox.Enabled = false;
            this.bestellungIdTextBox.Location = new System.Drawing.Point(791, 13);
            this.bestellungIdTextBox.Name = "bestellungIdTextBox";
            this.bestellungIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.bestellungIdTextBox.TabIndex = 0;
            // 
            // personalVBindingSource
            // 
            this.personalVBindingSource.DataMember = "Personal_V";
            this.personalVBindingSource.DataSource = this.festManagerDataSet;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.AllowPrintToFile = false;
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // bestellungArtikelTableAdapter
            // 
            this.bestellungArtikelTableAdapter.ClearBeforeFill = true;
            // 
            // artikelTableAdapter
            // 
            this.artikelTableAdapter.ClearBeforeFill = true;
            // 
            // bestellungTableAdapter
            // 
            this.bestellungTableAdapter.ClearBeforeFill = true;
            // 
            // personal_VTableAdapter
            // 
            this.personal_VTableAdapter.ClearBeforeFill = true;
            // 
            // FormBestellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 489);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FormBestellung";
            this.Text = "Bestellung";
            this.Load += new System.EventHandler(this.FormBestellung_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormBestellung_KeyPress);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.actionsPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungArtikelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Button abschliessenButton;
        private System.Windows.Forms.Button stornierenButton;
        private System.Windows.Forms.TextBox bestellungIdTextBox;
        private System.Windows.Forms.Label bestellungIdLabel;
        private FestManager.Data.FestManagerDataSet festManagerDataSet;
        private System.Windows.Forms.Label personalIdLabel;
        private System.Windows.Forms.Label zeitpunktLabel;
        private System.Windows.Forms.TextBox zeitpunktTextBox;
        private System.Windows.Forms.Label gesamtpreisLabel;
        private System.Windows.Forms.TextBox gesamtpreisTextBox;
        private System.Windows.Forms.ComboBox storniertComboBox;
        private System.Windows.Forms.Label storniertLabel;
        private System.Windows.Forms.DataGridView artikelDataGridView;
        private System.Windows.Forms.BindingSource bestellungArtikelBindingSource;
        private FestManager.Data.FestManagerDataSetTableAdapters.BestellungArtikelTableAdapter bestellungArtikelTableAdapter;
        private FestManager.Data.FestManagerDataSetTableAdapters.ArtikelTableAdapter artikelTableAdapter;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.BindingSource artikelBindingSource;
        private FestManager.Data.FestManagerDataSetTableAdapters.BestellungTableAdapter bestellungTableAdapter;
        private System.Windows.Forms.BindingSource personalVBindingSource;
        private System.Windows.Forms.BindingSource personalVBindingSource1;
        private FestManager.Data.FestManagerDataSetTableAdapters.Personal_VTableAdapter personal_VTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestellungIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortcutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn artikelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gesamtpreisDataGridViewTextBoxColumn;
        public System.Windows.Forms.ComboBox personalIdComboBox;
    }
}