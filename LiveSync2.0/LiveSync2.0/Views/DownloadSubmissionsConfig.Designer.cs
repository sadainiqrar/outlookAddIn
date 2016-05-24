namespace LiveSync2._0.Views
{
    partial class DownloadSubmissionsConfig
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
            this.saveLocalBtn = new System.Windows.Forms.RadioButton();
            this.saveODbtn = new System.Windows.Forms.RadioButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveLocalBtn
            // 
            this.saveLocalBtn.AutoSize = true;
            this.saveLocalBtn.Location = new System.Drawing.Point(27, 45);
            this.saveLocalBtn.Name = "saveLocalBtn";
            this.saveLocalBtn.Size = new System.Drawing.Size(79, 17);
            this.saveLocalBtn.TabIndex = 0;
            this.saveLocalBtn.TabStop = true;
            this.saveLocalBtn.Text = "Save Local";
            this.saveLocalBtn.UseVisualStyleBackColor = true;
            this.saveLocalBtn.CheckedChanged += new System.EventHandler(this.saveLocalBtn_CheckedChanged);
            // 
            // saveODbtn
            // 
            this.saveODbtn.AutoSize = true;
            this.saveODbtn.Location = new System.Drawing.Point(27, 80);
            this.saveODbtn.Name = "saveODbtn";
            this.saveODbtn.Size = new System.Drawing.Size(114, 17);
            this.saveODbtn.TabIndex = 1;
            this.saveODbtn.TabStop = true;
            this.saveODbtn.Text = "Save To OneDrive";
            this.saveODbtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(45, 162);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // DownloadSubmissionsConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.saveODbtn);
            this.Controls.Add(this.saveLocalBtn);
            this.Name = "DownloadSubmissionsConfig";
            this.Size = new System.Drawing.Size(176, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton saveLocalBtn;
        private System.Windows.Forms.RadioButton saveODbtn;
        private System.Windows.Forms.Button saveBtn;
    }
}
