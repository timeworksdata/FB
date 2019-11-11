using Microsoft.WindowsAzure.MobileServices;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FB
{
    public partial class App : Application
    {
        public static string dbPoint;
        public static MobileServiceClient client = new MobileServiceClient("https://famousbeanapp.azurewebsites.net");
        public App()
        {
            InitializeComponent();

        }

        public App(string fullPathArg)
        {
            dbPoint = fullPathArg;

            InitializeComponent();
            MainPage = new NavigationPage(new FamousPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
