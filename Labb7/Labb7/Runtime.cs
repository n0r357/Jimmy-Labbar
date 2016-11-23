using Labb7.Classes.ShoppingCart;
using Labb7.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    class Runtime
    {
        public void Start()
        {
            bool loop = true;
            MyLists list = new MyLists();

            while (loop)
            {
                switch (UI.MainMenu(list.ProductList, list.ShoppingList))
                {
                    case ConsoleKey.D1: //  Add item to cart
                        list.AddToCart();
                        break;
                    case ConsoleKey.D2: //  Remove item from cart
                        list.RemoveFromCart();
                        break;
                    case ConsoleKey.D3: //  Add product
                        list.AddProduct();
                        break;
                    case ConsoleKey.D4: //  Remove product
                        list.RemoveProduct();
                        break;
                    case ConsoleKey.D5: //  Quit
                        loop = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
