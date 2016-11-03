using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb5.Models;
using Labb5.DataStore;

namespace Labb5.Controllers.Repositories
{
    class ListRepository : IRepository
    {
        public void AddBook(Item newBook)
        {
            MyLists.Books.Add(newBook);
            //MyLists.ConvertBookListToFile(GetBookList());
        }

        public void AddGame(Item newGame)
        {
            MyLists.Games.Add(newGame);
        }

        public void AddMovie(Item newMovie)
        {
            MyLists.Movies.Add(newMovie);
        }

        public Item[] GetBookList()
        {
            //return MyLists.ConvertBookListFromFile().ToArray();
            return MyLists.Books.ToArray();
        }

        public Item[] GetGameList()
        {
            return MyLists.Games.ToArray();
        }

        public Item[] GetMovieList()
        {
            return MyLists.Movies.ToArray();
        }

        public void RemoveBook(Item book)
        {
            MyLists.Books.Remove(book);
        }

        public void RemoveGame(Item game)
        {
            MyLists.Games.Remove(game);
        }

        public void RemoveMovie(Item movie)
        {
            MyLists.Movies.Remove(movie);
        }
    }
}
