using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16.Models
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-5}\t{1,-20}", ID, Name);
        }
    }
}
