using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    class BookManager
    {
        public List<Book> Books { get; set; }

        public BookManager()
        {
            Books = new List<Book>()
            {
            new Book { Title = "Den perfekta kvinnan", Genre = "Fantasy", Pages = 50, Price = 60 },
            new Book { Title = "Fäbojäntan", Genre = "Romance", Pages = 100, Price = 80 },
            new Book { Title = "Kvinnor", Genre = "Mystery", Pages = 200, Price = 120 },
            new Book { Title = "Bibeln", Genre = "Fantasy", Pages = 666, Price = 230 }
            };
        }

        public void PrintWhere(BookFilter filter)
        {
            foreach (var book in Books)
            {
                if (filter(book))
                {
                    Console.WriteLine(book.Title);
                }
            }
        }
    }
}
