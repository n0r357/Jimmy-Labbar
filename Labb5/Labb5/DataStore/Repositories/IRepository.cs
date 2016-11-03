using Labb5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Controllers.Repositories
{
    interface IRepository
    {
        Item[] GetBookList();
        Item[] GetGameList();
        Item[] GetMovieList();
        void AddBook(Item newBook);
        void AddGame(Item newGame);
        void AddMovie(Item newMovie);
        void RemoveBook(Item book);
        void RemoveGame(Item game);
        void RemoveMovie(Item movie);
    }
}
