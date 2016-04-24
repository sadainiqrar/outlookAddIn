using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace OutlookAddIn1
{
    public partial class ThisAddIn
    {
        public string username;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
           // username = Environment.UserDomainName + "/" + Environment.UserName;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {

        }

        //protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        //{
        //    return base.CreateRibbonExtensibilityObject();
        //}

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
