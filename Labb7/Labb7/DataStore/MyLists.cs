using Labb7.Classes;
using Labb7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7.Managers
{
    class MyLists
    {
        public List<Product> ProductList { get; set; }
        public List<Product> ShoppingList { get; set; }

        public MyLists()
        {
            Drink drink = new Drink();
            Food food = new Food();
            Gear gear = new Gear();

            ProductList = new List<Product>()
            {
                new Drink { ProductInformation = "CleanFit", Category = drink.GetCategory(), Price = 20 },
                new Drink { ProductInformation = "NOCCO", Category = drink.GetCategory(), Price = 25 },
                new Food { ProductInformation = "Quest Bar", Category = food.GetCategory(), Price = 25 },
                new Food { ProductInformation = "Paleo Crunch", Category = food.GetCategory(), Price = 20 },
                new Gear { ProductInformation = "Lacrosse Ball", Category = gear.GetCategory(), Price = 50 },
                new Gear { ProductInformation = "Floss Band", Category = gear.GetCategory(), Price = 100 }
            };
            ShoppingList = new List<Product>();
        }

        public void AddProduct()
        {
            ProductList.Add(UI.AddProductToList());
        }

        public void RemoveProduct()
        {
            ProductList.RemoveAt(UI.SelectProductFromList(ProductList));
        }

        public void AddToCart()
        {
            ShoppingList.Add(ProductList.ElementAt(UI.SelectProductFromList(ProductList)));
        }

        public void RemoveFromCart()
        {
            ShoppingList.RemoveAt(UI.SelectProductFromList(ShoppingList));
        }
    }
}
