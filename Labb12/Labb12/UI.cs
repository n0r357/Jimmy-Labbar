using Labb12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12
{
    class UI
    {
        public static ConsoleKey PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main menu:");
            Console.WriteLine("1 - Get movie by title");
            Console.WriteLine("2 - Get movies by genre");
            Console.WriteLine("3 - Get movies over chosen length");
            Console.WriteLine("4 - Create and print movie title string array");
            Console.WriteLine("5 - Save and print title in a string variable");
            Console.WriteLine("6 - Get all movies starting with a letter of your choice");
            Console.WriteLine("7 - Quit program");
            ConsoleKey choice = Console.ReadKey(true).Key;
            return choice;
        }
        public static void PrintMovieList(List<Movie> inputMovieList)
        {
            PrintMovieMenuBar();
            foreach (var movie in inputMovieList)
            {
                Console.WriteLine(movie.ToString());
            }
        }
        public static Movie GetMovieByTitle(List<Movie> inputMovieList)
        {
            Console.Write("Title: ");
            string input = Console.ReadLine();
            Movie getMovieByTitle = inputMovieList.SingleOrDefault(movie => movie.Title.Contains(input));
            Console.WriteLine(getMovieByTitle.ToString());
            return getMovieByTitle;
        }
        public static void PrintMovieMenuBar()
        {
            Console.WriteLine("{0,-15}\t{1,-10}\t{2,-5}", "Title:", "Genre:", "Length:");
        }
        public static void PressKeyToContinue()
        {
            Console.WriteLine("Press key to continue.");
            Console.ReadKey();
        }           
    }
}
