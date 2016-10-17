using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Menu
    {
        public bool IsProgramOver { get; set; }

        public void MainMenu()
        {
            IsProgramOver = false;
            int input;
            do
            {
                Console.Clear();
                MenyBar();
                Console.WriteLine("\t1 - Add Animal");
                Console.WriteLine("\t2 - Remove Animal");
                Console.WriteLine("\t3 - List Menu");
                Console.WriteLine("\t4 - Quit");
                MenyBar();
                Console.Write("\tChoice: ");
                input = int.Parse(Console.ReadLine());
            } while (input != 1 && input !=2 && input != 3 && input != 4);

            switch (input)
            {
                case 1:
                    AddMeny();
                    break;
                case 2:
                    RemoveMeny();
                    break;
                case 3:
                    ListMenu();
                    break;
                case 4:
                    EndProgram();
                    break;
                default:
                    break;
            }
        }
        private void AddMeny()
        {
            int input;
            do
            {
                Console.Clear();
                MenyBar();
                Console.WriteLine("\t1 - Add Artropod");
                Console.WriteLine("\t2 - Add Fish");
                Console.WriteLine("\t3 - Add Reptile");
                Console.WriteLine("\t4 - List Menu");
                Console.WriteLine("\t5 - Main Menu");
                Console.WriteLine("\t6 - Quit");
                MenyBar();
                Console.Write("\tChoice: ");
                input = int.Parse(Console.ReadLine());
            } while (input != 1 && input != 2 && input != 3 && input != 4 && input != 5 && input != 6);
            
            switch (input)
            {
                case 1:
                    InputInformation(input);
                    break;
                case 2:
                    InputInformation(input);
                    break;
                case 3:
                    InputInformation(input);
                    break;
                case 4:
                    ListMenu();
                    break;
                case 5:
                    MainMenu();
                    break;
                case 6:
                    EndProgram();
                    break;
                default:
                    break;
            }
        }
        private void RemoveMeny()
        {
            SearchMeny();
            ListManager.CompleteList();
            SearchMenyBar();
            Console.Write("\tSelect animal to remove: ");
            int input = int.Parse(Console.ReadLine()) - 1;
            ListManager.RemoveItem(input);
            MenyBar();
            Console.WriteLine(" Animal removed, press key to continue.");
            MenyBar();
            Console.ReadKey();
        }
        private void ListMenu()
        {
            ListManager completeList = new ListManager();
            Console.Clear();
            MenyBar();
            Console.WriteLine("\t1 - Show Reptile List");
            Console.WriteLine("\t2 - Show Arthropod List");
            Console.WriteLine("\t3 - Show Fish List");
            Console.WriteLine("\t4 - Complete List");
            Console.WriteLine("\t5 - Main Menu");
            Console.WriteLine("\t6 - Quit");
            MenyBar();
            Console.Write("\tChoice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    SearchMeny();
                    ListManager.SearchList("Reptile");
                    PressKey();
                    break;
                case "2":
                    SearchMeny();
                    ListManager.SearchList("Arthropod");
                    PressKey();
                    break;
                case "3":
                    SearchMeny();
                    ListManager.SearchList("Fish");
                    PressKey();
                    break;
                case "4":
                    SearchMeny();
                    ListManager.CompleteList();
                    PressKey();
                    break;
                case "5":
                    MainMenu();
                    break;
                case "6":
                    EndProgram();
                    break;
                default:
                    break;
            }
        }
        private void InputInformation(int animalClass)
        {
            ListManager newAnimal = new ListManager();

            if (animalClass == 1)
            {
                Spider newSpider = new Spider();
                MenyBar();
                newSpider.AnimalClass = "Arthropod";
                Console.Write("  Enter type of arthropod: ");
                newSpider.AnimalType = Console.ReadLine();
                Console.Write("  Number of legs: ");
                newSpider.NumberOfLegs = int.Parse(Console.ReadLine());
                Console.Write("  Is it a predator? (y/n): ");
                newSpider.IsPredator = YesOrNo();
                Console.Write("\n  Does it have poison? (y/n): ");
                newSpider.HasPoison = YesOrNo();
                Console.Write("\n  What does it eat?: ");
                newSpider.Food = Console.ReadLine();

                ListManager.AddItem(newSpider.General() + newSpider.Eat());

                AddedAnimal();
            }
            else if (animalClass == 2)
            {
                Shark newShark = new Shark();
                MenyBar();
                newShark.AnimalClass = "Fish     ";
                Console.Write("  Enter type of fish: ");
                newShark.AnimalType = Console.ReadLine();
                Console.Write("  Does it have lungs? (y/n): ");
                newShark.HaveLungs = YesOrNo();
                Console.Write("\n  Is it a predator? (y/n): ");
                newShark.IsPredator = YesOrNo();
                Console.Write("\n  Does it have poison? (y/n): ");
                newShark.HasPoison = YesOrNo();
                Console.Write("\n  What does it eat?: ");
                newShark.Food = Console.ReadLine();

                ListManager.AddItem(newShark.General() + newShark.Eat());

                AddedAnimal();
            }
            else if (animalClass == 3)
            {
                Snake newSnake = new Snake();
                MenyBar();
                newSnake.AnimalClass = "Reptile  ";
                Console.Write("  Enter type of reptile: ");
                newSnake.AnimalType = Console.ReadLine();
                Console.Write("  Does it have legs? (y/n): ");
                newSnake.HasLegs = YesOrNo();
                Console.Write("\n  Is it a predator? (y/n): ");
                newSnake.IsPredator = YesOrNo();
                Console.Write("\n  Does it have poison? (y/n): ");
                newSnake.HasPoison = YesOrNo();
                Console.Write("\n  What does it eat?: ");
                newSnake.Food = Console.ReadLine();

                ListManager.AddItem(newSnake.General() + newSnake.Eat());

                AddedAnimal();
            }
        }
        private void AddedAnimal()
        {
            MenyBar();
            Console.WriteLine(" Animal added, press key to continue.");
            MenyBar();
            Console.ReadKey();
        }
        private string YesOrNo()
        {
            var input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.Y:
                    return "Yes";
                case ConsoleKey.N:
                    return "No";
                default:
                    return "Invalid";
            }
        }
        private void PressKey()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("         Press key to continue.");
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
        private void MenyBar()
        {
            Console.WriteLine("----------------------------------------");
        }
        private void SearchMeny()
        {
            Console.Clear();
            SearchMenyBar();
            Console.WriteLine("Index:\t\tClass:\t\tType:\t\tLegs/lungs:\tPredator:\tFood:\t\tPoison:");
            SearchMenyBar();
        }
        private void SearchMenyBar()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        }
        private void EndProgram()
        {
            bool loop = false;

            do
            {
                loop = false;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("\tEnd program? (y/n)");
                Console.WriteLine("--------------------------------------");
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.Y:
                        IsProgramOver = true;
                        break;
                    case ConsoleKey.N:
                        MainMenu();
                        break;
                    default:
                        loop = true;
                        break;
                }
            } while (loop);
        }
    }
}
