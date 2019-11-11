using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
       
        public MenuPage()
        {
            InitializeComponent();
            Category cat = new Category();
            Menu x = new Menu();
            ObservableCollection<Category> menu = x.category;

            #region data

            //menu.Add(new Category { CategoryId = 0, CategoryName = "Test Category" });
            menu.Add(new Category { CategoryId = 1, CategoryName = "Breakfast" });
            menu.Add(new Category { CategoryId = 2, CategoryName = "The Bakery" });
            menu.Add(new Category { CategoryId = 3, CategoryName = "Salads" });


            menu.Add(new Category { CategoryId = 4, CategoryName = "Sandwiches" });
            menu.Add(new Category { CategoryId = 5, CategoryName = "Burgers" });
            menu.Add(new Category { CategoryId = 6, CategoryName = "Bagels" });
            menu.Add(new Category { CategoryId = 7, CategoryName = "Wraps" });
            menu.Add(new Category { CategoryId = 8, CategoryName = "Lunch" });
            menu.Add(new Category { CategoryId = 9, CategoryName = "Finger Bites" });
            menu.Add(new Category { CategoryId = 10, CategoryName = "Waffels" });
            menu.Add(new Category { CategoryId = 11, CategoryName = "Sides/ Extras" });
            menu.Add(new Category { CategoryId = 12, CategoryName = "Drinks" });
            menu.Add(new Category { CategoryId = 13, CategoryName = "Beverages" });

            #endregion

            MenuCollectionList.ItemsSource = menu;
        }

        void selectedMeal(Object Sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var SelectedMeal = MenuCollectionList.SelectedItem as Menu;
            if (SelectedMeal != null)
            {
                DisplayAlert("Order this meal?", "Famous Sunup (Breakfast Category)", "Order", "Cancel");
                //Navigation.PushAsync(new MealDetailsPage(SelectedMeal));
            }

        }

    }
}