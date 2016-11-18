using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14.Managers
{
    class ListManager
    {
        public List<Publication> PublicationList { get; set; }
        public List<Author> AuthorList { get; set; }

        public ListManager()
        {
            Author author1 = new Author();
            Author author2 = new Author();
            Author author3 = new Author();
            Author author4 = new Author();
            Author author5 = new Author();

            AuthorList = new List<Author>();
            author1.Name = "Author 1";
            author1.Age = 20;
            AuthorList.Add(author1);
            author2.Name = "Author 2";
            author2.Age = 30;
            AuthorList.Add(author2);
            author3.Name = "Author 3";
            author3.Age = 40;
            AuthorList.Add(author3);
            author4.Name = "Author 4";
            author4.Age = 50;
            AuthorList.Add(author4);
            author5.Name = "Author 5";
            author5.Age = 60;
            AuthorList.Add(author5);

            Book book = new Book();
            Magazine magazine = new Magazine();
            Paper paper = new Paper();

            PublicationList = new List<Publication>()
            {
                new Book { Author = author1, Title = "Biography Title", Genre = Book.Genres.Biography, ReleaseDate = new DateTime(2001, 1, 1), Pages = 100  },
                new Book { Author = author2, Title = "Fantasy  Title", Genre = Book.Genres.Fantasy , ReleaseDate = new DateTime(2002, 2, 2), Pages = 200  },
                new Book { Author = author3, Title = "SciFi  Title", Genre = Book.Genres.SciFi , ReleaseDate = new DateTime(2003, 3, 3), Pages = 300  },
                new Magazine { Author = author4, Title = "Magazine  Title", ReleaseDate = new DateTime(2011, 11, 11) },
                new Paper { Author = author5, Title = "Paper  Title", ReleaseDate = new DateTime(2012, 12, 12) }
            };
        }

        public ListManager SearchAuthor(string inputAuthorName)
        {
            ListManager authorSearch = new ListManager();
            authorSearch.PublicationList = PublicationList.FindAll(author => author.Author.Name.ToUpper().Contains(inputAuthorName));
            return authorSearch;
        }
        public ListManager SearchPublication(string inputTitle)
        {
            ListManager publicationSearch = new ListManager();
            publicationSearch.PublicationList = PublicationList.FindAll(publication => publication.Title.ToUpper().Contains(inputTitle));
            return publicationSearch;
        }
    }
}
