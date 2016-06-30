namespace FestManager_Core.Forms.SubForms
{
    partial class FormAuswertungen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ArtikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FestManagerDataSet = new FestManager_Core.Data.FestManagerDataSet();
            this.ArtikelVerkaufssumme_VBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArtikelTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.ArtikelTableAdapter();
            this.ArtikelVerkaufssumme_VTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.ArtikelVerkaufssumme_VTableAdapter();
            this.PersonalBestellung_VTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.PersonalBestellung_VTableAdapter();
            this.PersonalBestellung_VBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BestellungTableAdapter1 = new FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungTableAdapter();
            this.BestellungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BestellungArtikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selPersonal = new System.Windows.Forms.ComboBox();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArtikelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FestManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtikelVerkaufssumme_VBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalBestellung_VBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestellungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestellungArtikelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // operationsPanel
            // 
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationsPanel.Location = new System.Drawing.Point(0, 320);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(773, 48);
            this.operationsPanel.TabIndex = 6;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(773, 26);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Auswertungen";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.reportViewer1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(773, 294);
            this.contentPanel.TabIndex = 7;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(773, 294);
            this.reportViewer1.TabIndex = 0;
            // 
            // ArtikelBindingSource
            // 
            this.ArtikelBindingSource.DataMember = "Artikel";
            this.ArtikelBindingSource.DataSource = this.FestManagerDataSet;
            // 
            // FestManagerDataSet
            // 
            this.FestManagerDataSet.DataSetName = "FestManagerDataSet";
            this.FestManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ArtikelVerkaufssumme_VBindingSource
            // 
            this.ArtikelVerkaufssumme_VBindingSource.DataMember = "ArtikelVerkaufssumme_V";
            this.ArtikelVerkaufssumme_VBindingSource.DataSource = this.FestManagerDataSet;
            // 
            // ArtikelTableAdapter
            // 
            this.ArtikelTableAdapter.ClearBeforeFill = true;
            // 
            // ArtikelVerkaufssumme_VTableAdapter
            // 
            this.ArtikelVerkaufssumme_VTableAdapter.ClearBeforeFill = true;
            // 
            // PersonalBestellung_VTableAdapter
            // 
            this.PersonalBestellung_VTableAdapter.ClearBeforeFill = true;
            // 
            // PersonalBestellung_VBindingSource
            // 
            this.PersonalBestellung_VBindingSource.DataMember = "PersonalBestellung_V";
            this.PersonalBestellung_VBindingSource.DataSource = this.FestManagerDataSet;
            // 
            // BestellungTableAdapter1
            // 
            this.BestellungTableAdapter1.ClearBeforeFill = true;
            // 
            // BestellungBindingSource
            // 
            this.BestellungBindingSource.DataMember = "Bestellung";
            this.BestellungBindingSource.DataSource = this.FestManagerDataSet;
            // 
            // BestellungArtikelBindingSource
            // 
            this.BestellungArtikelBindingSource.DataMember = "BestellungArtikel";
            this.BestellungArtikelBindingSource.DataSource = this.FestManagerDataSet;
            // 
            // selPersonal
            // 
            this.selPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selPersonal.FormattingEnabled = true;
            this.selPersonal.Location = new System.Drawing.Point(574, 2);
            this.selPersonal.Name = "selPersonal";
            this.selPersonal.Size = new System.Drawing.Size(199, 21);
            this.selPersonal.TabIndex = 8;
            // 
            // FormAuswertungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 368);
            this.Controls.Add(this.selPersonal);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormAuswertungen";
            this.Text = "FormAuswertungen";
            this.Load += new System.EventHandler(this.FormAuswertungen_Load);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ArtikelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FestManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArtikelVerkaufssumme_VBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalBestellung_VBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestellungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BestellungArtikelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FestManager_Core.Data.FestManagerDataSet FestManagerDataSet;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.BindingSource ArtikelBindingSource;
        private System.Windows.Forms.BindingSource ArtikelVerkaufssumme_VBindingSource;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.ArtikelTableAdapter ArtikelTableAdapter;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.ArtikelVerkaufssumme_VTableAdapter ArtikelVerkaufssumme_VTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.PersonalBestellung_VTableAdapter PersonalBestellung_VTableAdapter;
        private System.Windows.Forms.BindingSource PersonalBestellung_VBindingSource;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungTableAdapter BestellungTableAdapter1;
        private System.Windows.Forms.BindingSource BestellungBindingSource;
        private System.Windows.Forms.BindingSource BestellungArtikelBindingSource;
        private System.Windows.Forms.ComboBox selPersonal;

    }
}