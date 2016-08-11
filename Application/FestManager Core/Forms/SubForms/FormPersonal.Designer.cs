namespace FestManager_Core.Forms.SubForms
{
    partial class FormPersonal
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
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.festManagerDataSet = new FestManager_Core.Data.FestManagerDataSet();
            this.personalTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.PersonalTableAdapter();
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.zuruecksetzenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.personlDataGridView = new System.Windows.Forms.DataGridView();
            this.personalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).BeginInit();
            this.operationsPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personlDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.festManagerDataSet;
            // 
            // festManagerDataSet
            // 
            this.festManagerDataSet.DataSetName = "FestManagerDataSet";
            this.festManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // operationsPanel
            // 
            this.operationsPanel.Controls.Add(this.zuruecksetzenButton);
            this.operationsPanel.Controls.Add(this.speichernButton);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationsPanel.Location = new System.Drawing.Point(0, 329);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(735, 48);
            this.operationsPanel.TabIndex = 10;
            // 
            // zuruecksetzenButton
            // 
            this.zuruecksetzenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zuruecksetzenButton.Location = new System.Drawing.Point(477, 13);
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
            this.speichernButton.Location = new System.Drawing.Point(603, 13);
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
            this.titleLabel.Size = new System.Drawing.Size(735, 26);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Personal";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.personlDataGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(735, 303);
            this.contentPanel.TabIndex = 11;
            // 
            // personlDataGridView
            // 
            this.personlDataGridView.AllowUserToOrderColumns = true;
            this.personlDataGridView.AutoGenerateColumns = false;
            this.personlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personlDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personalIdDataGridViewTextBoxColumn,
            this.personalNrDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.telefonNrDataGridViewTextBoxColumn,
            this.aktivDataGridViewTextBoxColumn});
            this.personlDataGridView.DataSource = this.personalBindingSource;
            this.personlDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personlDataGridView.Location = new System.Drawing.Point(0, 0);
            this.personlDataGridView.Name = "personlDataGridView";
            this.personlDataGridView.Size = new System.Drawing.Size(735, 303);
            this.personlDataGridView.TabIndex = 1;
            // 
            // personalIdDataGridViewTextBoxColumn
            // 
            this.personalIdDataGridViewTextBoxColumn.DataPropertyName = "PersonalId";
            this.personalIdDataGridViewTextBoxColumn.HeaderText = "PersonalId";
            this.personalIdDataGridViewTextBoxColumn.Name = "personalIdDataGridViewTextBoxColumn";
            this.personalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.personalIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // personalNrDataGridViewTextBoxColumn
            // 
            this.personalNrDataGridViewTextBoxColumn.DataPropertyName = "PersonalNr";
            this.personalNrDataGridViewTextBoxColumn.HeaderText = "Personal-Nr.";
            this.personalNrDataGridViewTextBoxColumn.Name = "personalNrDataGridViewTextBoxColumn";
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // telefonNrDataGridViewTextBoxColumn
            // 
            this.telefonNrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonNrDataGridViewTextBoxColumn.DataPropertyName = "TelefonNr";
            this.telefonNrDataGridViewTextBoxColumn.HeaderText = "TelefonNr";
            this.telefonNrDataGridViewTextBoxColumn.Name = "telefonNrDataGridViewTextBoxColumn";
            // 
            // aktivDataGridViewTextBoxColumn
            // 
            this.aktivDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aktivDataGridViewTextBoxColumn.DataPropertyName = "Aktiv";
            this.aktivDataGridViewTextBoxColumn.FalseValue = "N";
            this.aktivDataGridViewTextBoxColumn.HeaderText = "Aktiv";
            this.aktivDataGridViewTextBoxColumn.IndeterminateValue = "N";
            this.aktivDataGridViewTextBoxColumn.Name = "aktivDataGridViewTextBoxColumn";
            this.aktivDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aktivDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aktivDataGridViewTextBoxColumn.TrueValue = "Y";
            this.aktivDataGridViewTextBoxColumn.Width = 56;
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 377);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormPersonal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.FormPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).EndInit();
            this.operationsPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personlDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FestManager_Core.Data.FestManagerDataSet festManagerDataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Button zuruecksetzenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView personlDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivDataGridViewTextBoxColumn;
    }
}