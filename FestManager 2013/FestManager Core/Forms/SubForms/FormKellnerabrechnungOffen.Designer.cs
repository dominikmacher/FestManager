namespace FestManager_Core.Forms.SubForms
{
    partial class FormKellnerabrechnungOffen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKellnerabrechnungOffen));
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.offeneAbrechnungenDataGridView = new System.Windows.Forms.DataGridView();
            this.personalNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offeneKellnerabrechnungenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.festManagerDataSet = new FestManager_Core.Data.FestManagerDataSet();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.kellnerabrechnung_OffenTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.Kellnerabrechnung_OffenTableAdapter();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offeneAbrechnungenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offeneKellnerabrechnungenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).BeginInit();
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
            this.titleLabel.Text = "Offene Kellnerabrechnungen";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.offeneAbrechnungenDataGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(681, 328);
            this.contentPanel.TabIndex = 5;
            // 
            // offeneAbrechnungenDataGridView
            // 
            this.offeneAbrechnungenDataGridView.AutoGenerateColumns = false;
            this.offeneAbrechnungenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offeneAbrechnungenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personalNrDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn});
            this.offeneAbrechnungenDataGridView.DataSource = this.offeneKellnerabrechnungenBindingSource;
            this.offeneAbrechnungenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offeneAbrechnungenDataGridView.Location = new System.Drawing.Point(0, 0);
            this.offeneAbrechnungenDataGridView.Name = "offeneAbrechnungenDataGridView";
            this.offeneAbrechnungenDataGridView.Size = new System.Drawing.Size(681, 328);
            this.offeneAbrechnungenDataGridView.TabIndex = 1;
            // 
            // personalNrDataGridViewTextBoxColumn
            // 
            this.personalNrDataGridViewTextBoxColumn.DataPropertyName = "PersonalNr";
            this.personalNrDataGridViewTextBoxColumn.HeaderText = "PersonalNr";
            this.personalNrDataGridViewTextBoxColumn.Name = "personalNrDataGridViewTextBoxColumn";
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // offeneKellnerabrechnungenBindingSource
            // 
            this.offeneKellnerabrechnungenBindingSource.DataMember = "Kellnerabrechnung_Offen";
            this.offeneKellnerabrechnungenBindingSource.DataSource = this.festManagerDataSet;
            // 
            // festManagerDataSet
            // 
            this.festManagerDataSet.DataSetName = "FestManagerDataSet";
            this.festManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printDialog
            // 
            this.printDialog.AllowPrintToFile = false;
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowPrintToFile = false;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
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
            // kellnerabrechnung_OffenTableAdapter
            // 
            this.kellnerabrechnung_OffenTableAdapter.ClearBeforeFill = true;
            // 
            // FormKellnerabrechnungOffen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 354);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormKellnerabrechnungOffen";
            this.Text = "Kellnerabrechnung Offene Posten";
            this.Load += new System.EventHandler(this.FormKellnerabrechnungOffen_Load);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.offeneAbrechnungenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offeneKellnerabrechnungenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView offeneAbrechnungenDataGridView;
        private FestManager_Core.Data.FestManagerDataSet festManagerDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn einzelpreisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestellungArtikelGesamtpreisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestellungGesamtpreisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn einzelpreisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestellungArtikelGesamtpreisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestellungGesamtpreisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource offeneKellnerabrechnungenBindingSource;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button buttonRefreshList;
        private Data.FestManagerDataSetTableAdapters.Kellnerabrechnung_OffenTableAdapter kellnerabrechnung_OffenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
    }
}