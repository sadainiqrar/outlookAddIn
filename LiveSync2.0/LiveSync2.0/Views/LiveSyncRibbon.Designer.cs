using System;

namespace LiveSync2._0.Views
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
            this.ConfigBTn = this.Factory.CreateRibbonButton();
            this.OAccountBtn = this.Factory.CreateRibbonButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.studentTab = this.Factory.CreateRibbonTab();
            this.DownloadGroup = this.Factory.CreateRibbonGroup();
            this.saveLocalBtn = this.Factory.CreateRibbonButton();
            this.saveOutlookBtn = this.Factory.CreateRibbonButton();
            this.AssignmentsGroup = this.Factory.CreateRibbonGroup();
            this.SubmitBtn = this.Factory.CreateRibbonButton();
            this.EnrollGroup = this.Factory.CreateRibbonGroup();
            this.EnrollBtn = this.Factory.CreateRibbonButton();
            this.tutorTab = this.Factory.CreateRibbonTab();
            this.ClassGroup = this.Factory.CreateRibbonGroup();
            this.CreateClassbtn = this.Factory.CreateRibbonButton();
            this.AssignmentGroup = this.Factory.CreateRibbonGroup();
            this.CreateAssignBtn = this.Factory.CreateRibbonButton();
            this.DownloadSubmissionsBTn = this.Factory.CreateRibbonButton();
            this.LiveSyncTab.SuspendLayout();
            this.LiveSyncG1.SuspendLayout();
            this.studentTab.SuspendLayout();
            this.DownloadGroup.SuspendLayout();
            this.AssignmentsGroup.SuspendLayout();
            this.EnrollGroup.SuspendLayout();
            this.tutorTab.SuspendLayout();
            this.ClassGroup.SuspendLayout();
            this.AssignmentGroup.SuspendLayout();
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
            this.LiveSyncG1.Items.Add(this.ConfigBTn);
            this.LiveSyncG1.Items.Add(this.OAccountBtn);
            this.LiveSyncG1.Label = "LiveSync";
            this.LiveSyncG1.Name = "LiveSyncG1";
            // 
            // ConfigBTn
            // 
            this.ConfigBTn.Label = "Configuration";
            this.ConfigBTn.Name = "ConfigBTn";
            this.ConfigBTn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.configBtn_Click);
            // 
            // OAccountBtn
            // 
            this.OAccountBtn.Label = "Outlook Account";
            this.OAccountBtn.Name = "OAccountBtn";
            this.OAccountBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DownloadBtn_Click);
            // 
            // studentTab
            // 
            this.studentTab.Groups.Add(this.DownloadGroup);
            this.studentTab.Groups.Add(this.AssignmentsGroup);
            this.studentTab.Groups.Add(this.EnrollGroup);
            this.studentTab.Label = "Student Tab";
            this.studentTab.Name = "studentTab";
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
            this.saveLocalBtn.Label = "Download Assignments Local";
            this.saveLocalBtn.Name = "saveLocalBtn";
            this.saveLocalBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.saveLocalBtn_Click);
            // 
            // saveOutlookBtn
            // 
            this.saveOutlookBtn.Label = "Save Assignments to OneDrive";
            this.saveOutlookBtn.Name = "saveOutlookBtn";
            this.saveOutlookBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.saveOutlookBtn_Click);
            // 
            // AssignmentsGroup
            // 
            this.AssignmentsGroup.Items.Add(this.SubmitBtn);
            this.AssignmentsGroup.Label = "Assignments";
            this.AssignmentsGroup.Name = "AssignmentsGroup";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Label = "Submit Assignment";
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SubmitBtn_Click);
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
            this.EnrollBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EnrollBtn_Click);
            // 
            // tutorTab
            // 
            this.tutorTab.Groups.Add(this.ClassGroup);
            this.tutorTab.Groups.Add(this.AssignmentGroup);
            this.tutorTab.Label = "Tutor Tab";
            this.tutorTab.Name = "tutorTab";
            // 
            // ClassGroup
            // 
            this.ClassGroup.Items.Add(this.CreateClassbtn);
            this.ClassGroup.Label = "Class";
            this.ClassGroup.Name = "ClassGroup";
            // 
            // CreateClassbtn
            // 
            this.CreateClassbtn.Label = "Create Class";
            this.CreateClassbtn.Name = "CreateClassbtn";
            this.CreateClassbtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateClassbtn_Click);
            // 
            // AssignmentGroup
            // 
            this.AssignmentGroup.Items.Add(this.CreateAssignBtn);
            this.AssignmentGroup.Items.Add(this.DownloadSubmissionsBTn);
            this.AssignmentGroup.Label = "Assignments";
            this.AssignmentGroup.Name = "AssignmentGroup";
            // 
            // CreateAssignBtn
            // 
            this.CreateAssignBtn.Label = "Upload Assignment";
            this.CreateAssignBtn.Name = "CreateAssignBtn";
            this.CreateAssignBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateAssignBtn_Click);
            // 
            // DownloadSubmissionsBTn
            // 
            this.DownloadSubmissionsBTn.Label = "Download Submissions";
            this.DownloadSubmissionsBTn.Name = "DownloadSubmissionsBTn";
            this.DownloadSubmissionsBTn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DownloadSubmissionsBTn_Click);
            // 
            // LiveSyncRibbon
            // 
            this.Name = "LiveSyncRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.LiveSyncTab);
            this.Tabs.Add(this.studentTab);
            this.Tabs.Add(this.tutorTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.LiveSyncRibbon_Load);
            this.LiveSyncTab.ResumeLayout(false);
            this.LiveSyncTab.PerformLayout();
            this.LiveSyncG1.ResumeLayout(false);
            this.LiveSyncG1.PerformLayout();
            this.studentTab.ResumeLayout(false);
            this.studentTab.PerformLayout();
            this.DownloadGroup.ResumeLayout(false);
            this.DownloadGroup.PerformLayout();
            this.AssignmentsGroup.ResumeLayout(false);
            this.AssignmentsGroup.PerformLayout();
            this.EnrollGroup.ResumeLayout(false);
            this.EnrollGroup.PerformLayout();
            this.tutorTab.ResumeLayout(false);
            this.tutorTab.PerformLayout();
            this.ClassGroup.ResumeLayout(false);
            this.ClassGroup.PerformLayout();
            this.AssignmentGroup.ResumeLayout(false);
            this.AssignmentGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab LiveSyncTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup LiveSyncG1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OAccountBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ConfigBTn;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab studentTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tutorTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ClassGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateClassbtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup AssignmentGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateAssignBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DownloadSubmissionsBTn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup DownloadGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton saveLocalBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton saveOutlookBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup AssignmentsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SubmitBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup EnrollGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton EnrollBtn;
    }

    partial class ThisRibbonCollection
    {
        internal LiveSyncRibbon LiveSyncRibbon
        {
            get { return this.GetRibbon<LiveSyncRibbon>(); }
        }

        private LiveSyncRibbon GetRibbon<T>()
        {
            throw new NotImplementedException();
        }
    }
}
