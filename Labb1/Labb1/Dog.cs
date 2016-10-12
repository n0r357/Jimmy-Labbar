using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }


        //public Dog(string name, int age, string breed)
        //{
        //    Name = name;
        //    Age = age;
        //    Breed = breed;
        //}
        public void Introduction(string name, int age, string breed)
        {
            Console.WriteLine("The dog is named {0}, its {1} years old and its breed is {2}", Name, Age, Breed);
        }
    }
}
