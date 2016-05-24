using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace LiveSync2._0.Models
{
    class SubmitAssingment
    {
        Outlook.MailItem mail;
        Outlook.MAPIFolder sendContacts;
        Outlook.Application app;

        public SubmitAssingment()
        {
            app = new Outlook.Application();
            sendContacts = (Outlook.MAPIFolder)app.ActiveExplorer().Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
            mail = (Outlook.MailItem)app.CreateItem(Outlook.OlItemType.olMailItem);
        }

        public void uploadAssignment(string title, string body, string attachment)
        {
            try
            {
                string s = "submitted";
                mail.Subject = s+ " Assignment";
                mail.Body = title + "\n\n" + body;
                mail.Attachments.Add(attachment,
                                    Outlook.OlAttachmentType.olByValue,
                                     1,
                                    attachment);
                mail.Recipients.Add("sadain.abbasi@outlook.com");
                mail.Recipients.ResolveAll();
                mail.Importance = Outlook.OlImportance.olImportanceHigh;
                ((Outlook._MailItem)mail).Send();
                

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
