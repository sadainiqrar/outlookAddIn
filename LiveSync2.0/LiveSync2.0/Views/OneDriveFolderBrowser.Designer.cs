namespace LiveSync2._0.Views
{
    partial class OneDriveFolderBrowser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OneDriveUsernamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 227);
            this.panel1.TabIndex = 0;
            // 
            // OneDriveUsernamelbl
            // 
            this.OneDriveUsernamelbl.AutoSize = true;
            this.OneDriveUsernamelbl.Location = new System.Drawing.Point(30, 10);
            this.OneDriveUsernamelbl.Name = "OneDriveUsernamelbl";
            this.OneDriveUsernamelbl.Size = new System.Drawing.Size(57, 13);
            this.OneDriveUsernamelbl.TabIndex = 1;
            this.OneDriveUsernamelbl.Text = "UserName";
            // 
            // OneDriveFolderBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 272);
            this.Controls.Add(this.OneDriveUsernamelbl);
            this.Controls.Add(this.panel1);
            this.Name = "OneDriveFolderBrowser";
            this.Text = "OneDriveFolderBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OneDriveUsernamelbl;
    }
}