using Labb12.Manager;
using Labb12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb12.Models.Movie;

namespace Labb12
{
    class Runtime
    {
        public void Start()
        {
            bool loop = true;
            var list = new MovieManager();

            while (loop)
            {
                switch (UI.PrintMainMenu())
                {
                    case ConsoleKey.D1: //  Get movie by title
                        Console.Clear();
                        UI.PrintMovieList(list.Movies);
                        Console.Write("Title: ");
                        string input = Console.ReadLine();
                        Movie getMovieByTitle = list.Movies.SingleOrDefault(movie => movie.Title.Contains(input));
                        Console.Clear();
                        UI.PrintMovieMenuBar();
                        Console.WriteLine(getMovieByTitle.ToString());
                        UI.PressKeyToContinue();
                        break;
                    case ConsoleKey.D2: //  Get movies by genre
                        Console.Clear();
                        list.PrintMovieList();
                        Console.Write("Genre: ");
                        input = Console.ReadLine();
                        List<Movie> getMoviesByGenre = list.Movies.Where(genre => String.Equals(genre.Genre.ToString(), input)).ToList();
                        Console.Clear();
                        UI.PrintMovieMenuBar();
                        foreach (var movie in getMoviesByGenre)
                        {
                            Console.WriteLine(movie.ToString());
                        }
                        UI.PressKeyToContinue();
                        break;
                    case ConsoleKey.D3: //  Get movies > 120 min
                        Console.Clear();
                        list.PrintMovieList();
                        Console.Write("Length: ");
                        int inputLength= int.Parse(Console.ReadLine());
                        List<Movie> getMoviesByLength = list.Movies.FindAll(movies => movies.Length > inputLength);
                        Console.Clear();
                        UI.PrintMovieMenuBar();
                        foreach (var movie in getMoviesByLength)
                        {
                            Console.WriteLine(movie.ToString());
                        }
                        UI.PressKeyToContinue();
                        break;
                    case ConsoleKey.D4: //  Create and print movie title string array
                        Console.Clear();
                        string[] getMovieTitleList = list.Movies.Select(movie => movie.Title).ToArray();          
                        Console.WriteLine("Title string array:");
                        foreach (var title in getMovieTitleList)
                        {
                            Console.WriteLine(title);
                        }
                        UI.PressKeyToContinue();
                        break;
                    case ConsoleKey.D5: //  Save and print title in a string variable
                        Console.Clear();
                        list.PrintMovieList();
                        Console.Write("Title: ");
                        input = Console.ReadLine();
                        getMovieByTitle = list.Movies.SingleOrDefault(movie => movie.Title.Contains(input));
                        string stringTitle = getMovieByTitle.ToString();
                        Console.Clear();
                        UI.PrintMovieMenuBar();
                        Console.WriteLine(stringTitle);
                        UI.PressKeyToContinue();
                        break;
                    case ConsoleKey.D6: //  Get all movies starting with a letter of your choice
                        Console.Clear();
                        list.PrintMovieList();
                        Console.Write("Letter: ");
                        input = Console.ReadLine().ToUpper();
                        List<Movie> getMoviesByLetter = list.Movies.Where(movie => movie.Title.StartsWith(input)).ToList();
                        Console.Clear();
                        UI.PrintMovieMenuBar();
                        foreach (var movie in getMoviesByLetter)
                        {
                            Console.WriteLine(movie.ToString());
                        }
                        UI.PressKeyToContinue();
                        break;
                    case ConsoleKey.D7: //  Quit program
                        loop = false;
                        break;
                    default:
                        break;
                }
            }



        }
    }
}
