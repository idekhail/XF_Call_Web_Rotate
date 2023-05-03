using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App19
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage(string Username)
        {
            InitializeComponent();
            YourName.Text = Username;

            Logout.Clicked += (s, e) => Navigation.PopAsync();
            NextPage.Clicked += (s, e) => Navigation.PushAsync(new ScreenPage(Username));
        }

        private void CallMe_Clicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open(Input.Text);
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }

        private async void OpenWeb_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Browser.OpenAsync(Input.Text, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }
        }

        private void Rotate_Clicked(object sender, EventArgs e)
        {
            Code.RelRotateTo(360, 2000);
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            Input.Text = string.Empty;
        }

    }
}