using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    class Book : Publication
    {
        public enum Genres
        {
            Biography = 1,
            Fantasy,
            SciFi
        }
        public Genres Genre { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return String.Format("{0}\t{1,-10}\t{2,-5}", base.ToString(), Genre, Pages);
        }
        public override string ToPublicationString()
        {
            return String.Format("{0}\t{1,-10}\t{2,-5}", base.ToPublicationString(), Genre, Pages);
        }
    }
}
