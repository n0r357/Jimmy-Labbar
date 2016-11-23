using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb16.Models;

namespace Labb16.Repositories
{
    class ListProductRepository : IProductRepository
    {
        private MyLists list = new MyLists();

        public void Add()
        {
            list.Products.Add(UI.AddItem(list.Products));
        }

        public void Delete(int id)
        {
            Product choice = list.Products.Find(item => item.ID.Equals(id));
            list.Products.Remove(choice);
        }

        public List<Product> Get(int id)
        {
            return list.Products.Where(item => item.ID.Equals(id)).ToList();
        }

        public List<Product> GetAll()
        {
            return list.Products.OrderBy(index => index.ID).ToList();
        }

        public void Update(Product updatedProduct)
        {
            list.Products.Add(updatedProduct);
        }
    }
}
