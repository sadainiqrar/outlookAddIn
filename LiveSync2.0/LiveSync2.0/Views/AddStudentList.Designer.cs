namespace LiveSync2._0.Views
{
    partial class AddStudentList
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
            this.AddStudentsList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.OkListBtn = new System.Windows.Forms.Button();
            this.cancelBTn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStudentsList
            // 
            this.AddStudentsList.Location = new System.Drawing.Point(12, 26);
            this.AddStudentsList.Name = "AddStudentsList";
            this.AddStudentsList.Size = new System.Drawing.Size(192, 206);
            this.AddStudentsList.TabIndex = 0;
            this.AddStudentsList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Students";
            // 
            // OkListBtn
            // 
            this.OkListBtn.Location = new System.Drawing.Point(15, 238);
            this.OkListBtn.Name = "OkListBtn";
            this.OkListBtn.Size = new System.Drawing.Size(75, 23);
            this.OkListBtn.TabIndex = 2;
            this.OkListBtn.Text = "Ok";
            this.OkListBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBTn
            // 
            this.cancelBTn.Location = new System.Drawing.Point(129, 238);
            this.cancelBTn.Name = "cancelBTn";
            this.cancelBTn.Size = new System.Drawing.Size(75, 23);
            this.cancelBTn.TabIndex = 3;
            this.cancelBTn.Text = "Cancel";
            this.cancelBTn.UseVisualStyleBackColor = true;
            // 
            // AddStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 269);
            this.Controls.Add(this.cancelBTn);
            this.Controls.Add(this.OkListBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddStudentsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudentList";
            this.Text = "AddStudentList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AddStudentsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkListBtn;
        private System.Windows.Forms.Button cancelBTn;
    }
}