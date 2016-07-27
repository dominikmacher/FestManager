namespace FestManager_Core.Forms.SubForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.rueckgaengigButton = new System.Windows.Forms.Button();
            this.printLastOrderButton = new System.Windows.Forms.Button();
            this.stornierenButton = new System.Windows.Forms.Button();
            this.abschliessenButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.tischLabel = new System.Windows.Forms.Label();
            this.tischTextBox = new System.Windows.Forms.TextBox();
            this.artikelDataGridView = new System.Windows.Forms.DataGridView();
            this.bestellungIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mengeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortcutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.artikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.festManagerDataSet = new FestManager_Core.Data.FestManagerDataSet();
            this.gesamtpreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestellungArtikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zeitpunktTextBox = new System.Windows.Forms.TextBox();
            this.zeitpunktLabel = new System.Windows.Forms.Label();
            this.personalIdLabel = new System.Windows.Forms.Label();
            this.personalIdComboBox = new System.Windows.Forms.ComboBox();
            this.personalVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bestellungIdLabel = new System.Windows.Forms.Label();
            this.bestellungIdTextBox = new System.Windows.Forms.TextBox();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.personalVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bestellungArtikelTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungArtikelTableAdapter();
            this.artikelTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.ArtikelTableAdapter();
            this.bestellungTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungTableAdapter();
            this.personal_VTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.Personal_VTableAdapter();
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
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(924, 474);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(924, 499);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Enabled = false;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.rueckgaengigButton);
            this.actionsPanel.Controls.Add(this.printLastOrderButton);
            this.actionsPanel.Controls.Add(this.stornierenButton);
            this.actionsPanel.Controls.Add(this.abschliessenButton);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsPanel.Location = new System.Drawing.Point(0, 432);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(924, 42);
            this.actionsPanel.TabIndex = 1;
            // 
            // rueckgaengigButton
            // 
            this.rueckgaengigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rueckgaengigButton.Image = ((System.Drawing.Image)(resources.GetObject("rueckgaengigButton.Image")));
            this.rueckgaengigButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rueckgaengigButton.Location = new System.Drawing.Point(639, 0);
            this.rueckgaengigButton.Name = "rueckgaengigButton";
            this.rueckgaengigButton.Size = new System.Drawing.Size(88, 23);
            this.rueckgaengigButton.TabIndex = 8;
            this.rueckgaengigButton.Text = "&Rückgängig";
            this.rueckgaengigButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rueckgaengigButton.UseVisualStyleBackColor = true;
            this.rueckgaengigButton.Click += new System.EventHandler(this.rueckgaengigButton_Click);
            // 
            // printLastOrderButton
            // 
            this.printLastOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("printLastOrderButton.Image")));
            this.printLastOrderButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.printLastOrderButton.Location = new System.Drawing.Point(15, 0);
            this.printLastOrderButton.Name = "printLastOrderButton";
            this.printLastOrderButton.Size = new System.Drawing.Size(156, 23);
            this.printLastOrderButton.TabIndex = 4;
            this.printLastOrderButton.Text = "Letzte Bestellung &drucken";
            this.printLastOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printLastOrderButton.UseVisualStyleBackColor = true;
            this.printLastOrderButton.Click += new System.EventHandler(this.printLastOrderButton_Click);
            // 
            // stornierenButton
            // 
            this.stornierenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stornierenButton.Image = ((System.Drawing.Image)(resources.GetObject("stornierenButton.Image")));
            this.stornierenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stornierenButton.Location = new System.Drawing.Point(733, 0);
            this.stornierenButton.Name = "stornierenButton";
            this.stornierenButton.Size = new System.Drawing.Size(75, 23);
            this.stornierenButton.TabIndex = 2;
            this.stornierenButton.Text = "&Stornieren";
            this.stornierenButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stornierenButton.UseVisualStyleBackColor = true;
            this.stornierenButton.Click += new System.EventHandler(this.stornierenButton_Click);
            // 
            // abschliessenButton
            // 
            this.abschliessenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.abschliessenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abschliessenButton.Image = ((System.Drawing.Image)(resources.GetObject("abschliessenButton.Image")));
            this.abschliessenButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.abschliessenButton.Location = new System.Drawing.Point(814, 0);
            this.abschliessenButton.Name = "abschliessenButton";
            this.abschliessenButton.Size = new System.Drawing.Size(98, 23);
            this.abschliessenButton.TabIndex = 3;
            this.abschliessenButton.Text = "&Abschließen";
            this.abschliessenButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.abschliessenButton.UseVisualStyleBackColor = true;
            this.abschliessenButton.Click += new System.EventHandler(this.abschliessenButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.labelError);
            this.contentPanel.Controls.Add(this.tischLabel);
            this.contentPanel.Controls.Add(this.tischTextBox);
            this.contentPanel.Controls.Add(this.artikelDataGridView);
            this.contentPanel.Controls.Add(this.zeitpunktTextBox);
            this.contentPanel.Controls.Add(this.zeitpunktLabel);
            this.contentPanel.Controls.Add(this.personalIdLabel);
            this.contentPanel.Controls.Add(this.personalIdComboBox);
            this.contentPanel.Controls.Add(this.bestellungIdLabel);
            this.contentPanel.Controls.Add(this.bestellungIdTextBox);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(924, 474);
            this.contentPanel.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.BackColor = System.Drawing.Color.Red;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.White;
            this.labelError.Location = new System.Drawing.Point(15, 63);
            this.labelError.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(897, 40);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "Fehlerbeschreibung";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.Visible = false;
            // 
            // tischLabel
            // 
            this.tischLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tischLabel.AutoSize = true;
            this.tischLabel.Location = new System.Drawing.Point(788, 43);
            this.tischLabel.Name = "tischLabel";
            this.tischLabel.Size = new System.Drawing.Size(36, 13);
            this.tischLabel.TabIndex = 7;
            this.tischLabel.Text = "Tisch:";
            // 
            // tischTextBox
            // 
            this.tischTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tischTextBox.Location = new System.Drawing.Point(827, 40);
            this.tischTextBox.Name = "tischTextBox";
            this.tischTextBox.Size = new System.Drawing.Size(85, 20);
            this.tischTextBox.TabIndex = 1;
            this.tischTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tischTextBox_KeyDown);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.artikelDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.artikelDataGridView.Location = new System.Drawing.Point(15, 106);
            this.artikelDataGridView.Name = "artikelDataGridView";
            this.artikelDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.artikelDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.artikelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.artikelDataGridView.Size = new System.Drawing.Size(897, 320);
            this.artikelDataGridView.TabIndex = 2;
            this.artikelDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.artikelDataGridView_CellEndEdit);
            this.artikelDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.artikelDataGridView_CellFormatting);
            this.artikelDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.artikelDataGridView_CellValidated);
            this.artikelDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.artikelDataGridView_CellValidating);
            this.artikelDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.artikelDataGridView_DataError);
            this.artikelDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.artikelDataGridView_RowEnter);
            this.artikelDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.artikelDataGridView_RowsRemoved);
            this.artikelDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.artikelDataGridView_RowValidated);
            this.artikelDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.artikelDataGridView_RowValidating);
            // 
            // bestellungIdDataGridViewTextBoxColumn
            // 
            this.bestellungIdDataGridViewTextBoxColumn.DataPropertyName = "BestellungId";
            this.bestellungIdDataGridViewTextBoxColumn.HeaderText = "Bestellung-ID";
            this.bestellungIdDataGridViewTextBoxColumn.Name = "bestellungIdDataGridViewTextBoxColumn";
            this.bestellungIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bestellungIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // mengeDataGridViewTextBoxColumn
            // 
            this.mengeDataGridViewTextBoxColumn.DataPropertyName = "Menge";
            this.mengeDataGridViewTextBoxColumn.HeaderText = "Menge";
            this.mengeDataGridViewTextBoxColumn.Name = "mengeDataGridViewTextBoxColumn";
            this.mengeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // shortcutDataGridViewTextBoxColumn
            // 
            this.shortcutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.shortcutDataGridViewTextBoxColumn.HeaderText = "Kürzel";
            this.shortcutDataGridViewTextBoxColumn.Name = "shortcutDataGridViewTextBoxColumn";
            this.shortcutDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shortcutDataGridViewTextBoxColumn.Width = 42;
            // 
            // artikelIdDataGridViewTextBoxColumn
            // 
            this.artikelIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artikelIdDataGridViewTextBoxColumn.DataPropertyName = "ArtikelId";
            this.artikelIdDataGridViewTextBoxColumn.DataSource = this.artikelBindingSource;
            this.artikelIdDataGridViewTextBoxColumn.DisplayMember = "Bezeichnung";
            this.artikelIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.artikelIdDataGridViewTextBoxColumn.HeaderText = "Artikel";
            this.artikelIdDataGridViewTextBoxColumn.Name = "artikelIdDataGridViewTextBoxColumn";
            this.artikelIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.artikelIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.gesamtpreisDataGridViewTextBoxColumn.ReadOnly = true;
            this.gesamtpreisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bestellungArtikelBindingSource
            // 
            this.bestellungArtikelBindingSource.DataMember = "BestellungArtikel";
            this.bestellungArtikelBindingSource.DataSource = this.festManagerDataSet;
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
            this.bestellungIdLabel.Location = new System.Drawing.Point(751, 16);
            this.bestellungIdLabel.Name = "bestellungIdLabel";
            this.bestellungIdLabel.Size = new System.Drawing.Size(73, 13);
            this.bestellungIdLabel.TabIndex = 1;
            this.bestellungIdLabel.Text = "Bestellung-ID:";
            // 
            // bestellungIdTextBox
            // 
            this.bestellungIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bestellungIdTextBox.Enabled = false;
            this.bestellungIdTextBox.Location = new System.Drawing.Point(827, 14);
            this.bestellungIdTextBox.Name = "bestellungIdTextBox";
            this.bestellungIdTextBox.Size = new System.Drawing.Size(85, 20);
            this.bestellungIdTextBox.TabIndex = 0;
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
            // personalVBindingSource
            // 
            this.personalVBindingSource.DataMember = "Personal_V";
            this.personalVBindingSource.DataSource = this.festManagerDataSet;
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
            this.ClientSize = new System.Drawing.Size(924, 499);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "FormBestellung";
            this.Text = "Bestellung";
            this.Load += new System.EventHandler(this.FormBestellung_Load);
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
        private FestManager_Core.Data.FestManagerDataSet festManagerDataSet;
        private System.Windows.Forms.Label personalIdLabel;
        private System.Windows.Forms.Label zeitpunktLabel;
        private System.Windows.Forms.TextBox zeitpunktTextBox;
        private System.Windows.Forms.DataGridView artikelDataGridView;
        private System.Windows.Forms.BindingSource bestellungArtikelBindingSource;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungArtikelTableAdapter bestellungArtikelTableAdapter;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.ArtikelTableAdapter artikelTableAdapter;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.BindingSource artikelBindingSource;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungTableAdapter bestellungTableAdapter;
        private System.Windows.Forms.BindingSource personalVBindingSource;
        private System.Windows.Forms.BindingSource personalVBindingSource1;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.Personal_VTableAdapter personal_VTableAdapter;
        public System.Windows.Forms.ComboBox personalIdComboBox;
        private System.Windows.Forms.Button printLastOrderButton;
        private System.Windows.Forms.Label tischLabel;
        private System.Windows.Forms.TextBox tischTextBox;
        private System.Windows.Forms.Button rueckgaengigButton;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestellungIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortcutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn artikelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gesamtpreisDataGridViewTextBoxColumn;
    }
}