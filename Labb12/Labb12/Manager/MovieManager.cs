using Labb12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12.Manager
{
    class MovieManager
    {
        public List<Movie> Movies { get; set; }

        public MovieManager()
        {
            Movies = new List<Movie>()
            {
                new Movie { Title = "Action Movie", Genre = Movie.Genres.Action, Length = 90 },
                new Movie { Title = "Crime Movie", Genre = Movie.Genres.Crime, Length = 100 },
                new Movie { Title = "Fantasy Movie", Genre = Movie.Genres.Fantasy, Length = 200 },
                new Movie { Title = "SciFi Movie", Genre = Movie.Genres.SciFi, Length = 130 }
            };
        }

        public void PrintMovieList()
        {
            Console.WriteLine("{0,-15}\t{1,-10}\t{2,-5}", "Title:", "Genre:", "Length:");
            foreach (var movie in Movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }
    }
}
