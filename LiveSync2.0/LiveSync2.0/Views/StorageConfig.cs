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

        string folderPath;
        public StorageConfig()
        {
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
                this.Visible = false;
            }
          
        }

        private void CreateFolderBtn_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;

                new StorageConfiguration().createFolder(folderPath);
            }
        }

        private async void SignInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                    await OneDriveObject.ONEDRIVE.SignIn();

                    SignInBtn.Visible = false;
                    SignOutbtn.Visible = true;
            }
            catch (OperationCanceledException)
            {

            }
            catch (Exception)
            {

            }
            

        }

        private void SignOutbtn_Click(object sender, EventArgs e)
        {
                OneDriveObject.ONEDRIVE.signout();

                SignInBtn.Visible = true;
                SignOutbtn.Visible = false;
            

        }

        private void OCreateFolderBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
