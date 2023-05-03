using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App19
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScreenPage : ContentPage
    {
        public ScreenPage(string Username)
        {
            InitializeComponent();
            YourName.Text = Username;

            Close.Clicked += (s, e) => Environment.Exit(0);
            Logout.Clicked += (s, e) => Navigation.PushAsync(new FirstPage());

        }
    }
}