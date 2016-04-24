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

namespace LiveSync2._0
{
    public partial class LiveSyncRibbon
    {
        private const string AadClientId = "b145a917-23f3-483f-8675-87e6f988a999";
        private const string AadReturnUrl = "http://localhost:777";
        private const string MsaClientId = "000000004418641D";
        private const string MsaReturnUrl = "http://login.live.com/oauth20_desktop.srf";

        private static readonly string[] scopes = { "onedrive.readwrite","wl.offline_access","wl.signin"};
        private const int uploadChunksize = 10 * 1024 * 1024;
        private IOneDriveClient oneDriveClient { get; set; }

        private void LiveSyncRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private async void configBtn_Click(object sender, RibbonControlEventArgs e)
        {
            await this.SignIn(ClientType.Consumer);

        }
/*
        private async Task<int> UploadFileToOneDrive()
        {
            LiveConnectClient liveConnect;
            try
            {
                var authClient = new LiveAuthClient(AadClientId);
                LiveLoginResult result = await authClient.InitializeAsync(new string[] {"wl.skydrive","wl.skydrive_update" });

                if(result.Status == LiveConnectSessionStatus.Connected)
                {
                    liveConnect = new LiveConnectClient(result.Session);
                   
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                    need to be done
                 

                }
            }
        }
*/

        private async Task SignIn(ClientType clientType)
        {
            if(this.oneDriveClient == null)
            {
                this.oneDriveClient = clientType == ClientType.Consumer
                    ? OneDriveClient.GetMicrosoftAccountClient(
                        MsaClientId,MsaReturnUrl,scopes,webAuthenticationUi: new FormsWebAuthenticationUi())
                        :BusinessClientExtensions.GetActiveDirectoryClient(AadClientId,AadReturnUrl);
            }
            try
            {
                if(!this.oneDriveClient.IsAuthenticated)
                {
                    await oneDriveClient.AuthenticateAsync();
                }
                
            }
            catch(OneDriveException exception)
            {
                if(!exception.IsMatch(OneDriveErrorCode.AuthenticationCancelled.ToString()))
                {
                    if(exception.IsMatch(OneDriveErrorCode.AuthenticationCancelled.ToString()))
                    {
                        System.Windows.Forms.MessageBox.Show("Authentication failed");
                        var httpProvider = oneDriveClient.HttpProvider as HttpProvider;
                        httpProvider.Dispose();
                        this.oneDriveClient = null;
                        
                    }
                    else
                    {
                      
                    }
                }
            }
        }
        private void DownloadBtn_Click(object sender, RibbonControlEventArgs e)
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
                            if (newEmail.Attachments.Count > 0)
                            {
                                for (int i = 1; i <= newEmail.Attachments.Count; i++)
                                {
                                    newEmail.Attachments[i].SaveAsFile(@"C:\OutlookItems\" + newEmail.Attachments[i].FileName);
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
    }
}
