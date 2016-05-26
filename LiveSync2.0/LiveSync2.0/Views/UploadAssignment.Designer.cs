namespace LiveSync2._0.Views
{
    partial class UploadAssignment
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
            this.assignNameTxt = new System.Windows.Forms.TextBox();
            this.assignBodytxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.assigngroupcombo = new System.Windows.Forms.ComboBox();
            this.BrowsefileBtn = new System.Windows.Forms.Button();
            this.FilePathtxt = new System.Windows.Forms.TextBox();
            this.UploadassignBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deadlineDatePick = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // assignNameTxt
            // 
            this.assignNameTxt.Location = new System.Drawing.Point(87, 47);
            this.assignNameTxt.Name = "assignNameTxt";
            this.assignNameTxt.Size = new System.Drawing.Size(169, 20);
            this.assignNameTxt.TabIndex = 1;
            // 
            // assignBodytxt
            // 
            this.assignBodytxt.Location = new System.Drawing.Point(87, 73);
            this.assignBodytxt.Name = "assignBodytxt";
            this.assignBodytxt.Size = new System.Drawing.Size(169, 127);
            this.assignBodytxt.TabIndex = 0;
            this.assignBodytxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assignment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "File";
            // 
            // assigngroupcombo
            // 
            this.assigngroupcombo.FormattingEnabled = true;
            this.assigngroupcombo.Location = new System.Drawing.Point(87, 21);
            this.assigngroupcombo.Name = "assigngroupcombo";
            this.assigngroupcombo.Size = new System.Drawing.Size(169, 21);
            this.assigngroupcombo.TabIndex = 6;
            // 
            // BrowsefileBtn
            // 
            this.BrowsefileBtn.Location = new System.Drawing.Point(206, 208);
            this.BrowsefileBtn.Name = "BrowsefileBtn";
            this.BrowsefileBtn.Size = new System.Drawing.Size(50, 23);
            this.BrowsefileBtn.TabIndex = 8;
            this.BrowsefileBtn.Text = "Browse";
            this.BrowsefileBtn.UseVisualStyleBackColor = true;
            this.BrowsefileBtn.Click += new System.EventHandler(this.BrowsefileBtn_Click);
            // 
            // FilePathtxt
            // 
            this.FilePathtxt.Location = new System.Drawing.Point(87, 211);
            this.FilePathtxt.Name = "FilePathtxt";
            this.FilePathtxt.Size = new System.Drawing.Size(110, 20);
            this.FilePathtxt.TabIndex = 9;
            // 
            // UploadassignBtn
            // 
            this.UploadassignBtn.Location = new System.Drawing.Point(105, 290);
            this.UploadassignBtn.Name = "UploadassignBtn";
            this.UploadassignBtn.Size = new System.Drawing.Size(75, 23);
            this.UploadassignBtn.TabIndex = 10;
            this.UploadassignBtn.Text = "upload";
            this.UploadassignBtn.UseVisualStyleBackColor = true;
            this.UploadassignBtn.Click += new System.EventHandler(this.UploadassignBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Submission\r\nDate";
            // 
            // deadlineDatePick
            // 
            this.deadlineDatePick.Location = new System.Drawing.Point(87, 250);
            this.deadlineDatePick.Name = "deadlineDatePick";
            this.deadlineDatePick.Size = new System.Drawing.Size(169, 20);
            this.deadlineDatePick.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UploadAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.deadlineDatePick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UploadassignBtn);
            this.Controls.Add(this.FilePathtxt);
            this.Controls.Add(this.BrowsefileBtn);
            this.Controls.Add(this.assigngroupcombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignBodytxt);
            this.Controls.Add(this.assignNameTxt);
            this.Name = "UploadAssignment";
            this.Size = new System.Drawing.Size(273, 334);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox assignNameTxt;
        private System.Windows.Forms.RichTextBox assignBodytxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox assigngroupcombo;
        private System.Windows.Forms.Button BrowsefileBtn;
        private System.Windows.Forms.TextBox FilePathtxt;
        private System.Windows.Forms.Button UploadassignBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker deadlineDatePick;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
