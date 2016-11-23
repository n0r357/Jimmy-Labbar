using Labb7.Classes.ShoppingCart;
using Labb7.Interface;
using Labb7.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7.Models
{
    abstract class Product : ISellable
    {
        public string ProductInformation { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-15}\t{1,-10}\t{2,-5}", ProductInformation, Category, Price);
        }
        public string GetCategory()
        {
            return String.Format(this.GetType().Name);
        }
    }
}
