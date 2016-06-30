namespace FestManager_Core.Forms.SubForms
{
    partial class FormManualStorno
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelArtikelBestellungDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStornoArtikelBestellung = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.personalArtikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalComboBox = new System.Windows.Forms.ComboBox();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personal_VTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.Personal_VTableAdapter();
            this.personalArtikelTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.PersonalArtikelTableAdapter();
            this.gesamtpreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.einzelpreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mengeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeitpunktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestellungIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestellungArtikelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalArtikelDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).BeginInit();
            this.operationsPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personalArtikelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalArtikelDataGridView)).BeginInit();
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
            this.titleLabel.Text = "Manuelles Stornieren von Artikel";
            // 
            // operationsPanel
            // 
            this.operationsPanel.Controls.Add(this.label2);
            this.operationsPanel.Controls.Add(this.labelArtikelBestellungDetails);
            this.operationsPanel.Controls.Add(this.label1);
            this.operationsPanel.Controls.Add(this.btnStornoArtikelBestellung);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationsPanel.Location = new System.Drawing.Point(0, 286);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(673, 68);
            this.operationsPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(Auswählen mittels Doppelklick)";
            // 
            // labelArtikelBestellungDetails
            // 
            this.labelArtikelBestellungDetails.AutoSize = true;
            this.labelArtikelBestellungDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtikelBestellungDetails.Location = new System.Drawing.Point(83, 17);
            this.labelArtikelBestellungDetails.Name = "labelArtikelBestellungDetails";
            this.labelArtikelBestellungDetails.Size = new System.Drawing.Size(0, 13);
            this.labelArtikelBestellungDetails.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ausgewählt:";
            // 
            // btnStornoArtikelBestellung
            // 
            this.btnStornoArtikelBestellung.Location = new System.Drawing.Point(586, 12);
            this.btnStornoArtikelBestellung.Name = "btnStornoArtikelBestellung";
            this.btnStornoArtikelBestellung.Size = new System.Drawing.Size(75, 23);
            this.btnStornoArtikelBestellung.TabIndex = 0;
            this.btnStornoArtikelBestellung.Text = "Stornieren";
            this.btnStornoArtikelBestellung.UseVisualStyleBackColor = true;
            this.btnStornoArtikelBestellung.Visible = false;
            this.btnStornoArtikelBestellung.Click += new System.EventHandler(this.btnStornoArtikelBestellung_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.personalArtikelDataGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(673, 260);
            this.contentPanel.TabIndex = 5;
            // 
            // personalArtikelBindingSource
            // 
            this.personalArtikelBindingSource.DataMember = "PersonalArtikel";
            this.personalArtikelBindingSource.DataSource = this.festManagerDataSet;
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
            // personalArtikelTableAdapter
            // 
            this.personalArtikelTableAdapter.ClearBeforeFill = true;
            // 
            // gesamtpreisDataGridViewTextBoxColumn
            // 
            this.gesamtpreisDataGridViewTextBoxColumn.DataPropertyName = "Gesamtpreis";
            this.gesamtpreisDataGridViewTextBoxColumn.HeaderText = "Gesamtpreis";
            this.gesamtpreisDataGridViewTextBoxColumn.Name = "gesamtpreisDataGridViewTextBoxColumn";
            // 
            // einzelpreisDataGridViewTextBoxColumn
            // 
            this.einzelpreisDataGridViewTextBoxColumn.DataPropertyName = "Einzelpreis";
            this.einzelpreisDataGridViewTextBoxColumn.HeaderText = "Einzelpreis";
            this.einzelpreisDataGridViewTextBoxColumn.Name = "einzelpreisDataGridViewTextBoxColumn";
            // 
            // mengeDataGridViewTextBoxColumn
            // 
            this.mengeDataGridViewTextBoxColumn.DataPropertyName = "Menge";
            this.mengeDataGridViewTextBoxColumn.HeaderText = "Menge";
            this.mengeDataGridViewTextBoxColumn.Name = "mengeDataGridViewTextBoxColumn";
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Artikel";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // zeitpunktDataGridViewTextBoxColumn
            // 
            this.zeitpunktDataGridViewTextBoxColumn.DataPropertyName = "Zeitpunkt";
            this.zeitpunktDataGridViewTextBoxColumn.HeaderText = "Zeitpunkt";
            this.zeitpunktDataGridViewTextBoxColumn.Name = "zeitpunktDataGridViewTextBoxColumn";
            // 
            // bestellungIdDataGridViewTextBoxColumn
            // 
            this.bestellungIdDataGridViewTextBoxColumn.DataPropertyName = "BestellungId";
            this.bestellungIdDataGridViewTextBoxColumn.HeaderText = "Bestell-Nr.";
            this.bestellungIdDataGridViewTextBoxColumn.Name = "bestellungIdDataGridViewTextBoxColumn";
            // 
            // BestellungArtikelId
            // 
            this.BestellungArtikelId.DataPropertyName = "BestellungArtikelId";
            this.BestellungArtikelId.HeaderText = "BestellungArtikelId";
            this.BestellungArtikelId.Name = "BestellungArtikelId";
            this.BestellungArtikelId.Visible = false;
            // 
            // personalArtikelDataGridView
            // 
            this.personalArtikelDataGridView.AutoGenerateColumns = false;
            this.personalArtikelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalArtikelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BestellungArtikelId,
            this.bestellungIdDataGridViewTextBoxColumn,
            this.zeitpunktDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn,
            this.mengeDataGridViewTextBoxColumn,
            this.einzelpreisDataGridViewTextBoxColumn,
            this.gesamtpreisDataGridViewTextBoxColumn});
            this.personalArtikelDataGridView.DataSource = this.personalArtikelBindingSource;
            this.personalArtikelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personalArtikelDataGridView.Location = new System.Drawing.Point(0, 0);
            this.personalArtikelDataGridView.Name = "personalArtikelDataGridView";
            this.personalArtikelDataGridView.Size = new System.Drawing.Size(673, 260);
            this.personalArtikelDataGridView.TabIndex = 1;
            this.personalArtikelDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personalArtikelDataGridView_CellDoubleClick);
            // 
            // FormManualStorno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 354);
            this.Controls.Add(this.personalComboBox);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormManualStorno";
            this.Text = "Stornieren";
            this.Load += new System.EventHandler(this.FormManualStorno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).EndInit();
            this.operationsPanel.ResumeLayout(false);
            this.operationsPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personalArtikelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalArtikelDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FestManager_Core.Data.FestManagerDataSet festManagerDataSet;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStornoArtikelBestellung;
        private System.Windows.Forms.BindingSource personalArtikelBindingSource;
        private System.Windows.Forms.ComboBox personalComboBox;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.Personal_VTableAdapter personal_VTableAdapter;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.PersonalArtikelTableAdapter personalArtikelTableAdapter;
        private System.Windows.Forms.Label labelArtikelBestellungDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView personalArtikelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestellungArtikelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestellungIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeitpunktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn einzelpreisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gesamtpreisDataGridViewTextBoxColumn;
    }
}