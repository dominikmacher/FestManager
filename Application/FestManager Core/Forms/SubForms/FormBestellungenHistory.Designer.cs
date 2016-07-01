namespace FestManager_Core.Forms.SubForms
{
    partial class FormBestellungenHistory
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBestellungenHistory));
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.bestellungenHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.BestellungId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeitpunktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gesamtpreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestellungenHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.festManagerDataSet = new FestManager_Core.Data.FestManagerDataSet();
            this.bestellungenHistory_VTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungenHistory_VTableAdapter();
            this.bestellungenHistoryDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.personalNrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestellungenHistoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.buttonCancelBestellung = new System.Windows.Forms.Button();
            this.buttonPrintBestellung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBestellDetails = new System.Windows.Forms.Label();
            this.bestellungenHistoryDetails_VTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungenHistoryDetails_VTableAdapter();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenHistoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenHistoryDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenHistoryDetailsBindingSource)).BeginInit();
            this.operationsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(681, 26);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Liste aller Bestellungen";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.bestellungenHistoryDataGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(681, 145);
            this.contentPanel.TabIndex = 5;
            // 
            // bestellungenHistoryDataGridView
            // 
            this.bestellungenHistoryDataGridView.AutoGenerateColumns = false;
            this.bestellungenHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bestellungenHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BestellungId,
            this.personalNrDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.zeitpunktDataGridViewTextBoxColumn,
            this.gesamtpreisDataGridViewTextBoxColumn});
            this.bestellungenHistoryDataGridView.DataSource = this.bestellungenHistoryBindingSource;
            this.bestellungenHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bestellungenHistoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.bestellungenHistoryDataGridView.Name = "bestellungenHistoryDataGridView";
            this.bestellungenHistoryDataGridView.Size = new System.Drawing.Size(681, 145);
            this.bestellungenHistoryDataGridView.TabIndex = 1;
            this.bestellungenHistoryDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bestellungenHistoryDataGridView_CellDoubleClick);
            // 
            // BestellungId
            // 
            this.BestellungId.DataPropertyName = "BestellungId";
            this.BestellungId.HeaderText = "Bestellungs-Nr.";
            this.BestellungId.Name = "BestellungId";
            // 
            // personalNrDataGridViewTextBoxColumn
            // 
            this.personalNrDataGridViewTextBoxColumn.DataPropertyName = "PersonalNr";
            this.personalNrDataGridViewTextBoxColumn.HeaderText = "Personal-Nr.";
            this.personalNrDataGridViewTextBoxColumn.Name = "personalNrDataGridViewTextBoxColumn";
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            this.nachnameDataGridViewTextBoxColumn.Width = 115;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // zeitpunktDataGridViewTextBoxColumn
            // 
            this.zeitpunktDataGridViewTextBoxColumn.DataPropertyName = "Zeitpunkt";
            this.zeitpunktDataGridViewTextBoxColumn.HeaderText = "Zeitpunkt";
            this.zeitpunktDataGridViewTextBoxColumn.Name = "zeitpunktDataGridViewTextBoxColumn";
            // 
            // gesamtpreisDataGridViewTextBoxColumn
            // 
            this.gesamtpreisDataGridViewTextBoxColumn.DataPropertyName = "Gesamtpreis";
            this.gesamtpreisDataGridViewTextBoxColumn.HeaderText = "Gesamtpreis";
            this.gesamtpreisDataGridViewTextBoxColumn.Name = "gesamtpreisDataGridViewTextBoxColumn";
            // 
            // bestellungenHistoryBindingSource
            // 
            this.bestellungenHistoryBindingSource.DataMember = "BestellungenHistory_V";
            this.bestellungenHistoryBindingSource.DataSource = this.festManagerDataSet;
            // 
            // festManagerDataSet
            // 
            this.festManagerDataSet.DataSetName = "FestManagerDataSet";
            this.festManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bestellungenHistory_VTableAdapter
            // 
            this.bestellungenHistory_VTableAdapter.ClearBeforeFill = true;
            // 
            // bestellungenHistoryDetailsDataGridView
            // 
            this.bestellungenHistoryDetailsDataGridView.AutoGenerateColumns = false;
            this.bestellungenHistoryDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bestellungenHistoryDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personalNrDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bestellungenHistoryDetailsDataGridView.DataSource = this.bestellungenHistoryDetailsBindingSource;
            this.bestellungenHistoryDetailsDataGridView.Location = new System.Drawing.Point(0, 26);
            this.bestellungenHistoryDetailsDataGridView.Name = "bestellungenHistoryDetailsDataGridView";
            this.bestellungenHistoryDetailsDataGridView.Size = new System.Drawing.Size(566, 157);
            this.bestellungenHistoryDetailsDataGridView.TabIndex = 0;
            this.bestellungenHistoryDetailsDataGridView.Visible = false;
            // 
            // personalNrDataGridViewTextBoxColumn1
            // 
            this.personalNrDataGridViewTextBoxColumn1.DataPropertyName = "PersonalNr";
            this.personalNrDataGridViewTextBoxColumn1.HeaderText = "PersonalNr";
            this.personalNrDataGridViewTextBoxColumn1.Name = "personalNrDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Bezeichnung";
            this.dataGridViewTextBoxColumn1.HeaderText = "Bezeichnung";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Einzelpreis";
            this.dataGridViewTextBoxColumn2.HeaderText = "Einzelpreis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Menge";
            this.dataGridViewTextBoxColumn3.HeaderText = "Menge";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BestellungArtikel_Gesamtpreis";
            this.dataGridViewTextBoxColumn4.HeaderText = "Artikel-Gesamtpreis";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bestellungenHistoryDetailsBindingSource
            // 
            this.bestellungenHistoryDetailsBindingSource.DataMember = "BestellungenHistoryDetails_V";
            this.bestellungenHistoryDetailsBindingSource.DataSource = this.festManagerDataSet;
            // 
            // operationsPanel
            // 
            this.operationsPanel.Controls.Add(this.buttonCancelBestellung);
            this.operationsPanel.Controls.Add(this.buttonPrintBestellung);
            this.operationsPanel.Controls.Add(this.label1);
            this.operationsPanel.Controls.Add(this.lblBestellDetails);
            this.operationsPanel.Controls.Add(this.bestellungenHistoryDetailsDataGridView);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationsPanel.Location = new System.Drawing.Point(0, 171);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(681, 183);
            this.operationsPanel.TabIndex = 4;
            // 
            // buttonCancelBestellung
            // 
            this.buttonCancelBestellung.Enabled = false;
            this.buttonCancelBestellung.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCancelBestellung.Location = new System.Drawing.Point(572, 118);
            this.buttonCancelBestellung.Name = "buttonCancelBestellung";
            this.buttonCancelBestellung.Size = new System.Drawing.Size(86, 53);
            this.buttonCancelBestellung.TabIndex = 4;
            this.buttonCancelBestellung.Text = "Bestellung nachträglich stornieren";
            this.buttonCancelBestellung.UseVisualStyleBackColor = true;
            this.buttonCancelBestellung.Visible = false;
            // 
            // buttonPrintBestellung
            // 
            this.buttonPrintBestellung.Location = new System.Drawing.Point(572, 36);
            this.buttonPrintBestellung.Name = "buttonPrintBestellung";
            this.buttonPrintBestellung.Size = new System.Drawing.Size(86, 62);
            this.buttonPrintBestellung.TabIndex = 3;
            this.buttonPrintBestellung.Text = "Bestellung auf Kassadrucker drucken";
            this.buttonPrintBestellung.UseVisualStyleBackColor = true;
            this.buttonPrintBestellung.Visible = false;
            this.buttonPrintBestellung.Click += new System.EventHandler(this.buttonPrintBestellung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "(mittels Doppelklick auf die obere Liste erhalten Sie die Details)";
            // 
            // lblBestellDetails
            // 
            this.lblBestellDetails.AutoSize = true;
            this.lblBestellDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestellDetails.Location = new System.Drawing.Point(1, 5);
            this.lblBestellDetails.Name = "lblBestellDetails";
            this.lblBestellDetails.Size = new System.Drawing.Size(177, 18);
            this.lblBestellDetails.TabIndex = 1;
            this.lblBestellDetails.Text = "Bestell-Details für .....:";
            // 
            // bestellungenHistoryDetails_VTableAdapter
            // 
            this.bestellungenHistoryDetails_VTableAdapter.ClearBeforeFill = true;
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
            // printDialog1
            // 
            this.printDialog1.AllowPrintToFile = false;
            this.printDialog1.Document = this.printDocument;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog";
            this.printPreviewDialog1.Visible = false;
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshList.Location = new System.Drawing.Point(528, 2);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(129, 23);
            this.buttonRefreshList.TabIndex = 6;
            this.buttonRefreshList.Text = "Liste aktualisieren";
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // FormBestellungenHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 354);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormBestellungenHistory";
            this.Text = "Bestellungen History";
            this.Load += new System.EventHandler(this.FormBestellungenHistory_Load);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenHistoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenHistoryDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestellungenHistoryDetailsBindingSource)).EndInit();
            this.operationsPanel.ResumeLayout(false);
            this.operationsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView bestellungenHistoryDataGridView;
        private FestManager_Core.Data.FestManagerDataSet festManagerDataSet;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungenHistory_VTableAdapter bestellungenHistory_VTableAdapter;
        private System.Windows.Forms.DataGridView bestellungenHistoryDetailsDataGridView;
        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Label lblBestellDetails;
        private System.Windows.Forms.Label label1;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.BestellungenHistoryDetails_VTableAdapter bestellungenHistoryDetails_VTableAdapter;
        private System.Windows.Forms.BindingSource bestellungenHistoryDetailsBindingSource;
        private System.Windows.Forms.BindingSource bestellungenHistoryBindingSource;
        private System.Windows.Forms.Button buttonCancelBestellung;
        private System.Windows.Forms.Button buttonPrintBestellung;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button buttonRefreshList;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestellungId;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeitpunktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gesamtpreisDataGridViewTextBoxColumn;
    }
}