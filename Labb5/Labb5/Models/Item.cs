using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Models
{
    abstract class Item
    {
        public enum Genres
        {
            Action = 1,
            Adventure,
            Crime,
            Fantasy,
            Fiction,
            Horror,
            Roleplaying,
            SciFi,
            Strategy
        }
        public Genres Genre { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public string[] GenreList()
        {
            var genres = new string[9];

            foreach (var genre in Enum.GetValues(typeof(Genres)))
            {
                genres[(int)genre - 1] = String.Format("{0} - {1}", (int)genre, genre);
            }
            return genres;
        }
    }
}
