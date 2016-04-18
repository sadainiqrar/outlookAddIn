

using Microsoft.Azure.ActiveDirectory.GraphClient;
using Microsoft.Data.OData;
using System;
using System.IO;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Office365Plugin.Helpers
{
    /// <summary>
    /// Contains methods for accessing user information stored in Azure AD.
    /// </summary>
    public class UserOperations
    {
        private string _userEmail = string.Empty;

        /// <summary>
        /// Authenticates and signs in the user. 
        /// </summary>
        /// <returns></returns>
        public async Task<IUser> GetCurrentUserAsync()
        {
            try
            {
                IUser currentUser = null;

                // Make sure we have a reference to the Azure Active Directory client
                var aadClient = await AuthenticationHelper.GetGraphClientAsync();

                if (aadClient != null)
                {
                    // This results in a call to the service.
                    currentUser = await (aadClient.Users
                                                .Where(i => i.ObjectId == AuthenticationHelper.LoggedInUser)
                                                .ExecuteSingleAsync());

                    if (currentUser != null)
                        _userEmail = currentUser.Mail;

                }

                return currentUser;
            }
            catch (ODataErrorException ode)
            {
                MessageDialogHelper.DisplayException(ode);
                return null;
            }
        }

        /// <summary>
        /// Get the user's photo.
        /// </summary>
        /// <param name="user">The target user.</param>
        /// <returns></returns>
        public async Task<BitmapImage> GetUserThumbnailPhotoAsync(IUser user)
        {
            BitmapImage bitmap = null;
            try
            {
                // The using statement ensures that Dispose is called even if an 
                // exception occurs while you are calling methods on the object.
                using (var dssr = await user.ThumbnailPhoto.DownloadAsync())
                using (var stream = dssr.Stream)
                using (var memStream = new MemoryStream())
                {
                    await stream.CopyToAsync(memStream);
                    memStream.Seek(0, SeekOrigin.Begin);
                    bitmap = new BitmapImage();
                    await bitmap.SetSourceAsync(memStream.AsRandomAccessStream());
                }

            }
            catch(ODataException)
            {
                // Something went wrong retrieving the thumbnail photo, so set the bitmap to a default image
                bitmap = new BitmapImage(new Uri("ms-appx:///assets/UserDefaultSignedIn.png", UriKind.RelativeOrAbsolute));
            }

            return bitmap;
        }

        /// <summary>
        /// Sign out of the service.
        /// </summary>
        /// <returns></returns>
        public async Task SignOutAsync()
        {
            await AuthenticationHelper.SignOutAsync();
        }
    }
}