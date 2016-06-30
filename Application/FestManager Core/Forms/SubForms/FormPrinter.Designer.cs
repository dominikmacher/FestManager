namespace FestManager_Core.Forms.SubForms
{
    partial class FormPrinter
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
            this.operationsPanel = new System.Windows.Forms.Panel();
            this.zuruecksetzenButton = new System.Windows.Forms.Button();
            this.speichernButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.operationsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // operationsPanel
            // 
            this.operationsPanel.Controls.Add(this.zuruecksetzenButton);
            this.operationsPanel.Controls.Add(this.speichernButton);
            this.operationsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationsPanel.Location = new System.Drawing.Point(0, 333);
            this.operationsPanel.Name = "operationsPanel";
            this.operationsPanel.Size = new System.Drawing.Size(710, 48);
            this.operationsPanel.TabIndex = 12;
            // 
            // zuruecksetzenButton
            // 
            this.zuruecksetzenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zuruecksetzenButton.Location = new System.Drawing.Point(452, 13);
            this.zuruecksetzenButton.Name = "zuruecksetzenButton";
            this.zuruecksetzenButton.Size = new System.Drawing.Size(120, 23);
            this.zuruecksetzenButton.TabIndex = 1;
            this.zuruecksetzenButton.Text = "&Zurücksetzen";
            this.zuruecksetzenButton.UseVisualStyleBackColor = true;
            // 
            // speichernButton
            // 
            this.speichernButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.speichernButton.Location = new System.Drawing.Point(578, 13);
            this.speichernButton.Name = "speichernButton";
            this.speichernButton.Size = new System.Drawing.Size(120, 23);
            this.speichernButton.TabIndex = 0;
            this.speichernButton.Text = "&Speichern";
            this.speichernButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(710, 26);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Druckeinstellungen";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(388, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // FormPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 381);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.operationsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "FormPrinter";
            this.Text = "Druckeinstellungen";
            this.Load += new System.EventHandler(this.FormPrinter_Load);
            this.operationsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel operationsPanel;
        private System.Windows.Forms.Button zuruecksetzenButton;
        private System.Windows.Forms.Button speichernButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}