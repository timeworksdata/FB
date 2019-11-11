using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FB.Classes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
            loginButton.Clicked += login;
        }

        public void login(Object Sender, EventArgs e)
        {

            //Settings loginBanner = new Settings();

            User usr = new User();
            string collectedEmail = loginEmailEntry.Text;
            string collectedPassword = PasswordEntry.Text;


            // if (Connectivity.NetworkAccess == NetworkAccess.None)

            // DisplayAlert("Network error", "Please check your internet connectivity", "Ok");


            //else

            if ((collectedEmail == "timeworks") && (collectedPassword == "pass"))
            {
                Navigation.PushAsync(new FamousPage());
            }

            // else

            // DisplayAlert("Authentication failed", "Wrong username or password!", "OK");



        }

        private void registerButton_Clicked(object sender, EventArgs e)
        {
            // Navigation.PushAsync(new RegistrationPage());
        }
    }
}