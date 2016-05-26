using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;

namespace LiveSync2._0.Models
{
    class OutlookAccountInfo
    {
        Outlook.Application app;
        Outlook.Accounts acc;
        public OutlookAccountInfo()
        {
            app = new Outlook.Application();
            acc = app.Session.Accounts;
        }
        public void ShowAccounts()
        {
            foreach (Outlook.Account ac in acc)
            {
                System.Windows.Forms.MessageBox.Show("User Name: " + ac.UserName + "\nEmail: " + ac.SmtpAddress);
            }
        }
    }
}
