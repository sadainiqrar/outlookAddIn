using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Live;
using Microsoft.OneDrive.Sdk;
using Microsoft.OneDrive.Sdk.WindowsForms;

namespace LiveSync2._0.Views
{
    public partial class LiveSyncRibbon
    {
        private StorageConfig configuration;

        private void LiveSyncRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            configuration = new StorageConfig();
            configuration.Visible = false;
        }
        
      private void configBtn_Click(object sender, RibbonControlEventArgs e)
        {
            configuration.Visible = true;
        }
        //Outlook Account Button
        private void DownloadBtn_Click(object sender, RibbonControlEventArgs e)
        {
        }

        private void SShowClassBTn_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.showClassesTaskPane.Visible = true;
        }

        private void EnrollBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.enrollClassPane.Visible = true;
        }

        private void ShowAssignmentsBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.showAssignmentsPane.Visible = true;
        }

        private void SubmitBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.submitAssignmentPane.Visible = true;
        }

        private void saveLocalBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.saveFilesPaneLocal.Visible = true;
        }

        private void saveOutlookBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.saveFilesOneDrive.Visible = true;
        }

        private void ShowclassBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.showClassesTaskPane.Visible = true;

        }

        private void CreateAssignBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.uploadssignmentPane.Visible = true;

        }

        private void DownloadSubmissionsBTn_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.downloadSubmissionsPane.Visible = true;

        }

        private void CreateClassbtn_Click(object sender, RibbonControlEventArgs e)
        {
            new CreateClass().Visible = true;
        }
    }
}
