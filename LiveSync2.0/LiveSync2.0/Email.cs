using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
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
using System.Text.RegularExpressions;

namespace LiveSync2._0
{
    public partial class Email : Form
    {

        Outlook.Application app;
        Outlook.MailItem mail;

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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               mail.Attachments.Add(openFileDialog1.FileName,Outlook.OlAttachmentType.olByValue,1,openFileDialog1.FileName);
            }     
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if(emailaddtxt.Text == "" || !validMatch(emailaddtxt.Text))
            {
                MessageBox.Show("Recipient address is incorrect");
                valid = false;
            }
            if (valid)
            {
                mail.Subject = subjecttxt.Text.ToString();
                mail.Body = emailBodytxt.Text.ToString();
                mail.To = emailaddtxt.Text.ToString();
                mail.Importance = Outlook.OlImportance.olImportanceHigh;
                ((Outlook._MailItem)mail).Send();

                this.Dispose();
            }

        }
        
        private bool validMatch(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"); ;
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
