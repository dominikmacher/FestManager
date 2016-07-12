namespace FestManager_Core.Forms.SubForms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.buttonDatabase = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxDirectTwice = new System.Windows.Forms.CheckBox();
            this.openFileDialogDatabase = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxDatabase
            // 
            resources.ApplyResources(this.textBoxDatabase, "textBoxDatabase");
            this.textBoxDatabase.Name = "textBoxDatabase";
            // 
            // labelDatabase
            // 
            resources.ApplyResources(this.labelDatabase, "labelDatabase");
            this.labelDatabase.Name = "labelDatabase";
            // 
            // buttonDatabase
            // 
            resources.ApplyResources(this.buttonDatabase, "buttonDatabase");
            this.buttonDatabase.Name = "buttonDatabase";
            this.buttonDatabase.UseVisualStyleBackColor = true;
            this.buttonDatabase.Click += new System.EventHandler(this.buttonDatabase_Click);
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxDirectTwice
            // 
            resources.ApplyResources(this.checkBoxDirectTwice, "checkBoxDirectTwice");
            this.checkBoxDirectTwice.Name = "checkBoxDirectTwice";
            this.checkBoxDirectTwice.UseVisualStyleBackColor = true;
            // 
            // openFileDialogDatabase
            // 
            this.openFileDialogDatabase.DefaultExt = "mdb";
            resources.ApplyResources(this.openFileDialogDatabase, "openFileDialogDatabase");
            // 
            // FormSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxDirectTwice);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonDatabase);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.textBoxDatabase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Button buttonDatabase;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxDirectTwice;
        private System.Windows.Forms.OpenFileDialog openFileDialogDatabase;
    }
}