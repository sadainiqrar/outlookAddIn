namespace LiveSync2._0.Views
{
    partial class StorageConfig
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
            this.LocalStorageTabBtn = new System.Windows.Forms.TabControl();
            this.LocalStorageTab = new System.Windows.Forms.TabPage();
            this.CreateFolderBtn = new System.Windows.Forms.Button();
            this.OneDriveStorageTab = new System.Windows.Forms.TabPage();
            this.OCreateFolderBtn = new System.Windows.Forms.Button();
            this.SignOutbtn = new System.Windows.Forms.Button();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.saveConfigBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.LocalStorageTabBtn.SuspendLayout();
            this.LocalStorageTab.SuspendLayout();
            this.OneDriveStorageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocalStorageTabBtn
            // 
            this.LocalStorageTabBtn.Controls.Add(this.LocalStorageTab);
            this.LocalStorageTabBtn.Controls.Add(this.OneDriveStorageTab);
            this.LocalStorageTabBtn.Location = new System.Drawing.Point(3, 2);
            this.LocalStorageTabBtn.Name = "LocalStorageTabBtn";
            this.LocalStorageTabBtn.SelectedIndex = 0;
            this.LocalStorageTabBtn.Size = new System.Drawing.Size(230, 94);
            this.LocalStorageTabBtn.TabIndex = 0;
            // 
            // LocalStorageTab
            // 
            this.LocalStorageTab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LocalStorageTab.Controls.Add(this.CreateFolderBtn);
            this.LocalStorageTab.Location = new System.Drawing.Point(4, 22);
            this.LocalStorageTab.Name = "LocalStorageTab";
            this.LocalStorageTab.Padding = new System.Windows.Forms.Padding(3);
            this.LocalStorageTab.Size = new System.Drawing.Size(222, 68);
            this.LocalStorageTab.TabIndex = 0;
            this.LocalStorageTab.Text = "Local";
            // 
            // CreateFolderBtn
            // 
            this.CreateFolderBtn.Location = new System.Drawing.Point(56, 22);
            this.CreateFolderBtn.Name = "CreateFolderBtn";
            this.CreateFolderBtn.Size = new System.Drawing.Size(105, 23);
            this.CreateFolderBtn.TabIndex = 0;
            this.CreateFolderBtn.Text = "Create Folder";
            this.CreateFolderBtn.UseVisualStyleBackColor = true;
            // 
            // OneDriveStorageTab
            // 
            this.OneDriveStorageTab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OneDriveStorageTab.Controls.Add(this.OCreateFolderBtn);
            this.OneDriveStorageTab.Controls.Add(this.SignOutbtn);
            this.OneDriveStorageTab.Controls.Add(this.SignInBtn);
            this.OneDriveStorageTab.Location = new System.Drawing.Point(4, 22);
            this.OneDriveStorageTab.Name = "OneDriveStorageTab";
            this.OneDriveStorageTab.Padding = new System.Windows.Forms.Padding(3);
            this.OneDriveStorageTab.Size = new System.Drawing.Size(222, 68);
            this.OneDriveStorageTab.TabIndex = 1;
            this.OneDriveStorageTab.Text = "One Drive";
            // 
            // OCreateFolderBtn
            // 
            this.OCreateFolderBtn.Location = new System.Drawing.Point(103, 23);
            this.OCreateFolderBtn.Name = "OCreateFolderBtn";
            this.OCreateFolderBtn.Size = new System.Drawing.Size(103, 23);
            this.OCreateFolderBtn.TabIndex = 2;
            this.OCreateFolderBtn.Text = "Create Folder";
            this.OCreateFolderBtn.UseVisualStyleBackColor = true;
            // 
            // SignOutbtn
            // 
            this.SignOutbtn.Location = new System.Drawing.Point(6, 23);
            this.SignOutbtn.Name = "SignOutbtn";
            this.SignOutbtn.Size = new System.Drawing.Size(75, 23);
            this.SignOutbtn.TabIndex = 1;
            this.SignOutbtn.Text = "Sign Out";
            this.SignOutbtn.UseVisualStyleBackColor = true;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(6, 23);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 0;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            // 
            // saveConfigBtn
            // 
            this.saveConfigBtn.Location = new System.Drawing.Point(7, 98);
            this.saveConfigBtn.Name = "saveConfigBtn";
            this.saveConfigBtn.Size = new System.Drawing.Size(135, 23);
            this.saveConfigBtn.TabIndex = 1;
            this.saveConfigBtn.Text = "Save Configurations";
            this.saveConfigBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(154, 98);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // StorageConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(237, 123);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveConfigBtn);
            this.Controls.Add(this.LocalStorageTabBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorageConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StorageConfig";
            this.LocalStorageTabBtn.ResumeLayout(false);
            this.LocalStorageTab.ResumeLayout(false);
            this.OneDriveStorageTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LocalStorageTabBtn;
        private System.Windows.Forms.TabPage LocalStorageTab;
        private System.Windows.Forms.TabPage OneDriveStorageTab;
        private System.Windows.Forms.Button CreateFolderBtn;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button SignOutbtn;
        private System.Windows.Forms.Button OCreateFolderBtn;
        private System.Windows.Forms.Button saveConfigBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}