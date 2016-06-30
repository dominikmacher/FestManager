namespace FestManager.Forms
{
    partial class FormEinheit
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
            this.einheitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.festManagerDataSet = new FestManager.Data.FestManagerDataSet();
            this.einheitTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.EinheitTableAdapter();
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.zuruecksetzenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.einheitDataGridView = new System.Windows.Forms.DataGridView();
            this.einheitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuerzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.einheitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).BeginInit();
            this.operationsPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.einheitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // einheitBindingSource
            // 
            this.einheitBindingSource.DataMember = "Einheit";
            this.einheitBindingSource.DataSource = this.festManagerDataSet;
            // 
            // festManagerDataSet
            // 
            this.festManagerDataSet.DataSetName = "FestManagerDataSet";
            this.festManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // einheitTableAdapter
            // 
            this.einheitTableAdapter.ClearBeforeFill = true;
            // 
            // operationsPanel
            // 
            this.operationsPanel.Controls.Add(this.zuruecksetzenButton);
            this.operationsPanel.Controls.Add(this.speichernButton);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationsPanel.Location = new System.Drawing.Point(0, 325);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(666, 48);
            this.operationsPanel.TabIndex = 8;
            // 
            // zuruecksetzenButton
            // 
            this.zuruecksetzenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zuruecksetzenButton.Location = new System.Drawing.Point(408, 13);
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
            this.speichernButton.Location = new System.Drawing.Point(534, 13);
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
            this.titleLabel.Size = new System.Drawing.Size(666, 26);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Einheiten";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.einheitDataGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(666, 299);
            this.contentPanel.TabIndex = 9;
            // 
            // einheitDataGridView
            // 
            this.einheitDataGridView.AutoGenerateColumns = false;
            this.einheitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.einheitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.einheitIdDataGridViewTextBoxColumn,
            this.kuerzelDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn});
            this.einheitDataGridView.DataSource = this.einheitBindingSource;
            this.einheitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.einheitDataGridView.Location = new System.Drawing.Point(0, 0);
            this.einheitDataGridView.Name = "einheitDataGridView";
            this.einheitDataGridView.Size = new System.Drawing.Size(666, 299);
            this.einheitDataGridView.TabIndex = 1;
            // 
            // einheitIdDataGridViewTextBoxColumn
            // 
            this.einheitIdDataGridViewTextBoxColumn.DataPropertyName = "EinheitId";
            this.einheitIdDataGridViewTextBoxColumn.HeaderText = "Einheit-ID";
            this.einheitIdDataGridViewTextBoxColumn.Name = "einheitIdDataGridViewTextBoxColumn";
            this.einheitIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.einheitIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kuerzelDataGridViewTextBoxColumn
            // 
            this.kuerzelDataGridViewTextBoxColumn.DataPropertyName = "Kuerzel";
            this.kuerzelDataGridViewTextBoxColumn.HeaderText = "Kürzel";
            this.kuerzelDataGridViewTextBoxColumn.Name = "kuerzelDataGridViewTextBoxColumn";
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // FormEinheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 373);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormEinheit";
            this.Text = "Einheiten";
            this.Load += new System.EventHandler(this.FormEinheit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.einheitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).EndInit();
            this.operationsPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.einheitDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FestManager.Data.FestManagerDataSet festManagerDataSet;
        private System.Windows.Forms.BindingSource einheitBindingSource;
        private FestManager.Data.FestManagerDataSetTableAdapters.EinheitTableAdapter einheitTableAdapter;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Button zuruecksetzenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView einheitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn einheitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuerzelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
    }
}