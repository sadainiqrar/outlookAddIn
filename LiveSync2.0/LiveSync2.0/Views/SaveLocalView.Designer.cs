namespace LiveSync2._0.Views
{
    partial class SaveLocalView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.defaultsaveRBTN = new System.Windows.Forms.RadioButton();
            this.liveSyncRBTN = new System.Windows.Forms.RadioButton();
            this.folderComboBox = new System.Windows.Forms.ComboBox();
            this.CustomSaveBtn = new System.Windows.Forms.RadioButton();
            this.customPathtxt = new System.Windows.Forms.TextBox();
            this.BrowseFolderBTn = new System.Windows.Forms.Button();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // defaultsaveRBTN
            // 
            this.defaultsaveRBTN.AutoSize = true;
            this.defaultsaveRBTN.Location = new System.Drawing.Point(12, 20);
            this.defaultsaveRBTN.Name = "defaultsaveRBTN";
            this.defaultsaveRBTN.Size = new System.Drawing.Size(59, 17);
            this.defaultsaveRBTN.TabIndex = 0;
            this.defaultsaveRBTN.TabStop = true;
            this.defaultsaveRBTN.Text = "Default";
            this.defaultsaveRBTN.UseVisualStyleBackColor = true;
            this.defaultsaveRBTN.CheckedChanged += new System.EventHandler(this.defaultsaveRBTN_CheckedChanged);
            // 
            // liveSyncRBTN
            // 
            this.liveSyncRBTN.AutoSize = true;
            this.liveSyncRBTN.Location = new System.Drawing.Point(12, 43);
            this.liveSyncRBTN.Name = "liveSyncRBTN";
            this.liveSyncRBTN.Size = new System.Drawing.Size(104, 17);
            this.liveSyncRBTN.TabIndex = 1;
            this.liveSyncRBTN.TabStop = true;
            this.liveSyncRBTN.Text = "Live Sync Folder";
            this.liveSyncRBTN.UseVisualStyleBackColor = true;
            this.liveSyncRBTN.CheckedChanged += new System.EventHandler(this.liveSyncRBTN_CheckedChanged);
            // 
            // folderComboBox
            // 
            this.folderComboBox.FormattingEnabled = true;
            this.folderComboBox.Location = new System.Drawing.Point(22, 67);
            this.folderComboBox.Name = "folderComboBox";
            this.folderComboBox.Size = new System.Drawing.Size(149, 21);
            this.folderComboBox.TabIndex = 2;
            this.folderComboBox.Visible = false;
            // 
            // CustomSaveBtn
            // 
            this.CustomSaveBtn.AutoSize = true;
            this.CustomSaveBtn.Location = new System.Drawing.Point(12, 95);
            this.CustomSaveBtn.Name = "CustomSaveBtn";
            this.CustomSaveBtn.Size = new System.Drawing.Size(60, 17);
            this.CustomSaveBtn.TabIndex = 3;
            this.CustomSaveBtn.TabStop = true;
            this.CustomSaveBtn.Text = "Custom";
            this.CustomSaveBtn.UseVisualStyleBackColor = true;
            this.CustomSaveBtn.CheckedChanged += new System.EventHandler(this.CustomSaveBtn_CheckedChanged);
            // 
            // customPathtxt
            // 
            this.customPathtxt.Location = new System.Drawing.Point(22, 119);
            this.customPathtxt.Name = "customPathtxt";
            this.customPathtxt.Size = new System.Drawing.Size(149, 20);
            this.customPathtxt.TabIndex = 4;
            this.customPathtxt.Visible = false;
            // 
            // BrowseFolderBTn
            // 
            this.BrowseFolderBTn.Location = new System.Drawing.Point(189, 117);
            this.BrowseFolderBTn.Name = "BrowseFolderBTn";
            this.BrowseFolderBTn.Size = new System.Drawing.Size(57, 23);
            this.BrowseFolderBTn.TabIndex = 5;
            this.BrowseFolderBTn.Text = "Browse";
            this.BrowseFolderBTn.UseVisualStyleBackColor = true;
            this.BrowseFolderBTn.Visible = false;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(96, 157);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(75, 23);
            this.downloadBtn.TabIndex = 6;
            this.downloadBtn.Text = "Save";
            this.downloadBtn.UseVisualStyleBackColor = true;
            // 
            // SaveLocalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.BrowseFolderBTn);
            this.Controls.Add(this.customPathtxt);
            this.Controls.Add(this.CustomSaveBtn);
            this.Controls.Add(this.folderComboBox);
            this.Controls.Add(this.liveSyncRBTN);
            this.Controls.Add(this.defaultsaveRBTN);
            this.Name = "SaveLocalView";
            this.Size = new System.Drawing.Size(268, 192);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton defaultsaveRBTN;
        private System.Windows.Forms.RadioButton liveSyncRBTN;
        private System.Windows.Forms.ComboBox folderComboBox;
        private System.Windows.Forms.RadioButton CustomSaveBtn;
        private System.Windows.Forms.TextBox customPathtxt;
        private System.Windows.Forms.Button BrowseFolderBTn;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
