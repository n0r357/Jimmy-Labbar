using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12.Models
{
    class Movie
    {
        public enum Genres
        {
            Action = 1,
            Crime,
            Fantasy,
            SciFi
        }
        public Genres Genre { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-15}\t{1,-10}\t{2,-5}", Title, Genre, Length);
        }
    }
}
