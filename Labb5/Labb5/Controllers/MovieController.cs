using Labb5.Controllers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Models
{
    class MovieController
    {
        private IRepository movieRepository = new ListRepository();

        public void NewMovie()
        {
            var newMovie = UI.AddMovie();
            movieRepository.AddMovie(newMovie);
        }

        public void RemoveMovie()
        {
            bool loop = true;

            while (loop)
            {
                try
                {
                    var movies = PrintMovieList();
                    var index = UI.ReturnChoice(movies.Count()) - 1;
                    if (index < movies.Count())
                    {
                        movieRepository.RemoveMovie(movies[index]);
                        UI.ItemRemoved();
                        loop = false;
                    }
                    else if (movies.Count() == 0)
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
                    var movies = PrintMovieList();
                    var index = UI.ReturnChoice(movies.Count()) - 1;
                    if (index < movies.Count())
                    {
                        UI.EditItem(movies[index]);
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

        public Item[] PrintMovieList()
        {
            UI.PrintGenreMenuBar();
            var movies = movieRepository.GetMovieList();
            foreach (var movie in movies)
            {
                Console.WriteLine(UI.StringFormat(), Array.IndexOf(movies, movie) + 1, movie.Title, movie.Genre, movie.Price);
            }
            return movies;
        }
    }
}
