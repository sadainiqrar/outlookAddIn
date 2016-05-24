using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace LiveSync2._0.Models
{
    class DownloadSubmissions
    {
        public DownloadSubmissions()
        {
            Outlook.Application app = new Outlook.Application();
            Outlook.Accounts acc = app.Session.Accounts;
            foreach (Outlook.Account ac in acc)
            {
                Outlook.MAPIFolder inBox = app.ActiveExplorer().Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
                Outlook.Items inBoxItems = inBox.Items;
                Outlook.MailItem newEmail = null;
                try
                {
                    foreach (object collItem in inBoxItems)
                    {
                        newEmail = collItem as Outlook.MailItem;
                        if (newEmail != null)
                        {
                            if (newEmail.Attachments.Count > 0 && newEmail.Subject == "submitted Assignment")
                            {
                                for (int i = 1; i <= newEmail.Attachments.Count; i++)
                                {
                                    newEmail.Attachments[i].SaveAsFile(LocalFolder.FOLDER + "\\" + newEmail.Attachments[i].FileName);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string error = (string)ex.Message.Substring(0, 11);
                    if (error == "Cannot save")
                    {
                        System.Windows.Forms.MessageBox.Show("Folder doesnot exist");
                    }
                }
            }

        }

        public DownloadSubmissions(DateTime start, DateTime end)
        {
            Outlook.Application app = new Outlook.Application();
            Outlook.Accounts acc = app.Session.Accounts;
            foreach (Outlook.Account ac in acc)
            {
                Outlook.MAPIFolder inBox = app.ActiveExplorer().Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
                Outlook.Items inBoxItems = inBox.Items;
                Outlook.MailItem newEmail = null;
                try
                {
                    foreach (object collItem in inBoxItems)
                    {
                        newEmail = collItem as Outlook.MailItem;

                        if (newEmail != null)
                        {
                            if (newEmail.CreationTime >= start && newEmail.CreationTime <= end)
                            {
                                if (newEmail.Attachments.Count > 0 && newEmail.Subject == "submitted Assignment")
                                {
                                    for (int i = 1; i <= newEmail.Attachments.Count; i++)
                                    {
                                        newEmail.Attachments[i].SaveAsFile(LocalFolder.FOLDER + newEmail.Attachments[i].FileName);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string error = (string)ex.Message.Substring(0, 11);
                    if (error == "Cannot save")
                    {
                        System.Windows.Forms.MessageBox.Show("Folder doesnot exist");
                    }
                }
            }
        }
        public DownloadSubmissions(DateTime start, DateTime end, String group)
        {

        }
    }
}
