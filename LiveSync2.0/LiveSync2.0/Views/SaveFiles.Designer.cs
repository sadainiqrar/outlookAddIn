﻿namespace LiveSync2._0.Views
{
    partial class SaveFiles
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
            this.groupCBtn = new System.Windows.Forms.CheckBox();
            this.dateCbtn = new System.Windows.Forms.CheckBox();
            this.classCBOX = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateGBOX = new System.Windows.Forms.GroupBox();
            this.NextsaveBtn = new System.Windows.Forms.Button();
            this.dateGBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCBtn
            // 
            this.groupCBtn.AutoSize = true;
            this.groupCBtn.Location = new System.Drawing.Point(18, 15);
            this.groupCBtn.Name = "groupCBtn";
            this.groupCBtn.Size = new System.Drawing.Size(51, 17);
            this.groupCBtn.TabIndex = 0;
            this.groupCBtn.Text = "Class";
            this.groupCBtn.UseVisualStyleBackColor = true;
            this.groupCBtn.CheckedChanged += new System.EventHandler(this.groupCBtn_CheckedChanged);
            // 
            // dateCbtn
            // 
            this.dateCbtn.AutoSize = true;
            this.dateCbtn.Location = new System.Drawing.Point(18, 69);
            this.dateCbtn.Name = "dateCbtn";
            this.dateCbtn.Size = new System.Drawing.Size(75, 17);
            this.dateCbtn.TabIndex = 1;
            this.dateCbtn.Text = "From Date";
            this.dateCbtn.UseVisualStyleBackColor = true;
            this.dateCbtn.CheckedChanged += new System.EventHandler(this.dateCbtn_CheckedChanged);
            // 
            // classCBOX
            // 
            this.classCBOX.FormattingEnabled = true;
            this.classCBOX.Location = new System.Drawing.Point(35, 38);
            this.classCBOX.Name = "classCBOX";
            this.classCBOX.Size = new System.Drawing.Size(121, 21);
            this.classCBOX.TabIndex = 2;
            this.classCBOX.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(74, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // dateGBOX
            // 
            this.dateGBOX.Controls.Add(this.dateTimePicker2);
            this.dateGBOX.Controls.Add(this.label1);
            this.dateGBOX.Controls.Add(this.label2);
            this.dateGBOX.Controls.Add(this.dateTimePicker1);
            this.dateGBOX.Location = new System.Drawing.Point(21, 92);
            this.dateGBOX.Name = "dateGBOX";
            this.dateGBOX.Size = new System.Drawing.Size(260, 98);
            this.dateGBOX.TabIndex = 7;
            this.dateGBOX.TabStop = false;
            this.dateGBOX.Visible = false;
            // 
            // NextsaveBtn
            // 
            this.NextsaveBtn.Location = new System.Drawing.Point(107, 209);
            this.NextsaveBtn.Name = "NextsaveBtn";
            this.NextsaveBtn.Size = new System.Drawing.Size(75, 23);
            this.NextsaveBtn.TabIndex = 8;
            this.NextsaveBtn.Text = "Ok";
            this.NextsaveBtn.UseVisualStyleBackColor = true;
            this.NextsaveBtn.Click += new System.EventHandler(this.NextsaveBtn_Click);
            // 
            // SaveFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.NextsaveBtn);
            this.Controls.Add(this.dateGBOX);
            this.Controls.Add(this.classCBOX);
            this.Controls.Add(this.dateCbtn);
            this.Controls.Add(this.groupCBtn);
            this.Name = "SaveFiles";
            this.Size = new System.Drawing.Size(297, 254);
            this.dateGBOX.ResumeLayout(false);
            this.dateGBOX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox groupCBtn;
        private System.Windows.Forms.CheckBox dateCbtn;
        private System.Windows.Forms.ComboBox classCBOX;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox dateGBOX;
        private System.Windows.Forms.Button NextsaveBtn;
    }
}
