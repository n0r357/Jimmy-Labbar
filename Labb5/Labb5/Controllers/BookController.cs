using Labb5.Controllers.Repositories;
using Labb5.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Models
{
    class BookController
    {
        private IRepository bookRepository = new ListRepository();

        public void NewBook()
        {
            var newBook = UI.AddBook();
            bookRepository.AddBook(newBook);
        }

        public void RemoveBook()
        {
            bool loop = true;

            while (loop)
            {
                try
                {
                    var books = PrintBookList();
                    var index = UI.ReturnChoice(books.Count()) - 1;
                    if (index < books.Count())
                    {
                        bookRepository.RemoveBook(books[index]);
                        UI.ItemRemoved();
                        loop = false;
                    }
                    else if (books.Count() == 0)
                    {
                        loop = false;
                    }
                }
                catch (Exception)
                {
                    loop = true;
                }
            }
        }

        public void EditBook()
        {
            bool loop = true;

            while (loop)
            {
                try
                {
                    var books = PrintBookList();
                    var index = UI.ReturnChoice(books.Count()) - 1;
                    if (index < books.Count())
                    {
                        UI.EditItem(books[index]);
                        loop = false;
                    }
                    else
                    {
                        UI.InvalidChoice();
                    }
                }
                catch (Exception)
                {
                    loop = true;
                }
            }
            UI.ItemEdited();
        }

        public Item[] PrintBookList()
        {
            UI.PrintGenreMenuBar();
            var books = bookRepository.GetBookList();
            foreach (var book in books)
            {
                Console.WriteLine(UI.StringFormat(), Array.IndexOf(books, book) + 1, book.Title, book.Genre, book.Price);
            }
            return books;
        }
    }
}
