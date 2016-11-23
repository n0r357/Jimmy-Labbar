using Labb16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16
{
    class UI
    {
        public static ConsoleKey MainMenu()
        {
            Console.Clear();
            SmallMenuBar();
            Console.WriteLine("1 - Show list");
            Console.WriteLine("2 - Add item to list");
            Console.WriteLine("3 - Edit item in list");
            Console.WriteLine("4 - Remove item from list");
            Console.WriteLine("5 - Show list from file");
            Console.WriteLine("6 - Add item to file list");
            Console.WriteLine("7 - Edit item in file list");
            Console.WriteLine("8 - Remove item from file list");
            Console.WriteLine("9 - Exit program");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }
        public static Product AddItem(List<Product> inputProductList)
        {
            var item = new Product();
            item.ID = CheckIndex(inputProductList);
            Console.Write("Name: ");
            item.Name = Console.ReadLine();
            return item;
        }
        private static int CheckIndex(List<Product> inputProductList)
        {
            for (int i = 1; i <= inputProductList.Count; i++)
            {
                if (!inputProductList.Select(usedID => usedID.ID).Contains(i))
                {
                    return i;
                }
            }
            return inputProductList.Count + 1;
        }
        public static void PrintList(List<Product> inputProductList)
        {
            Console.Clear();
            PrintMenuBar();
            foreach (var item in inputProductList)
            {
                Console.WriteLine(item.ToString());
            }
            SmallMenuBar();
        }
        public static int GetItem(List<Product> inputProductList)
        {
            int choice;

            do
            {
                Console.Clear();
                PrintMenuBar();
                foreach (var item in inputProductList)
                {
                    Console.WriteLine(item.ToString());
                }
                SmallMenuBar();
                Console.Write("Choice: ");
                choice = int.Parse(Console.ReadLine());
            } while (!inputProductList.Select(item => item.ID).Contains(choice));

            return choice;
        }
        private static void PrintMenuBar()
        {
            SmallMenuBar();
            Console.WriteLine("{0,-5}\t{1,-20}", "ID:", "Name:");
            SmallMenuBar();
        }
        private static void SmallMenuBar()
        {
            Console.WriteLine("------------------------------");
        }
        public static void PressAnyKeyToContinue()
        {
            SmallMenuBar();
            Console.WriteLine("Press any key to continue...");
            SmallMenuBar();
            Console.ReadKey();
        }
    }
}
