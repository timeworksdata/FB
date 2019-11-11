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
    public partial class LocalProductsPage : ContentPage
    {
        public LocalProductsPage()
        {
         
            InitializeComponent();
            Product cat = new Product();
            ProductListClass x = new ProductListClass();
            ObservableCollection<Product> prod = x.product;

            #region new data
            prod.Add(new Product()
            {

                ProductId = 10,
                CategoryId = 1,
                ProductName = "The Famous Basic",
                ProductPrice = 50,
                ProductDescription = "1 farm fresh egg, bacon, grilled tomato and toast",
                NutritionalValues = "Cal: 259; Fat: 19.3; Sod: 783mg; Chol: 202mg; Carb: 2.6; Prot: 17.5g"
            });

            prod.Add(new Product()
            {
                ProductId = 12,
                CategoryId = 1,
                ProductName = "The Famous Sunup",
                ProductPrice = 75,
                ProductDescription = "2 farm fresh eggs, bacon, fries or potato rosti, grilled tomato and toast.",
                NutritionalValues = "Cal: 1161; Fat: 81g; Sod: 2773mg; Chol: 474mg; Carb: 56g; Prot: 52.7g"
            });

            prod.Add(new Product()
            {
                ProductId = 20,
                CategoryId = 2,
                ProductName = "Cake of the day",
                ProductPrice = 45,
                ProductDescription = "Cake of the day",
                NutritionalValues = ""
            });

            prod.Add(new Product()
            {
                ProductId = 21,
                CategoryId = 2,
                ProductName = "Croissant - Plain",
                ProductPrice = 40,
                ProductDescription = "with jam and butter",
                NutritionalValues = "Cal: 114; Fat: 5,9g; Sod: 208mg; Chol: 19mg; Carb: 12,8g; Prot: 2,3g"
            });

            prod.Add(new Product()
            {
                ProductId = 23,
                CategoryId = 2,
                ProductName = "Croissant - Cheese",
                ProductPrice = 45,
                ProductDescription = "with cheddar cheese, jam & butter",
                NutritionalValues = "Cal: 194; Fat: 12.5; Sod: 333mg; Chol: 40g; Carb: 13.1g; Prot: 7.3g"
            });

            prod.Add(new Product()
            {
                ProductId = 30,
                CategoryId = 3,
                ProductName = "Garden Salad",
                ProductPrice = 55,
                ProductDescription = "A crisp salad of garden greens, tomato, onio, olives, peppers, cucumbers, feta and toastes croutons in creamy dressing",
                NutritionalValues = "Cal: 225; Fat: 15.4g; Sod: 484mg; Carb: 12.6g; Prot: 10.1g"
            });

            prod.Add(new Product()
            {
                ProductId = 31,
                CategoryId = 3,
                ProductName = "Grilled Chicken Breast Salad",
                ProductPrice = 85,
                ProductDescription = "Grilled free range chicken breast onn a bed of garden greens, carrot, roasted tomato, onion and cucumber ribbons topped with savings of mature chheddar",
                NutritionalValues = "Cal: 240; Fat: 8.7g; Sod: 143mg; Chol: 79mg; Carb: 10,7g; Prot: 29,1g"
            });


            prod.Add(new Product()
            {
                ProductId = 40,
                CategoryId = 4,
                ProductName = "Avo & Salmon on rye",
                ProductPrice = 95,
                ProductDescription = "Lightly toasted rye with smoked salmo, fresh avo and cream cheese",
                NutritionalValues = "Cal: 196; Fat: 12g; Sod: 1125mg; Carb: 10.9g; Prot: 11.9g"
            });

            prod.Add(new Product()
            {
                ProductId = 41,
                CategoryId = 4,
                ProductName = "Steak Baguette",
                ProductPrice = 95,
                ProductDescription = "Lightly toasted baguette with roast beef, wholegrain mustard, balsamic onions, rocket and mature cheddar",
                NutritionalValues = "Cal: 712; Fat: 27,6g; Sod: 1135mg; Chol: 91mg; CarbL 76,7g; Prot: 39.5g"
            });

            prod.Add(new Product()
            {
                ProductId = 50,
                CategoryId = 5,
                ProductName = "Beef Burger",
                ProductPrice = 95,
                ProductDescription = "150g beef paty tomato, onion, lettuce, gherkins with oyr \"Famous\" sauce on a sesame seed bun",
                NutritionalValues = "Cal: 769: Fat: 39.4g; Sod: 766mg; Chol: 40mg; Calrb: 63.,4g; Prot: 40.7g"
            });

            prod.Add(new Product()
            {
                ProductId = 51,
                CategoryId = 5,
                ProductName = "Chicken Burger",
                ProductPrice = 80,
                ProductDescription = "Grilled or crumbed chickenbreast, tomato, lettuce, onion, peppadews, feta and lemon & herb dressing",
                NutritionalValues = "Cal: 600; Fat: 24.8g; 918mg: Chol: 127mg; Carb: 51.2g; Prot: 41.4g"
            });

            prod.Add(new Product()
            {
                ProductId = 52,
                CategoryId = 5,
                ProductName = "Famous Burger",
                ProductPrice = 118,
                ProductDescription = "2x150g beef patties, grilled tomato, expresso marinated bacon, mature cheddar, gherkins and our famous sauce on a sesame seed bun",
                NutritionalValues = "Cal: 1000; Fat: 49.5g; Sod: 1488mg; Chol: 186mg; Carb: 60.6g; Prot: 73.8g"
            });

            prod.Add(new Product()
            {
                ProductId = 60,
                CategoryId = 6,
                ProductName = "Smoked Chicken & Asparagus",
                ProductPrice = 53,
                ProductDescription = "Smoked chicken topped with asparagus served with a tangy mayo on a bed of fresh greens",
                NutritionalValues = "Cal: 480; Fat: 22,4g; Sod: 1806mg; Chol: 180mg; Carb: 42.7g; Prot: 17.2g"
            });

            prod.Add(new Product()
            {
                ProductId = 61,
                CategoryId = 6,
                ProductName = "Breakfast Bagel",
                ProductPrice = 69,
                ProductDescription = "Creamy herb scrambled eggs, topped with crispy bacon and grilled mushroom",
                NutritionalValues = "Cal: 481; Fat: 26.4; Sod:1646mg; Chol: 72mg; Carb: 31.2g; Prot: 29.7g"
            });

            prod.Add(new Product()
            {
                ProductId = 70,
                CategoryId = 7,
                ProductName = "Halloumi & Avo",
                ProductPrice = 69,
                ProductDescription = "Pan fried halloumi with spicy mayo and avocado",
                NutritionalValues = "Cal: 606; Fat: 42.6g; Sod: 1078mg; Chol: 79mg; Carb: 21.8g; Proot: 35.5g"
            });

            prod.Add(new Product()
            {
                ProductId = 71,
                CategoryId = 7,
                ProductName = "Sunup",
                ProductPrice = 80,
                ProductDescription = "Filled with scrambled egg, bacon, caeamelised onion, roasted cherry tomatoes. Crisp rocket and cheddar",
                NutritionalValues = "Cal: 628; Fat 37.5g; Sod: 1333mg; Chol: 393mg; Carb: 34g; Prot: 34.8g"
            });

            prod.Add(new Product()
            {
                ProductId = 80,
                CategoryId = 8,
                ProductName = "Grilled or Crumbed Chicken",
                ProductPrice = 89,
                ProductDescription = "Your choice of grilled or crumbed free ranged chicken breast served with fresh tomato & olive",
                NutritionalValues = "Cal: 494; Fat: 21,6g; Sod: 582mg; Chol: 285mg Carb: 28.5; Prot: 46.4g"
            });

            prod.Add(new Product()
            {
                ProductId = 81,
                CategoryId = 8,
                ProductName = "Battered Hakes",
                ProductPrice = 79,
                ProductDescription = "Baby hake fillets battered and served with salad or veg, chips & light lemon herb mayo",
                NutritionalValues = "Cal: 736; Fat: 35g; Sod: 844mg; Chol: 50mg; Carb: 83.2g; Prot: 24.6g"
            });

            prod.Add(new Product()
            {
                ProductId = 90,
                CategoryId = 9,
                ProductName = "Sticky BBQ Ribs",
                ProductPrice = 95,
                ProductDescription = "300g Sticky BBQ ribs served with chips and BBQ or chilli dip",
                NutritionalValues = "Cal: 4397; Fat: 6g; Sod: 288mg; Chol: 0g; Carb: 857g; Prot: 157g"
            });

            prod.Add(new Product()
            {
                ProductId = 91,
                CategoryId = 9,
                ProductName = "Samoosas Basket",
                ProductPrice = 50,
                ProductDescription = "Chicken or beef samoosas served with chips and a sweet chilli dip",
                NutritionalValues = "Cal: 955; Fat: 51.6; Sod: 1346mg; Chol: 45mg; Carb: 108g; Prot: 14.6g"
            });

            prod.Add(new Product()
            {
                ProductId = 100,
                CategoryId = 10,
                ProductName = "Classic Belgian",
                ProductPrice = 40,
                ProductDescription = "Belgian waffle  topped with vanilla ice cream and drizzled chocolate sauce. Served with syrup or honey",
                NutritionalValues = "Cal: 549; Fat: 25,5g; Sod: 450mg; Chol: 82mg; Carb: 72,1g; Prot: 10.2g"
            });

            prod.Add(new Product()
            {
                ProductId = 101,
                CategoryId = 10,
                ProductName = "Strawberry & Banana Delight",
                ProductPrice = 55,
                ProductDescription = "Belgian waffle topped with fresh or grilled banana, strawberries and cinnamon. Served with honey or syrup",
                NutritionalValues = "Cal: 548; Fat: 23.9g; Sod: 1078mg; Chol: 85mg; Carb: 27.6g; Prot: 1.5g"
            });

            prod.Add(new Product()
            {
                ProductId = 110,
                CategoryId = 10,
                ProductName = "Fries",
                ProductPrice = 25,
                ProductDescription = "300g Bowl of potato fries",
                NutritionalValues = ""
            });




            #endregion


            ProductCollectionList.ItemsSource = prod;
        }


    }
}
