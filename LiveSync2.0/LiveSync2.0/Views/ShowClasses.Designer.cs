namespace LiveSync2._0.Views
{
    partial class ShowClasses
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
            this.ClassGroupCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classstudentsview = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassGroupCombo
            // 
            this.ClassGroupCombo.FormattingEnabled = true;
            this.ClassGroupCombo.Location = new System.Drawing.Point(79, 14);
            this.ClassGroupCombo.Name = "ClassGroupCombo";
            this.ClassGroupCombo.Size = new System.Drawing.Size(142, 21);
            this.ClassGroupCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Students";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.classstudentsview);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 210);
            this.panel1.TabIndex = 3;
            // 
            // classstudentsview
            // 
            this.classstudentsview.Location = new System.Drawing.Point(3, 3);
            this.classstudentsview.Name = "classstudentsview";
            this.classstudentsview.Size = new System.Drawing.Size(215, 204);
            this.classstudentsview.TabIndex = 0;
            this.classstudentsview.UseCompatibleStateImageBehavior = false;
            // 
            // ShowClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassGroupCombo);
            this.Name = "ShowClasses";
            this.Size = new System.Drawing.Size(246, 295);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassGroupCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView classstudentsview;
    }
}
