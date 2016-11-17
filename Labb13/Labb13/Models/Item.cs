using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13.Models
{
    public class Item
    {
        public enum Types
        {
            Bars = 1,
            Drinks
        }
        public string Name { get; set; }
        public Types Type { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-15}\t{1,-15}\t{2,-5}", Name, Type, Price);
        }
    }
}
