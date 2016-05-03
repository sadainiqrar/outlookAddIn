namespace LiveSync2._0.Views
{
    partial class DownloadSubmission
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
            this.ClassGroupComboD = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cusRBTN = new System.Windows.Forms.RadioButton();
            this.defRBTN = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveSubBTn = new System.Windows.Forms.Button();
            this.CancelBTn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassGroupComboD
            // 
            this.ClassGroupComboD.FormattingEnabled = true;
            this.ClassGroupComboD.Location = new System.Drawing.Point(69, 12);
            this.ClassGroupComboD.Name = "ClassGroupComboD";
            this.ClassGroupComboD.Size = new System.Drawing.Size(147, 21);
            this.ClassGroupComboD.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(69, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // cusRBTN
            // 
            this.cusRBTN.AutoSize = true;
            this.cusRBTN.Location = new System.Drawing.Point(6, 77);
            this.cusRBTN.Name = "cusRBTN";
            this.cusRBTN.Size = new System.Drawing.Size(60, 17);
            this.cusRBTN.TabIndex = 3;
            this.cusRBTN.TabStop = true;
            this.cusRBTN.Text = "Custom";
            this.cusRBTN.UseVisualStyleBackColor = true;
            // 
            // defRBTN
            // 
            this.defRBTN.AutoSize = true;
            this.defRBTN.Location = new System.Drawing.Point(6, 54);
            this.defRBTN.Name = "defRBTN";
            this.defRBTN.Size = new System.Drawing.Size(59, 17);
            this.defRBTN.TabIndex = 4;
            this.defRBTN.TabStop = true;
            this.defRBTN.Text = "Default";
            this.defRBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Class Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // saveSubBTn
            // 
            this.saveSubBTn.Location = new System.Drawing.Point(23, 175);
            this.saveSubBTn.Name = "saveSubBTn";
            this.saveSubBTn.Size = new System.Drawing.Size(75, 23);
            this.saveSubBTn.TabIndex = 8;
            this.saveSubBTn.Text = "Save";
            this.saveSubBTn.UseVisualStyleBackColor = true;
            // 
            // CancelBTn
            // 
            this.CancelBTn.Location = new System.Drawing.Point(116, 175);
            this.CancelBTn.Name = "CancelBTn";
            this.CancelBTn.Size = new System.Drawing.Size(75, 23);
            this.CancelBTn.TabIndex = 9;
            this.CancelBTn.Text = "Cancel";
            this.CancelBTn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 66);
            this.panel1.TabIndex = 10;
            // 
            // DownloadSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelBTn);
            this.Controls.Add(this.saveSubBTn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defRBTN);
            this.Controls.Add(this.cusRBTN);
            this.Controls.Add(this.ClassGroupComboD);
            this.Name = "DownloadSubmission";
            this.Size = new System.Drawing.Size(219, 217);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassGroupComboD;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton cusRBTN;
        private System.Windows.Forms.RadioButton defRBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveSubBTn;
        private System.Windows.Forms.Button CancelBTn;
        private System.Windows.Forms.Panel panel1;
    }
}
