using Labb16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb16.Repositories
{
    class MyLists
    {
        private List<Product> products;

        public List<Product> Products
        {
            get { return products; }

            set { products = value; }
        }

        public MyLists()
        {
            Products = new List<Product>()
            {
                new Product { ID = 1, Name = "Item 1" },
                new Product { ID = 2, Name = "Item 2" },
                new Product { ID = 3, Name = "Item 3" },
                new Product { ID = 4, Name = "Item 4" },
                new Product { ID = 5, Name = "Item 5" }
            };
        }
    }
}
