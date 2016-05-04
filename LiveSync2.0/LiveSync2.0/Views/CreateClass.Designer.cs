namespace LiveSync2._0.Views
{
    partial class CreateClass
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
            this.classNameTxt = new System.Windows.Forms.TextBox();
            this.classIDtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.AddListBtn = new System.Windows.Forms.Button();
            this.AddExcelBtn = new System.Windows.Forms.Button();
            this.SaveBTn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // classNameTxt
            // 
            this.classNameTxt.Location = new System.Drawing.Point(97, 12);
            this.classNameTxt.Name = "classNameTxt";
            this.classNameTxt.Size = new System.Drawing.Size(154, 20);
            this.classNameTxt.TabIndex = 0;
            // 
            // classIDtxt
            // 
            this.classIDtxt.Location = new System.Drawing.Point(97, 38);
            this.classIDtxt.Name = "classIDtxt";
            this.classIDtxt.Size = new System.Drawing.Size(154, 20);
            this.classIDtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Students";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 121);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add List";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 157);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Add Form Excel";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // AddListBtn
            // 
            this.AddListBtn.Location = new System.Drawing.Point(156, 115);
            this.AddListBtn.Name = "AddListBtn";
            this.AddListBtn.Size = new System.Drawing.Size(75, 23);
            this.AddListBtn.TabIndex = 7;
            this.AddListBtn.Text = "Add List";
            this.AddListBtn.UseVisualStyleBackColor = true;
            this.AddListBtn.Visible = false;
            this.AddListBtn.Click += new System.EventHandler(this.AddListBtn_Click);
            // 
            // AddExcelBtn
            // 
            this.AddExcelBtn.Location = new System.Drawing.Point(156, 151);
            this.AddExcelBtn.Name = "AddExcelBtn";
            this.AddExcelBtn.Size = new System.Drawing.Size(75, 23);
            this.AddExcelBtn.TabIndex = 8;
            this.AddExcelBtn.Text = "Excel Sheet";
            this.AddExcelBtn.UseVisualStyleBackColor = true;
            this.AddExcelBtn.Visible = false;
            // 
            // SaveBTn
            // 
            this.SaveBTn.Location = new System.Drawing.Point(52, 215);
            this.SaveBTn.Name = "SaveBTn";
            this.SaveBTn.Size = new System.Drawing.Size(75, 23);
            this.SaveBTn.TabIndex = 9;
            this.SaveBTn.Text = "Save";
            this.SaveBTn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(156, 215);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBTn);
            this.Controls.Add(this.AddExcelBtn);
            this.Controls.Add(this.AddListBtn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classIDtxt);
            this.Controls.Add(this.classNameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateClass";
            this.Text = "CreateClass";
            this.Load += new System.EventHandler(this.CreateClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox classNameTxt;
        private System.Windows.Forms.TextBox classIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button AddListBtn;
        private System.Windows.Forms.Button AddExcelBtn;
        private System.Windows.Forms.Button SaveBTn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}