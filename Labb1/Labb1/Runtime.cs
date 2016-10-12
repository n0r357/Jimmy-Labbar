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
            var dog1 = new Dog
            {
                Name = "Bus",
                Age = 12,
                Breed = "Papillion"
            };
            var dog2 = new Dog
            {
                Name = "Ralf",
                Age = 12,
                Breed = "Papillion"
            };
            var dog3 = new Dog
            {
                Name = "Dino",
                Age = 14,
                Breed = "Samojed"
            };

            Console.WriteLine();
        }
    }
}
