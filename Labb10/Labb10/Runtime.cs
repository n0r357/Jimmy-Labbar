using Labb10.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    

    class Runtime
    {
        public void Start()
        {
            BookManager manager = new BookManager();

            BookFilter isNovelFilter = BookFilters.IsNovel;
            BookFilter isShortStoryFilter = BookFilters.IsShortStory;
            BookFilter isMysteryFilter = BookFilters.IsGenreMystery;
            BookFilter isFantasyFilter = BookFilters.IsGenreFantasy;
            BookFilter isRomanceFilter = BookFilters.IsGenreRomance;
            BookFilter isCheapFilter = BookFilters.IsCheap;
            BookFilter isExpensiveFilter = BookFilters.IsExpensive;

            Console.WriteLine("\nNovels:");
            manager.PrintWhere(isNovelFilter);

            Console.WriteLine("\nShort Stories:");
            manager.PrintWhere(isShortStoryFilter);

            Console.WriteLine("\nMystery:");
            manager.PrintWhere(isMysteryFilter);

            Console.WriteLine("\nFantasy:");
            manager.PrintWhere(isFantasyFilter);

            Console.WriteLine("\nRomance:");
            manager.PrintWhere(isRomanceFilter);

            Console.WriteLine("\nCheap:");
            manager.PrintWhere(isCheapFilter);

            Console.WriteLine("\nExpensive:");
            manager.PrintWhere(isExpensiveFilter);
        }
    }
}
