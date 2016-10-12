using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Runtime
    {
        public void Start()
        {
            #region Del 1:

            //var dog1 = new Dog
            //{ 
            //    Name = "Bus",
            //    Age = 12,
            //    Breed = "Papillion"
            //};
            //var dog2 = new Dog
            //{
            //    Name = "Ralf",
            //    Age = 12,
            //    Breed = "Papillion"
            //};
            //var dog3 = new Dog
            //{
            //    Name = "Dino",
            //    Age = 14,
            //    Breed = "Samojed"
            //};

            //Console.WriteLine(dog1.Introduction());
            //Console.WriteLine(dog2.Introduction());
            //Console.WriteLine(dog3.Introduction());

            #endregion

            #region Del 2:

            //List<Dog> dogs = new List<Dog>()
            //{
            //    new Dog { Name = "Bus", Age = 12, Breed = "Papillion" },
            //    new Dog { Name = "Ralf", Age = 12, Breed = "Papillion" },
            //    new Dog { Name = "Dino", Age = 14, Breed = "Samojed" }
            //};
            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog.Introduction());
            //}

            #endregion

            Dog.isProgramOver = false;

            do
            {
                Dog.Menu();
            } while (Dog.isProgramOver);
        }
    }
}
