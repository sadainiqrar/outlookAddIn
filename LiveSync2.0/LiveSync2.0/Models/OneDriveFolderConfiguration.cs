using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.OneDrive.Sdk;
using Microsoft.OneDrive;
using Microsoft.OneDrive.Sdk.WindowsForms;

namespace LiveSync2._0.Models
{
    class OneDriveFolderConfiguration
    {
        public OneDriveFolderConfiguration()
        {

        }

        public async void SaveItem(string filename, IOneDriveClient client)
        {
            using (var stream = GetFileStreamForUpload(filename))
            {
                if (stream != null)
                {
                    string folderPath = "/drive/items/root:";
                    var uploadPath = folderPath + "/" + Uri.EscapeUriString(System.IO.Path.GetFileName(filename));

                    try
                    {
                        var uploadedItem =
                            await
                                client.ItemWithPath(uploadPath).Content.Request().PutAsync<Item>(stream);


                        System.Windows.Forms.MessageBox.Show("Uploaded with ID: " + uploadedItem.Id);
                    }
                    catch (Exception exception)
                    {
                        PresentOneDriveException(exception);
                    }
                }
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

        private System.IO.Stream GetFileStreamForUpload(string originalFilename)
        {
            try
            {
                return new System.IO.FileStream(originalFilename, System.IO.FileMode.Open);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error uploading file: " + ex.Message);
                originalFilename = null;
                return null;
            }
        }
    }
}
