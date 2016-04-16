namespace LiveSyncWindowsForm
{
    partial class FilesWindow
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
            this.myFilesBtn = new System.Windows.Forms.Button();
            this.sharedFilesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myFilesBtn
            // 
            this.myFilesBtn.Location = new System.Drawing.Point(29, 86);
            this.myFilesBtn.Name = "myFilesBtn";
            this.myFilesBtn.Size = new System.Drawing.Size(75, 23);
            this.myFilesBtn.TabIndex = 0;
            this.myFilesBtn.Text = "My Files";
            this.myFilesBtn.UseVisualStyleBackColor = true;
            // 
            // sharedFilesBtn
            // 
            this.sharedFilesBtn.Location = new System.Drawing.Point(153, 86);
            this.sharedFilesBtn.Name = "sharedFilesBtn";
            this.sharedFilesBtn.Size = new System.Drawing.Size(75, 23);
            this.sharedFilesBtn.TabIndex = 1;
            this.sharedFilesBtn.Text = "Shared Files";
            this.sharedFilesBtn.UseVisualStyleBackColor = true;
            // 
            // FilesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sharedFilesBtn);
            this.Controls.Add(this.myFilesBtn);
            this.Name = "FilesWindow";
            this.Text = "Files";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myFilesBtn;
        private System.Windows.Forms.Button sharedFilesBtn;
    }
}