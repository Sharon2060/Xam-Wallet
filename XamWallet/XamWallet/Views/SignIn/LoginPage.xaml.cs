using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamWallet.Views.SignIn
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        void registerbtn_clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
