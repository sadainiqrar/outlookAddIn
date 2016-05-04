namespace LiveSync2._0.Views
{
    partial class EnrollClassPane
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
            this.label2 = new System.Windows.Forms.Label();
            this.classNametxt = new System.Windows.Forms.TextBox();
            this.classKeytxt = new System.Windows.Forms.TextBox();
            this.enrollBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class Key";
            // 
            // classNametxt
            // 
            this.classNametxt.Location = new System.Drawing.Point(77, 37);
            this.classNametxt.Name = "classNametxt";
            this.classNametxt.Size = new System.Drawing.Size(130, 20);
            this.classNametxt.TabIndex = 2;
            // 
            // classKeytxt
            // 
            this.classKeytxt.Location = new System.Drawing.Point(77, 69);
            this.classKeytxt.Name = "classKeytxt";
            this.classKeytxt.Size = new System.Drawing.Size(130, 20);
            this.classKeytxt.TabIndex = 3;
            // 
            // enrollBtn
            // 
            this.enrollBtn.Location = new System.Drawing.Point(77, 120);
            this.enrollBtn.Name = "enrollBtn";
            this.enrollBtn.Size = new System.Drawing.Size(75, 23);
            this.enrollBtn.TabIndex = 4;
            this.enrollBtn.Text = "Enroll";
            this.enrollBtn.UseVisualStyleBackColor = true;
            // 
            // EnrollClassPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.enrollBtn);
            this.Controls.Add(this.classKeytxt);
            this.Controls.Add(this.classNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnrollClassPane";
            this.Size = new System.Drawing.Size(224, 178);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox classNametxt;
        private System.Windows.Forms.TextBox classKeytxt;
        private System.Windows.Forms.Button enrollBtn;
    }
}
