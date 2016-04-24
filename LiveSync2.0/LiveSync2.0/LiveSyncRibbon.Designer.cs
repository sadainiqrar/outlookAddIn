namespace LiveSync2._0
{
    partial class LiveSyncRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public LiveSyncRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.LiveSyncTab = this.Factory.CreateRibbonTab();
            this.LiveSyncG1 = this.Factory.CreateRibbonGroup();
            this.SendEmail = this.Factory.CreateRibbonButton();
            this.DownloadBtn = this.Factory.CreateRibbonButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.LiveSyncTab.SuspendLayout();
            this.LiveSyncG1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LiveSyncTab
            // 
            this.LiveSyncTab.Groups.Add(this.LiveSyncG1);
            this.LiveSyncTab.Label = "LiveSyncTab";
            this.LiveSyncTab.Name = "LiveSyncTab";
            // 
            // LiveSyncG1
            // 
            this.LiveSyncG1.Items.Add(this.SendEmail);
            this.LiveSyncG1.Items.Add(this.DownloadBtn);
            this.LiveSyncG1.Label = "LiveSync";
            this.LiveSyncG1.Name = "LiveSyncG1";
            // 
            // SendEmail
            // 
            this.SendEmail.Label = "SendEmail";
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.configBtn_Click);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Label = "Download";
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DownloadBtn_Click);
            // 
            // LiveSyncRibbon
            // 
            this.Name = "LiveSyncRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.LiveSyncTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.LiveSyncRibbon_Load);
            this.LiveSyncTab.ResumeLayout(false);
            this.LiveSyncTab.PerformLayout();
            this.LiveSyncG1.ResumeLayout(false);
            this.LiveSyncG1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab LiveSyncTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup LiveSyncG1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DownloadBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SendEmail;
    }

    partial class ThisRibbonCollection
    {
        internal LiveSyncRibbon LiveSyncRibbon
        {
            get { return this.GetRibbon<LiveSyncRibbon>(); }
        }
    }
}
