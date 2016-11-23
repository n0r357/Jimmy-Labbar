using Labb7.Classes;
using Labb7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    class UI
    {
        public static ConsoleKey MainMenu(List<Product> inputProductList, List<Product> inputShoppingList)
        {
            PrintProductList(inputProductList);
            Console.WriteLine("Total cost: {0}", inputShoppingList.Sum(cost => cost.Price));
            LargeMenuBar();
            Console.WriteLine("1 - Add item to cart");
            Console.WriteLine("2 - Remove item from cart");
            Console.WriteLine("3 - Add product");
            Console.WriteLine("4 - Remove product");
            Console.WriteLine("5 - Quit program");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }
        public static Product AddProductToList()
        {
            Console.WriteLine("Category:");
            SmallMenuBar();
            Console.WriteLine("1 - Drink");
            Console.WriteLine("2 - Food");
            Console.WriteLine("3 - Gear");
            SmallMenuBar();
            Console.Write("Choice: ");
            ConsoleKey input = Console.ReadKey().Key;
            switch (input)
                {
                case ConsoleKey.D1:
                    Drink newDrink = new Drink();
                    newDrink.ProductInformation = AskForName();
                    newDrink.Category = newDrink.GetCategory();
                    newDrink.Price = AskForPrice();
                    return newDrink;
                case ConsoleKey.D2:
                    Food newFood = new Food();
                    newFood.ProductInformation = AskForName();
                    newFood.Category = newFood.GetCategory();
                    newFood.Price = AskForPrice();
                    return newFood;
                case ConsoleKey.D3:
                    Gear newGear = new Gear();
                    newGear.ProductInformation = AskForName();
                    newGear.Category = newGear.GetCategory();
                    newGear.Price = AskForPrice();
                    return newGear;
                default:
                    return null;
                }
            
        }
        private static string AskForName()
        {
            Console.WriteLine();
            SmallMenuBar();
            Console.Write("Name: ");
            string input = Console.ReadLine();
            return input;
        }
        private static double AskForPrice()
        {
            Console.WriteLine();
            SmallMenuBar();
            Console.Write("Price: ");
            double input = int.Parse(Console.ReadLine());
            return input;
        }
        public static int SelectProductFromList(List<Product> inputProductList)
        {
            PrintProductList(inputProductList);
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine()) - 1;
            return choice;
        }
        public static void PrintProductList(List<Product> inputProductList)
        {
            Console.Clear();
            ListMenuBar();
            for (int i = 0; i < inputProductList.Count; i++)
            {
                Console.WriteLine("{0,-5}\t{1}", i + 1, inputProductList[i].ToString());
            }
            LargeMenuBar();
        }
        private static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }
        private static void ListMenuBar()
        {
            LargeMenuBar();
            Console.WriteLine("{0,-5}\t{1,-15}\t{2,-10}\t{3,-5}", "Index:", "Name:", "Category:", "Price:");
            LargeMenuBar();
        }
        private static void SmallMenuBar()
        {
            Console.WriteLine("-------------------------");
        }
        private static void LargeMenuBar()
        {
            Console.WriteLine("----------------------------------------------");
        }
    }
}
