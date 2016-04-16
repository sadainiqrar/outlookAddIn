namespace LiveSyncWindowsForm
{
    partial class MainPage
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
            this.filesBtn = new System.Windows.Forms.Button();
            this.EventsBtn = new System.Windows.Forms.Button();
            this.contactsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filesBtn
            // 
            this.filesBtn.Location = new System.Drawing.Point(3, 29);
            this.filesBtn.Name = "filesBtn";
            this.filesBtn.Size = new System.Drawing.Size(75, 23);
            this.filesBtn.TabIndex = 0;
            this.filesBtn.Text = "Files";
            this.filesBtn.UseVisualStyleBackColor = true;
            this.filesBtn.Click += new System.EventHandler(this.filesBtn_Click);
            // 
            // EventsBtn
            // 
            this.EventsBtn.Location = new System.Drawing.Point(3, 78);
            this.EventsBtn.Name = "EventsBtn";
            this.EventsBtn.Size = new System.Drawing.Size(75, 23);
            this.EventsBtn.TabIndex = 1;
            this.EventsBtn.Text = "Events";
            this.EventsBtn.UseVisualStyleBackColor = true;
            this.EventsBtn.Click += new System.EventHandler(this.EventsBtn_Click);
            // 
            // contactsBtn
            // 
            this.contactsBtn.Location = new System.Drawing.Point(125, 29);
            this.contactsBtn.Name = "contactsBtn";
            this.contactsBtn.Size = new System.Drawing.Size(75, 23);
            this.contactsBtn.TabIndex = 2;
            this.contactsBtn.Text = "Contacts";
            this.contactsBtn.UseVisualStyleBackColor = true;
            this.contactsBtn.Click += new System.EventHandler(this.contactsBtn_Click);
            // 
            // MainPage
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.contactsBtn);
            this.Controls.Add(this.EventsBtn);
            this.Controls.Add(this.filesBtn);
            this.Name = "MainPage";
            this.Text = "Live Sync";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem syncToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSelectedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button myFilesBtn;
        private System.Windows.Forms.Button sharedFilesBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button filesBtn;
        private System.Windows.Forms.Button EventsBtn;
        private System.Windows.Forms.Button contactsBtn;
    }
}