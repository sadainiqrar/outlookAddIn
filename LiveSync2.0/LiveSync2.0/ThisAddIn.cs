using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;
using LiveSync2._0.Views;

namespace LiveSync2._0
{
    public partial class ThisAddIn
    {
        public CustomTaskPane showAssignmentsPane;
        public CustomTaskPane showClassesTaskPane;
        public CustomTaskPane enrollClassPane;
        public CustomTaskPane saveFilesPaneLocal;
        public CustomTaskPane submitAssignmentPane;
        public CustomTaskPane saveFilesOneDrive;
        public CustomTaskPane uploadssignmentPane;
        public CustomTaskPane downloadSubmissionsPane;
        public CustomTaskPane saveLocalView;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            showClassesTaskPane = this.CustomTaskPanes.Add(new ShowClasses(),"Classes");
            enrollClassPane = this.CustomTaskPanes.Add(new EnrollClassPane(),"Enrollment");
            showAssignmentsPane = this.CustomTaskPanes.Add(new AssignmentCalender(), "Assignments");
            submitAssignmentPane = this.CustomTaskPanes.Add(new SubmitAssignmentPane(), "Submit Assignment");
            saveFilesPaneLocal = this.CustomTaskPanes.Add(new SaveFiles(), "Download Local");
            saveFilesOneDrive = this.CustomTaskPanes.Add(new SaveFiles(), "Save To OneDrive");
            uploadssignmentPane = this.CustomTaskPanes.Add(new UploadAssignment(), "New assignment");
            downloadSubmissionsPane = this.CustomTaskPanes.Add(new DownloadSubmission(), "Assignment Submissions");
            saveLocalView = this.CustomTaskPanes.Add(new SaveLocalView(), "Save select");

            CreateRibbonExtensibilityObject();
           
        }

        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return Globals.Factory.GetRibbonFactory().CreateRibbonManager(
                new Microsoft.Office.Tools.Ribbon.IRibbonExtension[] { new LiveSyncRibbon() });

        }
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
