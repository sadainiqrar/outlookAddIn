using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;
using LiveSync2._0.Views;
using System.Windows.Forms;

namespace LiveSync2._0.Models
{
    class UploadAssignment
    {
        Outlook.MailItem mail;
        Outlook.MAPIFolder sendContacts;
        Outlook.Application app;
        Outlook.TaskItem deadline;

        public UploadAssignment()
        {
            app = new Outlook.Application();
            sendContacts = (Outlook.MAPIFolder)app.ActiveExplorer().Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
            mail = (Outlook.MailItem)app.CreateItem(Outlook.OlItemType.olMailItem);
            deadline = (Outlook.TaskItem)app.CreateItem(Outlook.OlItemType.olTaskItem);
        }

        public void uploadAssignment(string title, string body, DateTime date,string attachment)
        {
            try
            { 
                
                
                mail.Subject = "Assignment";
                mail.Body = title + "\n\n" + body;
                mail.Attachments.Add(attachment,
                                    Outlook.OlAttachmentType.olByValue,
                                     1,
                                    attachment);
                mail.Recipients.Add("sadain.abbasi@gmail.com");
                mail.Recipients.ResolveAll();
                mail.Importance = Outlook.OlImportance.olImportanceHigh;
                ((Outlook._MailItem)mail).Send();

                deadline.Subject = "Assignment";
                deadline.Body = title + "\n\n" + body;
                deadline.Attachments.Add(attachment,
                                    Outlook.OlAttachmentType.olByValue,
                                     1,
                                    attachment);
                deadline.Recipients.Add("sadain.abbasi@gmail.com");
                deadline.Recipients.ResolveAll();
                deadline.Importance = Outlook.OlImportance.olImportanceHigh;
                deadline.StartDate = DateTime.Now;
                deadline.DueDate = date;
                deadline.Assign();
                ((Outlook._TaskItem)deadline).Send();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
