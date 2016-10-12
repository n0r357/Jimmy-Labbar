using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Dog
    {
        public static bool isProgramOver;
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        private List<string> dogs = new List<string>();

        public List<string> Dogs
        {
            get { return dogs; }
            set { dogs = value; }
        }

        public string Introduction()
        {
            return String.Format(("The dog is named {0}, its {1} years old and its breed is a {2}."), Name, Age, Breed);
        }
        public void ShowList()
        {
            int index;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\t{    Current list    }\n");
            Console.WriteLine("\tName:\tAge:\tBreed:");
            Console.WriteLine("-------------------------------------");
            foreach (var dog in Dogs)
            {
                index = Dogs.IndexOf(dog) + 1;
                Console.WriteLine("    " + index + " - " + dog);
            }
        }
        public void AddDog()
        {
            Console.WriteLine("-------------------------------------");
            Console.Write("\tName: ");
            Name = Console.ReadLine();
            Console.Write("\tAge: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("\tBreed: ");
            Breed = Console.ReadLine();
            string input = Name + "\t" + Age + "\t" + Breed;
            Dogs.Add(input);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("  Dog added, press key to continue.");
            Console.WriteLine("-------------------------------------");
            Console.ReadKey();
        }
        public void RemoveDog()
        {
            int input;
            Console.WriteLine("-------------------------------------");
            Console.Write("\tSelect dog to remove: ");
            input = int.Parse(Console.ReadLine());
            Dogs.RemoveAt(input - 1);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" Dog removed, press key to continue.");
            Console.WriteLine("-------------------------------------");
            Console.ReadKey();
        }
        public static void Menu()
        {
            Dog newDog = new Dog();
            string choice;

            do
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("\t1 - Add dog");
                Console.WriteLine("\t2 - Remove dog");
                Console.WriteLine("\t3 - Show list");
                Console.WriteLine("\t4 - Exit");
                Console.WriteLine("-------------------------------------");
                Console.Write("\tYour choice: ");
                switch (choice = Console.ReadLine())
                {
                    case "1":
                        newDog.AddDog();
                        isProgramOver = false;
                        break;
                    case "2":
                        newDog.ShowList();
                        newDog.RemoveDog();
                        isProgramOver = false;
                        break;
                    case "3":
                        newDog.ShowList();
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("\tPress key to continue.");
                        Console.WriteLine("-------------------------------------");
                        Console.ReadKey();
                        isProgramOver = false;
                        break;
                    case "4":
                        Console.WriteLine("-------------------------------------");
                        isProgramOver = true;
                        break;
                    default:
                        break;
                }
            } while (!isProgramOver); 
       } 
}
}
