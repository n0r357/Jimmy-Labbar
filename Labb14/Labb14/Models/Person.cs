using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-15}\t{1,-5}", Name, Age);
        }
    }
}
