namespace FestManager.Forms
{
    partial class FormAusgabestelle
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
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.zuruecksetzenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.ausgabestelleDataGridView = new System.Windows.Forms.DataGridView();
            this.festManagerDataSet = new FestManager.Data.FestManagerDataSet();
            this.ausgabestelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ausgabestelleTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter();
            this.ausgabestelleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuerzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drucker = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.operationsPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ausgabestelleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ausgabestelleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // operationsPanel
            // 
            this.operationsPanel.Controls.Add(this.zuruecksetzenButton);
            this.operationsPanel.Controls.Add(this.speichernButton);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationsPanel.Location = new System.Drawing.Point(0, 355);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(707, 48);
            this.operationsPanel.TabIndex = 6;
            // 
            // zuruecksetzenButton
            // 
            this.zuruecksetzenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zuruecksetzenButton.Location = new System.Drawing.Point(449, 13);
            this.zuruecksetzenButton.Name = "zuruecksetzenButton";
            this.zuruecksetzenButton.Size = new System.Drawing.Size(120, 23);
            this.zuruecksetzenButton.TabIndex = 1;
            this.zuruecksetzenButton.Text = "&Zur�cksetzen";
            this.zuruecksetzenButton.UseVisualStyleBackColor = true;
            this.zuruecksetzenButton.Click += new System.EventHandler(this.zuruecksetzenButton_Click);
            // 
            // speichernButton
            // 
            this.speichernButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speichernButton.Location = new System.Drawing.Point(575, 13);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(120, 23);
            this.speichernButton.TabIndex = 0;
            this.speichernButton.Text = "&Speichern";
            this.speichernButton.UseVisualStyleBackColor = true;
            this.speichernButton.Click += new System.EventHandler(this.speichernButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(707, 26);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Ausgabestellen";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.ausgabestelleDataGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(707, 329);
            this.contentPanel.TabIndex = 7;
            // 
            // ausgabestelleDataGridView
            // 
            this.ausgabestelleDataGridView.AutoGenerateColumns = false;
            this.ausgabestelleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ausgabestelleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ausgabestelleIdDataGridViewTextBoxColumn,
            this.kuerzelDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn,
            this.Drucker});
            this.ausgabestelleDataGridView.DataSource = this.ausgabestelleBindingSource;
            this.ausgabestelleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ausgabestelleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ausgabestelleDataGridView.Name = "ausgabestelleDataGridView";
            this.ausgabestelleDataGridView.Size = new System.Drawing.Size(707, 329);
            this.ausgabestelleDataGridView.TabIndex = 2;
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
            // ausgabestelleTableAdapter
            // 
            this.ausgabestelleTableAdapter.ClearBeforeFill = true;
            // 
            // ausgabestelleIdDataGridViewTextBoxColumn
            // 
            this.ausgabestelleIdDataGridViewTextBoxColumn.DataPropertyName = "AusgabestelleId";
            this.ausgabestelleIdDataGridViewTextBoxColumn.HeaderText = "Ausgabestelle-ID";
            this.ausgabestelleIdDataGridViewTextBoxColumn.Name = "ausgabestelleIdDataGridViewTextBoxColumn";
            this.ausgabestelleIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ausgabestelleIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kuerzelDataGridViewTextBoxColumn
            // 
            this.kuerzelDataGridViewTextBoxColumn.DataPropertyName = "Kuerzel";
            this.kuerzelDataGridViewTextBoxColumn.HeaderText = "K�rzel";
            this.kuerzelDataGridViewTextBoxColumn.Name = "kuerzelDataGridViewTextBoxColumn";
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // Drucker
            // 
            this.Drucker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Drucker.DataPropertyName = "Drucker";
            this.Drucker.DataSource = this.festManagerDataSet;
            this.Drucker.DisplayMember = "Printer.Printername";
            this.Drucker.HeaderText = "Drucker";
            this.Drucker.Name = "Drucker";
            this.Drucker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Drucker.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Drucker.ValueMember = "Printer.Printername";
            // 
            // FormAusgabestelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 403);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormAusgabestelle";
            this.Text = "Ausgabestellen";
            this.Load += new System.EventHandler(this.FormAusgabestelle_Load);
            this.operationsPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ausgabestelleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ausgabestelleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FestManager.Data.FestManagerDataSet festManagerDataSet;
        private System.Windows.Forms.BindingSource ausgabestelleBindingSource;
        private FestManager.Data.FestManagerDataSetTableAdapters.AusgabestelleTableAdapter ausgabestelleTableAdapter;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Button zuruecksetzenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView ausgabestelleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ausgabestelleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuerzelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Drucker;
    }
}