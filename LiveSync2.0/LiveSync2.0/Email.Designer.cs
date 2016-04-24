namespace LiveSync2._0
{
    partial class Email
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
            this.emailaddtxt = new System.Windows.Forms.TextBox();
            this.subjecttxt = new System.Windows.Forms.TextBox();
            this.emailBodytxt = new System.Windows.Forms.RichTextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AttachBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // emailaddtxt
            // 
            this.emailaddtxt.Location = new System.Drawing.Point(64, 21);
            this.emailaddtxt.Name = "emailaddtxt";
            this.emailaddtxt.Size = new System.Drawing.Size(283, 20);
            this.emailaddtxt.TabIndex = 0;
            // 
            // subjecttxt
            // 
            this.subjecttxt.Location = new System.Drawing.Point(64, 50);
            this.subjecttxt.Name = "subjecttxt";
            this.subjecttxt.Size = new System.Drawing.Size(283, 20);
            this.subjecttxt.TabIndex = 2;
            this.subjecttxt.TextChanged += new System.EventHandler(this.subjecttxt_TextChanged);
            // 
            // emailBodytxt
            // 
            this.emailBodytxt.Location = new System.Drawing.Point(64, 86);
            this.emailBodytxt.Name = "emailBodytxt";
            this.emailBodytxt.Size = new System.Drawing.Size(283, 203);
            this.emailBodytxt.TabIndex = 3;
            this.emailBodytxt.Text = "";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(64, 314);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(158, 314);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AttachBtn
            // 
            this.AttachBtn.Location = new System.Drawing.Point(64, 285);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.Size = new System.Drawing.Size(75, 23);
            this.AttachBtn.TabIndex = 6;
            this.AttachBtn.Text = "Attach";
            this.AttachBtn.UseVisualStyleBackColor = true;
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Body";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 349);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AttachBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.emailBodytxt);
            this.Controls.Add(this.subjecttxt);
            this.Controls.Add(this.emailaddtxt);
            this.Name = "Email";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailaddtxt;
        private System.Windows.Forms.TextBox subjecttxt;
        private System.Windows.Forms.RichTextBox emailBodytxt;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AttachBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}