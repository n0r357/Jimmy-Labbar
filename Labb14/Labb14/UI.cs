using Labb14.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    class UI
    {
        public static ConsoleKey PrintMainMenu()
        {
            Console.Clear();
            SmallMenuBar();
            Console.WriteLine("   1 - Authors");
            Console.WriteLine("   2 - Publications");
            Console.WriteLine("   3 - Search Menu");
            Console.WriteLine("   4 - Exit program");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }
        public static void PrintAuthorList(ListManager inputManager)
        {
            Console.Clear();
            SmallMenuBar();
            Console.WriteLine("{0,-15}\t{1,-5}", "Name:", "Age:");
            SmallMenuBar();
            foreach (var publication in inputManager.AuthorList)
            {
                Console.WriteLine(publication.ToString());
            }
            SmallMenuBar();
            PressKeyToContinue();
        }
        public static void PrintPublicationList(ListManager inputManager)
        {
            Console.Clear();
            LargeMenuBar();
            Console.WriteLine("{0,-15}\t{1,-20}\t{2,-10}\t{3,-10}\t{4,-5}", "Name:", "Title:", "Release Date:", "Genre:", "Pages:");
            LargeMenuBar();
            foreach (var publication in inputManager.PublicationList)
            {
                Console.WriteLine(publication.ToPublicationString());
            }
            LargeMenuBar();
            PressKeyToContinue();
        }
        public static void PrintSearchMenu(ListManager inputManager)
        {
            bool loop = true;
            string input;

            while (loop)
            {
                switch (SearchMenuControl())
                {
                    case ConsoleKey.D1:
                        Console.Write("   Name: ");
                        input = Console.ReadLine();
                        PrintPublicationList(inputManager.SearchAuthor(input.ToUpper()));
                        break;
                    case ConsoleKey.D2:
                        Console.Write("   Title: ");
                        input = Console.ReadLine();
                        PrintPublicationList(inputManager.SearchPublication(input.ToUpper()));
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private static ConsoleKey SearchMenuControl()
        {
            Console.Clear();
            MediumMenuBar();
            Console.WriteLine("   1 - Search Author");
            Console.WriteLine("   2 - Search Publication");
            Console.WriteLine("   3 - Main Menu");
            MediumMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }
        private static void PressKeyToContinue()
        {
            SmallMenuBar();
            Console.WriteLine("Press key to continue.");
            SmallMenuBar();
            Console.ReadKey();
        }
        private static void SmallMenuBar()
        {
            Console.WriteLine("----------------------");
        }
        private static void MediumMenuBar()
        {
            Console.WriteLine("----------------------------");
        }
        private static void LargeMenuBar()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}
