namespace FestManager_Core.Forms.SubForms
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
            this.festManagerDataSet = new FestManager_Core.Data.FestManagerDataSet();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gesamtSummeClosedKellnergroschenTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gesamtSummeClosedBestellungenTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.abgeschlosseneAbrechnungenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abrechnungNachTagenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCloseOrders = new System.Windows.Forms.Button();
            this.gesamtSummeKellnergroschenTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gesamtSummeBestellungenTextbox = new System.Windows.Forms.TextBox();
            this.gesamtpreisLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.offeneAbrechnungenDataGridView = new System.Windows.Forms.DataGridView();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnzahlBestellungen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnzahlArtikel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summevonSummeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summevonKellnergroschenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestellungArtikelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalComboBox = new System.Windows.Forms.ComboBox();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personal_VTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.Personal_VTableAdapter();
            this.kellnerabrechnungNachTagenOffenTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.KellnerabrechnungNachTagenOffenTableAdapter();
            this.abrechnungNachTagenAbgeschlossenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kellnerabrechnungNachTagenAbgeschlossenTableAdapter = new FestManager_Core.Data.FestManagerDataSetTableAdapters.KellnerabrechnungNachTagenAbgeschlossenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abgeschlosseneAbrechnungenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrechnungNachTagenBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offeneAbrechnungenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrechnungNachTagenAbgeschlossenBindingSource)).BeginInit();
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
            this.titleLabel.Size = new System.Drawing.Size(720, 26);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Kellnerabrechnung nach Tagen";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.panel3);
            this.contentPanel.Controls.Add(this.panel1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(720, 445);
            this.contentPanel.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.gesamtSummeClosedKellnergroschenTextbox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.gesamtSummeClosedBestellungenTextbox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.abgeschlosseneAbrechnungenDataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 302);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 143);
            this.panel3.TabIndex = 1;
            // 
            // gesamtSummeClosedKellnergroschenTextbox
            // 
            this.gesamtSummeClosedKellnergroschenTextbox.Location = new System.Drawing.Point(665, 8);
            this.gesamtSummeClosedKellnergroschenTextbox.Name = "gesamtSummeClosedKellnergroschenTextbox";
            this.gesamtSummeClosedKellnergroschenTextbox.Size = new System.Drawing.Size(47, 20);
            this.gesamtSummeClosedKellnergroschenTextbox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Gesamtsumme Kellnergroschen:";
            // 
            // gesamtSummeClosedBestellungenTextbox
            // 
            this.gesamtSummeClosedBestellungenTextbox.Location = new System.Drawing.Point(430, 8);
            this.gesamtSummeClosedBestellungenTextbox.Name = "gesamtSummeClosedBestellungenTextbox";
            this.gesamtSummeClosedBestellungenTextbox.Size = new System.Drawing.Size(43, 20);
            this.gesamtSummeClosedBestellungenTextbox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Gesamtsumme Bestellungen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Abgeschlossene Abrechnungen:";
            // 
            // abgeschlosseneAbrechnungenDataGridView
            // 
            this.abgeschlosseneAbrechnungenDataGridView.AutoGenerateColumns = false;
            this.abgeschlosseneAbrechnungenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abgeschlosseneAbrechnungenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.abgeschlosseneAbrechnungenDataGridView.DataSource = this.abrechnungNachTagenBindingSource;
            this.abgeschlosseneAbrechnungenDataGridView.Location = new System.Drawing.Point(0, 33);
            this.abgeschlosseneAbrechnungenDataGridView.Name = "abgeschlosseneAbrechnungenDataGridView";
            this.abgeschlosseneAbrechnungenDataGridView.Size = new System.Drawing.Size(712, 107);
            this.abgeschlosseneAbrechnungenDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nachname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nachname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vorname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vorname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AnzahlBestellungen";
            this.dataGridViewTextBoxColumn4.HeaderText = "Anzahl Bestellungen";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AnzahlArtikel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Anzahl Artikel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SummevonSumme";
            this.dataGridViewTextBoxColumn6.HeaderText = "Summe von Bestellungen";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 160;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SummevonKellnergroschen";
            this.dataGridViewTextBoxColumn7.HeaderText = "Summe von Kellnergroschen";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 170;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BestellungArtikelId";
            this.dataGridViewTextBoxColumn8.HeaderText = "BestellungArtikelId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // abrechnungNachTagenBindingSource
            // 
            this.abrechnungNachTagenBindingSource.DataMember = "KellnerabrechnungNachTagenOffen";
            this.abrechnungNachTagenBindingSource.DataSource = this.festManagerDataSet;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.buttonCloseOrders);
            this.panel1.Controls.Add(this.gesamtSummeKellnergroschenTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gesamtSummeBestellungenTextbox);
            this.panel1.Controls.Add(this.gesamtpreisLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.offeneAbrechnungenDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 445);
            this.panel1.TabIndex = 0;
            // 
            // buttonCloseOrders
            // 
            this.buttonCloseOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseOrders.Location = new System.Drawing.Point(268, 211);
            this.buttonCloseOrders.Name = "buttonCloseOrders";
            this.buttonCloseOrders.Size = new System.Drawing.Size(219, 23);
            this.buttonCloseOrders.TabIndex = 16;
            this.buttonCloseOrders.Text = "Offene Abrechnungen abschlieﬂen";
            this.buttonCloseOrders.UseVisualStyleBackColor = true;
            this.buttonCloseOrders.Click += new System.EventHandler(this.buttonCloseOrders_Click);
            // 
            // gesamtSummeKellnergroschenTextbox
            // 
            this.gesamtSummeKellnergroschenTextbox.Location = new System.Drawing.Point(665, 9);
            this.gesamtSummeKellnergroschenTextbox.Name = "gesamtSummeKellnergroschenTextbox";
            this.gesamtSummeKellnergroschenTextbox.Size = new System.Drawing.Size(47, 20);
            this.gesamtSummeKellnergroschenTextbox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gesamtsumme Kellnergroschen:";
            // 
            // gesamtSummeBestellungenTextbox
            // 
            this.gesamtSummeBestellungenTextbox.Location = new System.Drawing.Point(430, 9);
            this.gesamtSummeBestellungenTextbox.Name = "gesamtSummeBestellungenTextbox";
            this.gesamtSummeBestellungenTextbox.Size = new System.Drawing.Size(43, 20);
            this.gesamtSummeBestellungenTextbox.TabIndex = 13;
            // 
            // gesamtpreisLabel
            // 
            this.gesamtpreisLabel.AutoSize = true;
            this.gesamtpreisLabel.Location = new System.Drawing.Point(283, 12);
            this.gesamtpreisLabel.Name = "gesamtpreisLabel";
            this.gesamtpreisLabel.Size = new System.Drawing.Size(143, 13);
            this.gesamtpreisLabel.TabIndex = 12;
            this.gesamtpreisLabel.Text = "Gesamtsumme Bestellungen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Offene Abrechnungen:";
            // 
            // offeneAbrechnungenDataGridView
            // 
            this.offeneAbrechnungenDataGridView.AutoGenerateColumns = false;
            this.offeneAbrechnungenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offeneAbrechnungenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.AnzahlBestellungen,
            this.AnzahlArtikel,
            this.summevonSummeDataGridViewTextBoxColumn,
            this.summevonKellnergroschenDataGridViewTextBoxColumn,
            this.BestellungArtikelId});
            this.offeneAbrechnungenDataGridView.DataSource = this.abrechnungNachTagenBindingSource;
            this.offeneAbrechnungenDataGridView.Location = new System.Drawing.Point(0, 30);
            this.offeneAbrechnungenDataGridView.Name = "offeneAbrechnungenDataGridView";
            this.offeneAbrechnungenDataGridView.Size = new System.Drawing.Size(712, 170);
            this.offeneAbrechnungenDataGridView.TabIndex = 3;
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
            // AnzahlBestellungen
            // 
            this.AnzahlBestellungen.DataPropertyName = "AnzahlBestellungen";
            this.AnzahlBestellungen.HeaderText = "Anzahl Bestellungen";
            this.AnzahlBestellungen.Name = "AnzahlBestellungen";
            this.AnzahlBestellungen.Width = 130;
            // 
            // AnzahlArtikel
            // 
            this.AnzahlArtikel.DataPropertyName = "AnzahlArtikel";
            this.AnzahlArtikel.HeaderText = "Anzahl Artikel";
            this.AnzahlArtikel.Name = "AnzahlArtikel";
            // 
            // summevonSummeDataGridViewTextBoxColumn
            // 
            this.summevonSummeDataGridViewTextBoxColumn.DataPropertyName = "SummevonSumme";
            this.summevonSummeDataGridViewTextBoxColumn.HeaderText = "Summe von Bestellungen";
            this.summevonSummeDataGridViewTextBoxColumn.Name = "summevonSummeDataGridViewTextBoxColumn";
            this.summevonSummeDataGridViewTextBoxColumn.Width = 160;
            // 
            // summevonKellnergroschenDataGridViewTextBoxColumn
            // 
            this.summevonKellnergroschenDataGridViewTextBoxColumn.DataPropertyName = "SummevonKellnergroschen";
            this.summevonKellnergroschenDataGridViewTextBoxColumn.HeaderText = "Summe von Kellnergroschen";
            this.summevonKellnergroschenDataGridViewTextBoxColumn.Name = "summevonKellnergroschenDataGridViewTextBoxColumn";
            this.summevonKellnergroschenDataGridViewTextBoxColumn.Width = 170;
            // 
            // BestellungArtikelId
            // 
            this.BestellungArtikelId.DataPropertyName = "BestellungArtikelId";
            this.BestellungArtikelId.HeaderText = "BestellungArtikelId";
            this.BestellungArtikelId.Name = "BestellungArtikelId";
            this.BestellungArtikelId.Visible = false;
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
            // kellnerabrechnungNachTagenOffenTableAdapter
            // 
            this.kellnerabrechnungNachTagenOffenTableAdapter.ClearBeforeFill = true;
            // 
            // abrechnungNachTagenAbgeschlossenBindingSource
            // 
            this.abrechnungNachTagenAbgeschlossenBindingSource.DataMember = "KellnerabrechnungNachTagenAbgeschlossen";
            this.abrechnungNachTagenAbgeschlossenBindingSource.DataSource = this.festManagerDataSet;
            // 
            // kellnerabrechnungNachTagenAbgeschlossenTableAdapter
            // 
            this.kellnerabrechnungNachTagenAbgeschlossenTableAdapter.ClearBeforeFill = true;
            // 
            // FormKellnerabrechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 471);
            this.Controls.Add(this.personalComboBox);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormKellnerabrechnung";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FormKellnerabrechnung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.festManagerDataSet)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abgeschlosseneAbrechnungenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrechnungNachTagenBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offeneAbrechnungenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abrechnungNachTagenAbgeschlossenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FestManager_Core.Data.FestManagerDataSet festManagerDataSet;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.ComboBox personalComboBox;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private FestManager_Core.Data.FestManagerDataSetTableAdapters.Personal_VTableAdapter personal_VTableAdapter;
        private System.Windows.Forms.BindingSource abrechnungNachTagenBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView offeneAbrechnungenDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView abgeschlosseneAbrechnungenDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gesamtSummeKellnergroschenTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gesamtSummeBestellungenTextbox;
        private System.Windows.Forms.Label gesamtpreisLabel;
        private System.Windows.Forms.TextBox gesamtSummeClosedKellnergroschenTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gesamtSummeClosedBestellungenTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCloseOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnzahlBestellungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnzahlArtikel;
        private System.Windows.Forms.DataGridViewTextBoxColumn summevonSummeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summevonKellnergroschenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestellungArtikelId;
        private Data.FestManagerDataSetTableAdapters.KellnerabrechnungNachTagenOffenTableAdapter kellnerabrechnungNachTagenOffenTableAdapter;
        private System.Windows.Forms.BindingSource abrechnungNachTagenAbgeschlossenBindingSource;
        private Data.FestManagerDataSetTableAdapters.KellnerabrechnungNachTagenAbgeschlossenTableAdapter kellnerabrechnungNachTagenAbgeschlossenTableAdapter;
    }
}