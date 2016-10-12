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
            foreach (var dog in Dogs)
            {
                index = Dogs.IndexOf(dog) + 1;
                Console.WriteLine(index + " - " + dog);
            }
        }
        public void AddDog()
        {
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Age: ");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Breed: ");
            Breed = Console.ReadLine();
            string input = Name + "\t" + Age + "\t" + Breed;
            Dogs.Add(input);
        }
        public void RemoveDog()
        {
            int input;
            Console.Write("Select dog to remove: ");
            input = int.Parse(Console.ReadLine());
            Dogs.RemoveAt(input - 1);
            Console.WriteLine("Dog removed, press key to continue.");
            Console.ReadKey();
        }
        public static void Menu()
        {
            Dog newDog = new Dog();
            string choice;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Add dog");
                Console.WriteLine("2 - Remove dog");
                Console.WriteLine("3 - Show list");
                Console.WriteLine("4 - Exit");
                Console.Write("Your choice: ");
                switch (choice = Console.ReadLine())
                {
                    case "1":
                        newDog.AddDog();
                        break;
                    case "2":
                        newDog.RemoveDog();
                    break;
                    case "3":
                        newDog.ShowList();
                        break;
                    case "4":
                        isProgramOver = true;
                        break;
                    default:
                        break;
                }
            } while (true); 
       } 
}
}
