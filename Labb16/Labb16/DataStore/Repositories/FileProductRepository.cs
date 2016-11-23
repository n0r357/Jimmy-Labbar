using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb16.Models;
using System.IO;

namespace Labb16.Repositories
{
    class FileProductRepository : IProductRepository
    {
        public string FileDirectory { get; set; }
        public string FilePath { get; set; }

        public void Add()
        {
            List<Product> addList = GetAll();
            addList.Add(UI.AddItem(addList));
            string jsonString = JsonConvert.SerializeObject(addList);
            File.WriteAllText(FilePath, jsonString);
        }

        public void Delete(int id)
        {
            List<Product> deleteList = GetAll();
            Product choice = deleteList.Find(item => item.ID.Equals(id));
            deleteList.Remove(choice);
            string jsonString = JsonConvert.SerializeObject(deleteList);
            File.WriteAllText(FilePath, jsonString);
        }

        public List<Product> Get(int id)
        {
            string jsonFromFile = File.ReadAllText(FilePath);
            List<Product> myDeserializedList = JsonConvert.DeserializeObject<List<Product>>(jsonFromFile);
            return myDeserializedList.Where(item => item.ID.Equals(id)).ToList();
        }

        public List<Product> GetAll()
        {
            string jsonFromFile = File.ReadAllText(FilePath);
            List<Product> myDeserializedList = JsonConvert.DeserializeObject<List<Product>>(jsonFromFile);
            return myDeserializedList.OrderBy(index => index.ID).ToList();
        }

        public void Update(Product updatedProduct)
        {
            List<Product> updateList = GetAll();
            updateList.Add(updatedProduct);
            string jsonString = JsonConvert.SerializeObject(updateList);
            File.WriteAllText(FilePath, jsonString);
        }
    }
}
