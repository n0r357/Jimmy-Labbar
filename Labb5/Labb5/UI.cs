using Labb5.DataStore;
using Labb5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class UI
    {
        #region Properties

        private static int Input { get; set; }
        private static string Title { get; set; }

        #endregion

        #region Menus

        public static void MainMenu()
        {
            Console.Clear();
            MenuBar();
            Console.WriteLine("\t\t1 - Add Item");
            Console.WriteLine("\t\t2 - Remove Item");
            Console.WriteLine("\t\t3 - Edit Item");
            Console.WriteLine("\t\t4 - Show Lists");
            Console.WriteLine("\t\t5 - Exit");
            AskForInput();
        }
        public static void AddItemMenu()
        {
            Console.Clear();
            MenuBar();
            Console.WriteLine("\t\t1 - Add Book");
            Console.WriteLine("\t\t2 - Add Game");
            Console.WriteLine("\t\t3 - Add Movie");
            AskForInput();
        }
        public static void RemoveItemMenu()
        {
            Console.Clear();
            MenuBar();
            Console.WriteLine("\t\t1 - Remove Book");
            Console.WriteLine("\t\t2 - Remove Game");
            Console.WriteLine("\t\t3 - Remove Movie");
            AskForInput();
        }
        public static void EditItemMenu()
        {
            Console.Clear();
            MenuBar();
            Console.WriteLine("\t\t1 - Edit Book");
            Console.WriteLine("\t\t2 - Edit Game");
            Console.WriteLine("\t\t3 - Edit Movie");
            AskForInput();
        }
        public static void EditItem(Item inputItemType)
        {
            Console.Clear();
            MenuBar();
            Console.WriteLine("\t\t1 - Edit Title");
            Console.WriteLine("\t\t2 - Edit Genre");
            Console.WriteLine("\t\t3 - Edit Price");
            AskForInput();
            var input = Console.ReadKey(false).Key;

            switch (input)
            {
                case ConsoleKey.D1: //  Edit Title
                    inputItemType.Title = AskForTitle();
                    MenuBar();
                    break;
                case ConsoleKey.D2: //  Edit Genre
                    inputItemType.Genre = (Item.Genres)AskForGenre(inputItemType.GenreList());
                    NewLineMenuBar();
                    break;
                case ConsoleKey.D3: //  Edit Price
                    inputItemType.Price = AskForPrice();
                    MenuBar();
                    break;
                default:
                    UI.InvalidChoice();
                    break;
            }
        }
        public static void ShowListMenu()
        {
            Console.Clear();
            MenuBar();
            Console.WriteLine("\t\t1 - Show Book List");
            Console.WriteLine("\t\t2 - Show Game List");
            Console.WriteLine("\t\t3 - Show Movie List");
            AskForInput();
        }
        public static void PrintGenreMenuBar()
        {
            Console.Clear();
            MenuBar();
            Console.WriteLine(StringFormat(), "Index:", "Title:", "Genre:", "Price:");
            MenuBar();
        }
        public static int ReturnChoice(int inputNumberOfChoices)
        {
            AskForInput();
            return (ConvertCharToString());
        }

        #endregion

        #region AddItems

        public static Book AddBook()
        {
            Book newBook = new Models.Book();
            newBook.Title = AskForTitle();
            newBook.Genre = (Book.Genres)AskForGenre(newBook.GenreList());
            newBook.Price = AskForPrice();
            ItemAdded();
            return newBook;
        }
        public static Game AddGame()
        {
            Game newGame = new Models.Game();
            newGame.Title = AskForTitle();
            newGame.Genre = (Game.Genres)AskForGenre(newGame.GenreList());
            newGame.Price = AskForPrice();
            ItemAdded();
            return newGame;
        }
        public static Movie AddMovie()
        {
            Movie newMovie = new Models.Movie();
            newMovie.Title = AskForTitle();
            newMovie.Genre = (Movie.Genres)AskForGenre(newMovie.GenreList());
            newMovie.Price = AskForPrice();
            ItemAdded();
            return newMovie;
        }

        #endregion

        #region InputCommands

        public static void AskForInput()
        {
            MenuBar();
            Console.Write("\t\tChoice: ");
        }
        private static string AskForTitle()
        {
            bool loop = true;

            while (loop)
            {
                try
                {
                    Console.Clear();
                    MenuBar();
                    Console.Write("\t\tTitle: ");
                    Title = Console.ReadLine();
                    if (Title.Length != 0)
                    {
                        loop = false;
                    }
                }
                catch (Exception)
                {
                    InvalidChoice();
                    loop = true;
                }
            }
            return Title;
        }
        private static int AskForGenre(string[] inputGenreList)
        {
            bool loop = true;

            while (loop)
            {
                try
                {
                    Console.Clear();
                    MenuBar();
                    Console.WriteLine("\t\tChoose genre:");
                    PrintGenres(inputGenreList);
                    AskForInput();
                    Input = ConvertCharToString();
                    loop = MenuErrorHandling(Input, inputGenreList.Count());
                }
                catch (Exception)
                {
                    InvalidChoice();
                    loop = true;
                }
            }
            return Input;
        }
        private static void PrintGenres(string[] inputGenreList)
        {
            MenuBar();
            foreach (var genre in inputGenreList)
            {
                Console.WriteLine("\t\t{0}", genre);
            }
        }
        private static int AskForPrice()
        {
            bool loop = true;

            while (loop)
            {
                try
                {
                    Console.Clear();
                    MenuBar();
                    Console.Write("\t\tPrice: ");
                    Input = int.Parse(Console.ReadLine());
                    if (Input != 0)
                    {
                        loop = false;
                    }
                }
                catch (Exception)
                {
                    InvalidChoice();
                    loop = true;
                }
            }
            return Input;
        }

        #endregion

        #region Conversion, ErrorHandling and Format

        private static int ConvertCharToString()
        {
            return int.Parse(Convert.ToString(Console.ReadKey(false).Key).Split('D')[1]);
        }
        private static bool MenuErrorHandling(int inputChoice, int inputNumberOfSelections)
        {
            int firstMenuChoice = 1;

            if (inputChoice >= firstMenuChoice && inputChoice <= inputNumberOfSelections)
            {
                return false;
            }
            return true;
        }
        public static string StringFormat()
        {
            string stringFormat = "{0,-5}\t{1,-15}\t{2,-10}\t{3,-5}";
            return stringFormat;
        }

        #endregion

        #region Messages

        private static void ItemAdded()
        {
            MenuBar();
            Console.WriteLine("\t     Item added to list.");
            PressKey();
        }
        public static void ItemRemoved()
        {
            NewLineMenuBar();
            Console.WriteLine("\t    Item removed from list.");
            PressKey();
        }
        public static void ItemEdited()
        {
            Console.WriteLine("\t\tItem edited.");
            PressKey();
        }
        public static void PressKey()
        {
            MenuBar();
            Console.WriteLine("\t    Press key to continue.");
            Console.ReadKey();
        }
        public static void InvalidChoice()
        {
            NewLineMenuBar();
            Console.WriteLine("\t       Invalid choice!");
            PressKey();
        }

        #endregion

        #region MenuBars

        private static void MenuBar()
        {
            Console.WriteLine("----------------------------------------------");
        }
        private static void NewLineMenuBar()
        {
            Console.WriteLine("\n----------------------------------------------");
        }

        #endregion

    }
}
