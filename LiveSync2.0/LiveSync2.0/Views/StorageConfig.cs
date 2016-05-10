using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveSync2._0.Models;

namespace LiveSync2._0.Views
{
    public partial class StorageConfig : Form
    {
        private OneDriveLogin login;

        string folderPath;
        public StorageConfig()
        {
            login = new OneDriveLogin();
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void saveConfigBtn_Click(object sender, EventArgs e)
        {
            if (folderPath == null)
            {
                CreateFolderBtn_Click(sender, e);
            }
            new StorageConfiguration().createFolder(folderPath);
          
        }

        private void CreateFolderBtn_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private async void SignInBtn_Click(object sender, EventArgs e)
        {
            if (login.UpdateConnectedState())
            {
                await login.SignIn();
            }
            if(!login.UpdateConnectedState())
            {
                SignOutbtn.Visible = true;
                SignInBtn.Visible = true;
                OCreateFolderBtn.Visible = true;
            }
        }

        private void SignOutbtn_Click(object sender, EventArgs e)
        {
            if (!login.UpdateConnectedState())
            {
                login.signout();
            }
            SignInBtn.Visible = true;
            SignOutbtn.Visible = false;
            OCreateFolderBtn.Visible = false;
            
        }
    }
}
