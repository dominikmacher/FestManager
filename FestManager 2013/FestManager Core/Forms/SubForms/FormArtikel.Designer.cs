namespace FestManager_Core.Forms.SubForms
{
    partial class FormArtikel
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
            this.festManagerDataSet = new FestManager_Core.Data.FestManagerDataSet();
            this.ausgabestelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikelTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.ArtikelTableAdapter();
            this.ausgabestelleTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
            this.titleLabel = new System.Windows.Forms.Label();
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.zuruecksetzenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.artikelDataGridView = new System.Windows.Forms.DataGridView();
            this.artikelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortCutNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.einzelpreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gueltigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ausgabestelleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ausgabestelleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelBindingSource)).BeginInit();
            this.operationsPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // festManagerDataSet
            // 
            this.festManagerDataSet.DataSetName = "FestManagerDataSet";
            this.festManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ausgabestelleBindingSource
            // 
            this.ausgabestelleBindingSource.DataMember = "Ausgabestelle";
            this.ausgabestelleBindingSource.DataSource = this.festManagerDataSet;
            // 
            // artikelBindingSource
            // 
            this.artikelBindingSource.DataMember = "Artikel";
            this.artikelBindingSource.DataSource = this.festManagerDataSet;
            // 
            // artikelTableAdapter
            // 
            this.artikelTableAdapter.ClearBeforeFill = true;
            // 
            // ausgabestelleTableAdapter
            // 
            this.ausgabestelleTableAdapter.ClearBeforeFill = true;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(695, 26);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Artikel";
            // 
            // operationsPanel
            // 
            this.operationsPanel.Controls.Add(this.zuruecksetzenButton);
            this.operationsPanel.Controls.Add(this.speichernButton);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationsPanel.Location = new System.Drawing.Point(0, 306);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(695, 48);
            this.operationsPanel.TabIndex = 4;
            // 
            // zuruecksetzenButton
            // 
            this.zuruecksetzenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zuruecksetzenButton.Location = new System.Drawing.Point(437, 13);
            this.zuruecksetzenButton.Name = "zuruecksetzenButton";
            this.zuruecksetzenButton.Size = new System.Drawing.Size(120, 23);
            this.zuruecksetzenButton.TabIndex = 1;
            this.zuruecksetzenButton.Text = "&Zurücksetzen";
            this.zuruecksetzenButton.UseVisualStyleBackColor = true;
            this.zuruecksetzenButton.Click += new System.EventHandler(this.zuruecksetzenButton_Click);
            // 
            // speichernButton
            // 
            this.speichernButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speichernButton.Location = new System.Drawing.Point(563, 13);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(120, 23);
            this.speichernButton.TabIndex = 0;
            this.speichernButton.Text = "&Speichern";
            this.speichernButton.UseVisualStyleBackColor = true;
            this.speichernButton.Click += new System.EventHandler(this.speichernButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.artikelDataGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(695, 280);
            this.contentPanel.TabIndex = 5;
            // 
            // artikelDataGridView
            // 
            this.artikelDataGridView.AutoGenerateColumns = false;
            this.artikelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artikelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikelIdDataGridViewTextBoxColumn,
            this.ShortCutNr,
            this.bezeichnungDataGridViewTextBoxColumn,
            this.einzelpreisDataGridViewTextBoxColumn,
            this.gueltigDataGridViewTextBoxColumn,
            this.ausgabestelleIdDataGridViewTextBoxColumn});
            this.artikelDataGridView.DataSource = this.artikelBindingSource;
            this.artikelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artikelDataGridView.Location = new System.Drawing.Point(0, 0);
            this.artikelDataGridView.Name = "artikelDataGridView";
            this.artikelDataGridView.Size = new System.Drawing.Size(695, 280);
            this.artikelDataGridView.TabIndex = 1;
            // 
            // artikelIdDataGridViewTextBoxColumn
            // 
            this.artikelIdDataGridViewTextBoxColumn.DataPropertyName = "ArtikelId";
            this.artikelIdDataGridViewTextBoxColumn.HeaderText = "Artikel-ID";
            this.artikelIdDataGridViewTextBoxColumn.Name = "artikelIdDataGridViewTextBoxColumn";
            this.artikelIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.artikelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ShortCutNr
            // 
            this.ShortCutNr.DataPropertyName = "ShortCutNr";
            this.ShortCutNr.HeaderText = "Kürzel";
            this.ShortCutNr.Name = "ShortCutNr";
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // einzelpreisDataGridViewTextBoxColumn
            // 
            this.einzelpreisDataGridViewTextBoxColumn.DataPropertyName = "Einzelpreis";
            this.einzelpreisDataGridViewTextBoxColumn.HeaderText = "Einzelpreis";
            this.einzelpreisDataGridViewTextBoxColumn.Name = "einzelpreisDataGridViewTextBoxColumn";
            // 
            // gueltigDataGridViewTextBoxColumn
            // 
            this.gueltigDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gueltigDataGridViewTextBoxColumn.DataPropertyName = "Gueltig";
            this.gueltigDataGridViewTextBoxColumn.FalseValue = "N";
            this.gueltigDataGridViewTextBoxColumn.HeaderText = "Gültig";
            this.gueltigDataGridViewTextBoxColumn.IndeterminateValue = "Y";
            this.gueltigDataGridViewTextBoxColumn.Name = "gueltigDataGridViewTextBoxColumn";
            this.gueltigDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gueltigDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gueltigDataGridViewTextBoxColumn.TrueValue = "Y";
            this.gueltigDataGridViewTextBoxColumn.Width = 59;
            // 
            // ausgabestelleIdDataGridViewTextBoxColumn
            // 
            this.ausgabestelleIdDataGridViewTextBoxColumn.DataPropertyName = "AusgabestelleId";
            this.ausgabestelleIdDataGridViewTextBoxColumn.DataSource = this.ausgabestelleBindingSource;
            this.ausgabestelleIdDataGridViewTextBoxColumn.DisplayMember = "Kuerzel";
            this.ausgabestelleIdDataGridViewTextBoxColumn.HeaderText = "Ausgabestelle";
            this.ausgabestelleIdDataGridViewTextBoxColumn.Name = "ausgabestelleIdDataGridViewTextBoxColumn";
            this.ausgabestelleIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ausgabestelleIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ausgabestelleIdDataGridViewTextBoxColumn.ValueMember = "AusgabestelleId";
            // 
            // FormArtikel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 354);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormArtikel";
            this.Text = "Artikel";
            this.Load += new System.EventHandler(this.FormArtikel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ausgabestelleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelBindingSource)).EndInit();
            this.operationsPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artikelDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FestManager_Core.Data.FestManagerDataSet festManagerDataSet;
        private System.Windows.Forms.BindingSource artikelBindingSource;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.ArtikelTableAdapter artikelTableAdapter;
        private System.Windows.Forms.BindingSource ausgabestelleBindingSource;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter ausgabestelleTableAdapter;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView artikelDataGridView;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.Button zuruecksetzenButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortCutNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn einzelpreisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gueltigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ausgabestelleIdDataGridViewTextBoxColumn;
    }
}