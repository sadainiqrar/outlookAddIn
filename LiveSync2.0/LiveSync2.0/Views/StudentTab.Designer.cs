namespace LiveSync2._0.Views
{
    partial class StudentTab : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public StudentTab()
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
            this.StudentTabRibbon = this.Factory.CreateRibbonTab();
            this.StorageConfig = this.Factory.CreateRibbonGroup();
            this.storageSetBtn = this.Factory.CreateRibbonButton();
            this.DownloadGroup = this.Factory.CreateRibbonGroup();
            this.saveLocalBtn = this.Factory.CreateRibbonButton();
            this.saveOutlookBtn = this.Factory.CreateRibbonButton();
            this.AssignmentsGroup = this.Factory.CreateRibbonGroup();
            this.ShowAssignmentsBtn = this.Factory.CreateRibbonButton();
            this.SubmissionGroup = this.Factory.CreateRibbonGroup();
            this.SubmitBtn = this.Factory.CreateRibbonButton();
            this.EnrollGroup = this.Factory.CreateRibbonGroup();
            this.EnrollBtn = this.Factory.CreateRibbonButton();
            this.accountBtn = this.Factory.CreateRibbonButton();
            this.StudentTabRibbon.SuspendLayout();
            this.StorageConfig.SuspendLayout();
            this.DownloadGroup.SuspendLayout();
            this.AssignmentsGroup.SuspendLayout();
            this.SubmissionGroup.SuspendLayout();
            this.EnrollGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentTabRibbon
            // 
            this.StudentTabRibbon.Groups.Add(this.StorageConfig);
            this.StudentTabRibbon.Groups.Add(this.DownloadGroup);
            this.StudentTabRibbon.Groups.Add(this.AssignmentsGroup);
            this.StudentTabRibbon.Groups.Add(this.SubmissionGroup);
            this.StudentTabRibbon.Groups.Add(this.EnrollGroup);
            this.StudentTabRibbon.Label = "Student Tab";
            this.StudentTabRibbon.Name = "StudentTabRibbon";
            // 
            // StorageConfig
            // 
            this.StorageConfig.Items.Add(this.storageSetBtn);
            this.StorageConfig.Items.Add(this.accountBtn);
            this.StorageConfig.Name = "StorageConfig";
            // 
            // storageSetBtn
            // 
            this.storageSetBtn.Label = "Storage settings";
            this.storageSetBtn.Name = "storageSetBtn";
            // 
            // DownloadGroup
            // 
            this.DownloadGroup.Items.Add(this.saveLocalBtn);
            this.DownloadGroup.Items.Add(this.saveOutlookBtn);
            this.DownloadGroup.Label = "Download";
            this.DownloadGroup.Name = "DownloadGroup";
            // 
            // saveLocalBtn
            // 
            this.saveLocalBtn.Label = "Save Local";
            this.saveLocalBtn.Name = "saveLocalBtn";
            // 
            // saveOutlookBtn
            // 
            this.saveOutlookBtn.Label = "Save to Outlook";
            this.saveOutlookBtn.Name = "saveOutlookBtn";
            // 
            // AssignmentsGroup
            // 
            this.AssignmentsGroup.Items.Add(this.ShowAssignmentsBtn);
            this.AssignmentsGroup.Label = "Assignments";
            this.AssignmentsGroup.Name = "AssignmentsGroup";
            // 
            // ShowAssignmentsBtn
            // 
            this.ShowAssignmentsBtn.Label = "Show Assignments";
            this.ShowAssignmentsBtn.Name = "ShowAssignmentsBtn";
            // 
            // SubmissionGroup
            // 
            this.SubmissionGroup.Items.Add(this.SubmitBtn);
            this.SubmissionGroup.Label = "Submission";
            this.SubmissionGroup.Name = "SubmissionGroup";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Label = "Submit Assignment";
            this.SubmitBtn.Name = "SubmitBtn";
            // 
            // EnrollGroup
            // 
            this.EnrollGroup.Items.Add(this.EnrollBtn);
            this.EnrollGroup.Label = "Enrollment";
            this.EnrollGroup.Name = "EnrollGroup";
            // 
            // EnrollBtn
            // 
            this.EnrollBtn.Label = "Enroll in Class";
            this.EnrollBtn.Name = "EnrollBtn";
            // 
            // accountBtn
            // 
            this.accountBtn.Label = "Outlook Account";
            this.accountBtn.Name = "accountBtn";
            // 
            // StudentTab
            // 
            this.Name = "StudentTab";
            this.RibbonType = "Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.StudentTabRibbon);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.StudentTab_Load);
            this.StudentTabRibbon.ResumeLayout(false);
            this.StudentTabRibbon.PerformLayout();
            this.StorageConfig.ResumeLayout(false);
            this.StorageConfig.PerformLayout();
            this.DownloadGroup.ResumeLayout(false);
            this.DownloadGroup.PerformLayout();
            this.AssignmentsGroup.ResumeLayout(false);
            this.AssignmentsGroup.PerformLayout();
            this.SubmissionGroup.ResumeLayout(false);
            this.SubmissionGroup.PerformLayout();
            this.EnrollGroup.ResumeLayout(false);
            this.EnrollGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab StudentTabRibbon;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup StorageConfig;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton storageSetBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup DownloadGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton saveLocalBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton saveOutlookBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup AssignmentsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ShowAssignmentsBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup SubmissionGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SubmitBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup EnrollGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton EnrollBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton accountBtn;
    }

    partial class ThisRibbonCollection
    {
        internal StudentTab StudentTab
        {
            get { return this.GetRibbon<StudentTab>(); }
        }
    }
}
