using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public abstract class Animal
    {
        public string AnimalClass { get; set; }
        public string AnimalType { get; set; }
        public string Food { get; set; }
        public string IsPredator { get; set; }

        public virtual string General()
        {
            return String.Format("\t\t{0}\t{1}\t", AnimalClass, AnimalType);
        }
       
        public virtual string Eat()
        {
            return String.Format("\t\t{0}\t\t{1}", IsPredator, Food);
        }
    }
}