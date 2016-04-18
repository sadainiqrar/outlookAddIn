

using Office365Plugin.Common;
using Office365Plugin.Helpers;
using Office365Plugin.ViewModels;
using Office365Plugin.Views;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Office365Plugin
{
    /// <summary>
    /// The main page that contains sign-in and navigation to Office 365 functionality.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private NavigationHelper navigationHelper;

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public MainPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
        }

        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            this.DataContext = App.CurrentUser;
        }

        private void Calendar_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Calendar));
        }

        private void MyFiles_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MyFiles));
        }

        private void Contacts_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Contacts));
        }

        private void Mail_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Mail));
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);

            // Developer code - if you haven't registered the app yet, we warn you. 
            if (!App.Current.Resources.ContainsKey("ida:ClientID"))
            {
                MessageDialogHelper.ShowDialogAsync("To run this sample, you must register it with Office 365. You can do that through the 'Add | Connected services' dialog in Visual Studio. See Readme for more info", "Oops - App not registered with Office 365");
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

    }
}