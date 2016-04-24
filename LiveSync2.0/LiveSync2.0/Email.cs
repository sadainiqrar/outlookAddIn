using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Live;

namespace LiveSync2._0
{
    public partial class Email : Form
    {
        Outlook.Application app;
        Outlook.MailItem mail;
        Outlook.Attachment attach;

        public Email()
        {
            app = new Outlook.Application();
            mail = app.CreateItem(Outlook.OlItemType.olMailItem) as Outlook.MailItem;
            InitializeComponent();
        }

        private void subjecttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
            int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                attach = mail.Attachments.Add(openFileDialog1.Tag,iAttachType,(mail.Body.Length)+2,openFileDialog1.FileName);
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
          
            mail.Subject = subjecttxt.Text.ToString();
            mail.Body = emailBodytxt.Text.ToString();
            mail.To = emailaddtxt.Text.ToString();
            mail.Importance = Outlook.OlImportance.olImportanceHigh;
            ((Outlook._MailItem)mail).Send();

            this.Dispose();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
