using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App19
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
            Close.Clicked += (s, e) => Environment.Exit(0);

        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Username.Text))
            {
                if(Username.Text == "a")
                {
                    Navigation.PushAsync(new MainPage(Username.Text));
                }
                else
                    DisplayAlert("Error", "Username is error!!", "Ok");
            }
            else
                DisplayAlert("Error", "Username is empty!!", "Ok");
        }
    }
}
