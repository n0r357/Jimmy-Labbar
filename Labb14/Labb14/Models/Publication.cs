using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    abstract class Publication
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public DateTime ReleaseDate { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-20}\t{1:yyyy/MM/dd}", Title, ReleaseDate);
        }
        public virtual string ToPublicationString()
        {
            return String.Format("{0}\t{1,-20}\t{2:yyyy/MM/dd}", Author.Name, Title, ReleaseDate);
        }
    }
}
