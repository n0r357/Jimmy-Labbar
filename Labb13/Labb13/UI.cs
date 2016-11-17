using Labb13.Managers;
using Labb13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13
{
    class UI
    {
        public static ConsoleKey PrintMainMenu(List<Item> inputList)
        {
            PrintList(inputList);
            SmallMenuBar();
            Console.WriteLine("   1 - Add item");
            Console.WriteLine("   2 - Show bars");
            Console.WriteLine("   3 - Show drinks");
            Console.WriteLine("   4 - Exit program");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }
        public static void PrintList(List<Item> inputList)
        {
            Console.Clear();
            ListMenuBar();
            foreach (var item in inputList)
            {
                Console.WriteLine(item.ToString());
            }
            LargeMenuBar();
        }
        public static string AskForName()
        {
            bool loop = true;
            var input = new Item();
            var nameEvent = new ItemManager();

            nameEvent.RightInputEvent += (source, e) =>
            {
                loop = false;
            };
            nameEvent.WrongInputEvent += (source, e) =>
            {
                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Name must be more than 2 letters.");
                Console.WriteLine("---------------------------------");
                UI.PressKeyToContinue();
            };

            while (loop)
            {
                try
                {
                    Console.Clear();
                    AddingItem();
                    Console.Write("    Name: ");
                    input.Name = Console.ReadLine();
                    nameEvent.CheckNameInput(input.Name.Length);
                }
                catch (Exception)
                {
                    nameEvent.CheckNameInput(input.Name.Length);
                }
            }
            return input.Name;
        }
        public static Item.Types AskForType()
        {
            bool loop = true;
            var input = new Item();
            var typeEvent = new ItemManager();

            typeEvent.RightInputEvent += (source, e) =>
            {
                loop = false;
            };
            typeEvent.WrongInputEvent += (source, e) =>
            {
                SmallMenuBar();
                Console.WriteLine("    Invalid choice!");
                UI.PressKeyToContinue();
            };

            while (loop)
            {
                try
                {
                    Console.Clear();
                    AddingItem();
                    Console.WriteLine("\tTypes:");
                    SmallMenuBar();
                    foreach (var type in Enum.GetValues(typeof(Item.Types)))
                    {
                        Console.WriteLine("    {0} - {1}", (int)type, type);
                    }
                    SmallMenuBar();
                    Console.Write("    Choice: ");
                    input.Type = (Item.Types)int.Parse(Console.ReadLine());
                    typeEvent.CheckTypeInput(input.Type);
                }
                catch (Exception)
                {
                    typeEvent.CheckTypeInput(input.Type);
                }
            }
            return input.Type;
        }
        public static int AskForPrice()
        {
            bool loop = true;
            var input = new Item();
            var priceEvent = new ItemManager();

            priceEvent.RightInputEvent += (source, e) =>
            {
                loop = false;
            };
            priceEvent.WrongInputEvent += (source, e) =>
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("The price must be a number between 1 and 9999.");
                Console.WriteLine("----------------------------------------------");
                UI.PressKeyToContinue();
            };

            while (loop)
            {
                try
                {
                    Console.Clear();
                    AddingItem();
                    Console.Write("    Price: ");
                    input.Price = int.Parse(Console.ReadLine());
                    priceEvent.CheckPriceInput(input.Price);
                }
                catch (Exception)
                {
                    priceEvent.CheckPriceInput(input.Price);
                }
            }
            return input.Price;
        }
        public static void PressKeyToContinue()
        {
            SmallMenuBar();
            Console.WriteLine("Press key to continue.");
            SmallMenuBar();
            Console.ReadKey();
        }
        private static void ListMenuBar()
        {
            LargeMenuBar();
            Console.WriteLine("{0,-15}\t{1,-15}\t{2,-5}", "Name:", "Type:", "Price:");
            LargeMenuBar();
        }
        private static void AddingItem()
        {
            SmallMenuBar();
            Console.WriteLine("Enter item information.");
            SmallMenuBar();
        }
        private static void SmallMenuBar()
        {
            Console.WriteLine("-----------------------");
        }
        private static void LargeMenuBar()
        {
            Console.WriteLine("--------------------------------------");
        }
    }
}
