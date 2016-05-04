namespace LiveSync2._0.Views
{
    partial class SubmitAssignmentPane
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
            this.label1 = new System.Windows.Forms.Label();
            this.classselectCBOX = new System.Windows.Forms.ComboBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.erollmenttxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descrichtxt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.submitBTn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // classselectCBOX
            // 
            this.classselectCBOX.FormattingEnabled = true;
            this.classselectCBOX.Location = new System.Drawing.Point(86, 18);
            this.classselectCBOX.Name = "classselectCBOX";
            this.classselectCBOX.Size = new System.Drawing.Size(121, 21);
            this.classselectCBOX.TabIndex = 1;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(86, 45);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(121, 20);
            this.nametxt.TabIndex = 2;
            // 
            // erollmenttxt
            // 
            this.erollmenttxt.Location = new System.Drawing.Point(86, 71);
            this.erollmenttxt.Name = "erollmenttxt";
            this.erollmenttxt.Size = new System.Drawing.Size(121, 20);
            this.erollmenttxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enrollment";
            // 
            // descrichtxt
            // 
            this.descrichtxt.Location = new System.Drawing.Point(86, 106);
            this.descrichtxt.Name = "descrichtxt";
            this.descrichtxt.Size = new System.Drawing.Size(121, 59);
            this.descrichtxt.TabIndex = 6;
            this.descrichtxt.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(86, 171);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(75, 23);
            this.UploadBtn.TabIndex = 8;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            // 
            // submitBTn
            // 
            this.submitBTn.Location = new System.Drawing.Point(86, 212);
            this.submitBTn.Name = "submitBTn";
            this.submitBTn.Size = new System.Drawing.Size(75, 23);
            this.submitBTn.TabIndex = 9;
            this.submitBTn.Text = "Submit";
            this.submitBTn.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SubmitAssignmentPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.submitBTn);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descrichtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.erollmenttxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.classselectCBOX);
            this.Controls.Add(this.label1);
            this.Name = "SubmitAssignmentPane";
            this.Size = new System.Drawing.Size(232, 248);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classselectCBOX;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox erollmenttxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox descrichtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Button submitBTn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
