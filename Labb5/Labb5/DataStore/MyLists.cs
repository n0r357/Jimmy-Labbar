using Labb5.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.DataStore
{
    class MyLists
    {

        #region Lists

        private static List<Item> books = new List<Item>()
        {
            new Book { Genre = Book.Genres.Crime , Title = "Crime Title", Price = 199 }
        };
        private static List<Item> games = new List<Item>()
        {
            new Game { Genre  = Game.Genres.Roleplaying, Title = "RPG Title", Price = 499 }
        };
        private static List<Item> movies = new List<Item>()
        {
            new Movie { Genre = Movie.Genres.Fantasy , Title = "Fantasy Title", Price = 299 }
        };

        #endregion

        #region ListProperties

        public static List<Item> Books
        {
            get
            {
                return books;
            }
        }
        public static List<Item> Games
        {
            get
            {
                return games;
            }
        }
        public static List<Item> Movies
        {
            get
            {
                return movies;
            }
        }

        #endregion

        #region FileTests

        private static string StringGenre { get; set; }
        private static string StringTitle { get; set; }
        private static string StringPrice { get; set; }

        public static List<string> StringList = new List<string>()
        { StringGenre, StringTitle, StringPrice };

        //  Vill konvertera List<string> till List<Book>
        public static List<Book> ConvertBookListFromFile()
        {
            return LoadBookListFromFile().Select(list => new Book()
            {
                Genre = (Book.Genres)list[0],
                Title = (Convert.ToString(list[1])),
                Price = (int)list[2]
            }
            ).ToList();
        }
        //  Vill konvertera List<Item> till List<string>
        public static void ConvertBookListToFile(Item[] inputList)
        {
            foreach (var item in inputList)
            {
                StringList.Add(StringGenre = Convert.ToString(item.Genre));
                StringList.Add(StringTitle = Convert.ToString(item.Title));
                StringList.Add(StringPrice = Convert.ToString(item.Price));
            }
            SaveBookListToFile();
            var books = StringList;
            foreach (var book in books)
            {
                Console.WriteLine("{0}\t{1}\t{2}", StringGenre, StringList, StringPrice);
            }
            foreach (var item in StringList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static List<string> LoadBookListFromFile()
        {
            return StringList = File.ReadAllLines(@"Lists\BookList.txt").ToList();
        }
        private static void SaveBookListToFile()
        {
            File.WriteAllLines(@"Lists\BookList.txt", StringList);
        }
        public static void SaveGameListToFile()
        {

        }
        public static void SaveMovieListToFile()
        {

        }

        #endregion

    }
}
