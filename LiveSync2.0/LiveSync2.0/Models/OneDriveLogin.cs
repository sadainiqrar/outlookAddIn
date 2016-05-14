using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.OneDrive;
using LiveSync2._0.Views;
using Microsoft.OneDrive.Sdk;
using Microsoft.OneDrive.Sdk.WindowsForms;

namespace LiveSync2._0.Models
{
    class OneDriveLogin
    {
        private const string AadClientId = "b145a917-23f3-483f-8675-87e6f988a999";
        private const string AadReturnUrl = "https://localhost:777";

        private const string MsaClientId = "000000004418641D";
        private const string MsaReturnUrl = "https://login.live.com/oauth20_desktop.srf";

        private static readonly string[] Scopes = { "onedrive.readwrite", "wl.offline_access", "wl.signin" };

        private const int UploadChunkSize = 10 * 1024 * 1024;       // 10 MB
        public IOneDriveClient oneDriveClient { get; set; }
        private Item CurrentFolder { get; set; }
        private Item SelectedItem { get; set; }

        
        

        public OneDriveLogin()
        {
            
        }

        public async Task SignIn()
        {
           await SignInMSA(ClientType.Consumer);
        }

        private async Task SignInMSA(ClientType clientType)
        {
            if (this.oneDriveClient == null)
            {
                this.oneDriveClient = clientType == ClientType.Consumer
                    ? OneDriveClient.GetMicrosoftAccountClient(
                        MsaClientId,
                        MsaReturnUrl,
                        Scopes,
                        webAuthenticationUi: new FormsWebAuthenticationUi())
                    : BusinessClientExtensions.GetActiveDirectoryClient(AadClientId, AadReturnUrl);
            }

            try
            {
                if (!this.oneDriveClient.IsAuthenticated)
                {
                    await this.oneDriveClient.AuthenticateAsync();
                  
                }
                
            }
            catch (OneDriveException exception)
            {
                // Swallow authentication cancelled exceptions
                if (!exception.IsMatch(OneDriveErrorCode.AuthenticationCancelled.ToString()))
                {
                    if (exception.IsMatch(OneDriveErrorCode.AuthenticationFailure.ToString()))
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Authentication failed",
                            "Authentication failed",
                            System.Windows.Forms.MessageBoxButtons.OK);

                        var httpProvider = this.oneDriveClient.HttpProvider as HttpProvider;
                        httpProvider.Dispose();
                        this.oneDriveClient = null;
                    }
                    else
                    {
                        PresentOneDriveException(exception);
                    }
                }
            }
        }

        public async void signout()
        {
            if (this.oneDriveClient != null)
            {
                await this.oneDriveClient.SignOutAsync();
                ((OneDriveClient)this.oneDriveClient).Dispose();
                this.oneDriveClient = null;
            }
        }


        private static void PresentOneDriveException(Exception exception)
        {
            string message = null;
            var oneDriveException = exception as OneDriveException;
            if (oneDriveException == null)
            {
                message = exception.Message;
            }
            else
            {
                message = string.Format("{0}{1}", Environment.NewLine, oneDriveException.ToString());
            }

            System.Windows.Forms.MessageBox.Show(string.Format("OneDrive reported the following error: {0}", message));
        }

        public bool UpdateConnectedState()
        {
            return null == this.oneDriveClient;
        }


        public string getFolder()
        {
            return "";
        }
       

    }
}
