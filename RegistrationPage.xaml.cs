using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();

            btnRegister.Clicked += register;
        }

        private async void register(Object Sender, EventArgs e)
        {
            Users usr = new Users()
            {
                id = Guid.NewGuid().ToString(),
                email = txtEmail.Text,
                password = pwdPassword.Text

               /* FirstName = txtFirstname.Text,
                LastName = txtLastname.Text,
                Email = txtEmail.Text,
                Password = pwdPassword.Text
               */

            };

             await App.client.GetTable<Users>().InsertAsync(usr);

            #region If Using SQLite DB
            /*
            using (SQLiteConnection conn = new SQLiteConnection(App.dbPoint))
            {
                conn.CreateTable<User>();
                conn.Insert(usr);
            }
            */

            #endregion
        }


        private void AlreadyRegistered_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}