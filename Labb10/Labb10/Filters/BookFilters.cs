using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10.Filters
{
    class BookFilters
    {
        public static bool IsNovel(Book book)
        {
            return book.Pages > 100;
        }

        public static bool IsShortStory(Book book)
        {
            return book.Pages < 100;
        }

        public static bool IsGenreMystery(Book book)
        {
            return book.Genre == "Mystery";
        }

        public static bool IsGenreFantasy(Book book)
        {
            return book.Genre == "Fantasy";
        }

        public static bool IsGenreRomance(Book book)
        {
            return book.Genre == "Romance";
        }

        public static bool IsCheap(Book book)
        {
            return book.Price < 100;
        }

        public static bool IsExpensive(Book book)
        {
            return book.Price > 100;
        }
    }
}
