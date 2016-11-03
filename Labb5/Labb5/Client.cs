using Labb5.Controllers;
using Labb5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Client
    {
        public void Start()
        {
            var books = new BookController();
            var games = new GameController();
            var movies = new MovieController();

            bool loop = true;

            while (loop)
            {
                UI.MainMenu();
                var input = Console.ReadKey(false).Key;
                switch (input)
                {
                    case ConsoleKey.D1: //  Add Item
                        UI.AddItemMenu();
                        input = Console.ReadKey(false).Key;

                        switch (input)
                        {
                            case ConsoleKey.D1: //  Add Book
                                books.NewBook();
                                break;
                            case ConsoleKey.D2: //  Add Game
                                games.NewGame();
                                break;
                            case ConsoleKey.D3: //  Add Movie
                                movies.NewMovie();
                                break;
                            default:
                                UI.InvalidChoice();
                                break;
                        }
                        break;
                    case ConsoleKey.D2: //  Remove Item
                        UI.RemoveItemMenu();
                        input = Console.ReadKey(false).Key;

                        switch (input)
                        {
                            case ConsoleKey.D1: //  Add Book
                                books.RemoveBook();
                                break;
                            case ConsoleKey.D2: //  Add Game
                                games.RemoveGame();
                                break;
                            case ConsoleKey.D3: //  Add Movie
                                movies.RemoveMovie();
                                break;
                            default:
                                UI.InvalidChoice();
                                break;
                        }
                        break;
                    case ConsoleKey.D3: //  Edit Item
                        UI.EditItemMenu();
                        input = Console.ReadKey(false).Key;

                        switch (input)
                        {
                            case ConsoleKey.D1: //  Edit Book List
                                books.EditBook();
                                break;
                            case ConsoleKey.D2: //  Edit Game List
                                games.EditGame();
                                break;
                            case ConsoleKey.D3: //  Edit Movie List
                                movies.EditBook();
                                break;
                            default:
                                UI.InvalidChoice();
                                break;
                        }
                        break;
                    case ConsoleKey.D4: //  Show Lists
                        UI.ShowListMenu();
                        input = Console.ReadKey(false).Key;

                        switch (input)
                        {
                            case ConsoleKey.D1: //  Show Book List
                                books.PrintBookList();
                                UI.PressKey();
                                break;
                            case ConsoleKey.D2: //  Show Game List
                                games.PrintGameList();
                                UI.PressKey();
                                break;
                            case ConsoleKey.D3: //  Show Movie List
                                movies.PrintMovieList();
                                UI.PressKey();
                                break;
                            default:
                                UI.InvalidChoice();
                                break;
                        }
                        break;
                    case ConsoleKey.D5: //  Exit
                        loop = false;
                        break;
                    default:
                        UI.InvalidChoice();
                        break;
                }
            }
        }
    }
}
