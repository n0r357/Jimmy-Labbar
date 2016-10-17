using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class ListManager
    {
        private static List<string> animalLibrary = new List<string>();

        public static List<string> AnimalLibrary
        {
            get { return animalLibrary; }
            set { animalLibrary = value; }
        }

        public static void AddItem(string animal)
        {
            AnimalLibrary.Add(animal);
        }
        public static void RemoveItem(int input)
        {
            AnimalLibrary.RemoveAt(input);
        }
        public static void CompleteList()
        {
            int index;
            foreach (var animal in AnimalLibrary)
            {
                index = AnimalLibrary.IndexOf(animal) + 1;
                Console.WriteLine("  " + index + " " + animal);
            }
        }
        public static void SearchList(string search)
        {
            int searchIndex;
            var searchList = AnimalLibrary.FindAll(animal => animal.Contains(search));
            foreach (var animal in searchList)
            {
                searchIndex = searchList.IndexOf(animal) + 1;
                Console.WriteLine("  " + searchIndex + " " + animal);
            }
        }
    }
}
