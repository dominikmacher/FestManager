namespace FestManager.Forms
{
    partial class FormKellnerabrechnung
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
            this.festManagerDataSet = new FestManager.Data.FestManagerDataSet();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.personalArtikelDataGridView = new System.Windows.Forms.DataGridView();
            this.personalComboBox = new System.Windows.Forms.ComboBox();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personal_VTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.Personal_VTableAdapter();
            this.abrechnungNachTagenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kellnerabrechnungNachTagenTableAdapter = new FestManager.Data.FestManagerDataSetTableAdapters.KellnerabrechnungNachTagenTableAdapter();
            this.BestellungArtikelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summevonSummeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summevonKellnergroschenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalArtikelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrechnungNachTagenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // festManagerDataSet
            // 
            this.festManagerDataSet.DataSetName = "FestManagerDataSet";
            this.festManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(673, 26);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Kellnerabrechnung nach Tagen";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.personalArtikelDataGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(673, 328);
            this.contentPanel.TabIndex = 5;
            // 
            // personalArtikelDataGridView
            // 
            this.personalArtikelDataGridView.AutoGenerateColumns = false;
            this.personalArtikelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalArtikelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BestellungArtikelId,
            this.tagDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.summevonSummeDataGridViewTextBoxColumn,
            this.summevonKellnergroschenDataGridViewTextBoxColumn,
            this.personalIdDataGridViewTextBoxColumn});
            this.personalArtikelDataGridView.DataSource = this.abrechnungNachTagenBindingSource;
            this.personalArtikelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalArtikelDataGridView.Location = new System.Drawing.Point(0, 0);
            this.personalArtikelDataGridView.Name = "personalArtikelDataGridView";
            this.personalArtikelDataGridView.Size = new System.Drawing.Size(673, 328);
            this.personalArtikelDataGridView.TabIndex = 1;
            // 
            // personalComboBox
            // 
            this.personalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.personalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.personalComboBox.DataSource = this.personalBindingSource;
            this.personalComboBox.DisplayMember = "Personal";
            this.personalComboBox.FormattingEnabled = true;
            this.personalComboBox.Location = new System.Drawing.Point(477, 2);
            this.personalComboBox.Name = "personalComboBox";
            this.personalComboBox.Size = new System.Drawing.Size(195, 21);
            this.personalComboBox.TabIndex = 6;
            this.personalComboBox.ValueMember = "PersonalId";
            this.personalComboBox.SelectedIndexChanged += new System.EventHandler(this.personalComboBox_SelectedIndexChanged);
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal_V";
            this.personalBindingSource.DataSource = this.festManagerDataSet;
            // 
            // personal_VTableAdapter
            // 
            this.personal_VTableAdapter.ClearBeforeFill = true;
            // 
            // abrechnungNachTagenBindingSource
            // 
            this.abrechnungNachTagenBindingSource.DataMember = "KellnerabrechnungNachTagen";
            this.abrechnungNachTagenBindingSource.DataSource = this.festManagerDataSet;
            // 
            // kellnerabrechnungNachTagenTableAdapter
            // 
            this.kellnerabrechnungNachTagenTableAdapter.ClearBeforeFill = true;
            // 
            // BestellungArtikelId
            // 
            this.BestellungArtikelId.DataPropertyName = "BestellungArtikelId";
            this.BestellungArtikelId.HeaderText = "BestellungArtikelId";
            this.BestellungArtikelId.Name = "BestellungArtikelId";
            this.BestellungArtikelId.Visible = false;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            this.nachnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            this.vornameDataGridViewTextBoxColumn.Visible = false;
            // 
            // summevonSummeDataGridViewTextBoxColumn
            // 
            this.summevonSummeDataGridViewTextBoxColumn.DataPropertyName = "SummevonSumme";
            this.summevonSummeDataGridViewTextBoxColumn.HeaderText = "Summe von Bestellungen";
            this.summevonSummeDataGridViewTextBoxColumn.Name = "summevonSummeDataGridViewTextBoxColumn";
            this.summevonSummeDataGridViewTextBoxColumn.Width = 200;
            // 
            // summevonKellnergroschenDataGridViewTextBoxColumn
            // 
            this.summevonKellnergroschenDataGridViewTextBoxColumn.DataPropertyName = "SummevonKellnergroschen";
            this.summevonKellnergroschenDataGridViewTextBoxColumn.HeaderText = "Summe von Kellnergroschen";
            this.summevonKellnergroschenDataGridViewTextBoxColumn.Name = "summevonKellnergroschenDataGridViewTextBoxColumn";
            this.summevonKellnergroschenDataGridViewTextBoxColumn.Width = 200;
            // 
            // personalIdDataGridViewTextBoxColumn
            // 
            this.personalIdDataGridViewTextBoxColumn.DataPropertyName = "PersonalId";
            this.personalIdDataGridViewTextBoxColumn.HeaderText = "PersonalId";
            this.personalIdDataGridViewTextBoxColumn.Name = "personalIdDataGridViewTextBoxColumn";
            this.personalIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormKellnerabrechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 354);
            this.Controls.Add(this.personalComboBox);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormKellnerabrechnung";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FormManualStorno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personalArtikelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrechnungNachTagenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FestManager.Data.FestManagerDataSet festManagerDataSet;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView personalArtikelDataGridView;
        private System.Windows.Forms.ComboBox personalComboBox;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private Data.FestManagerDataSetTableAdapters.Personal_VTableAdapter personal_VTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kellnergroschenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource abrechnungNachTagenBindingSource;
        private Data.FestManagerDataSetTableAdapters.KellnerabrechnungNachTagenTableAdapter kellnerabrechnungNachTagenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestellungArtikelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summevonSummeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summevonKellnergroschenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalIdDataGridViewTextBoxColumn;
    }
}