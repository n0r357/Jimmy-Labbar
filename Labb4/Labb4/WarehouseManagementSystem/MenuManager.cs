using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4
{
    public class MenuManager : Vehicle
    {
        #region Properties

        public bool IsProgramOver { get; set; }
        private int MenuSelection { get; set; }
        public string Filter { get; set; }
        public string TypeFilter { get; set; }
        public string StatusFilter { get; set; }

        #endregion

        #region MainMenu
        //  Prints stock list, menu and asks for input
        //  Checks if input exists in menu and returns value
        public int BuildMenuAndReturnSelection(List<Vehicle> inputStockList, List<string> inputMenuList, string inputTypeFilter, string inputStatusFilter)
        {
            bool loop;
            do
            {
                try
                {
                    CreatesAndPrintsFilteredStockMenu(inputStockList, inputMenuList, inputTypeFilter, inputStatusFilter);
                    Console.WriteLine("{0} {1}", "   Filter:", Filter = String.Format("{0}/{1}", TypeFilter, StatusFilter));
                    SmallMenuBar();
                    foreach (var item in inputMenuList)
                    {
                        Console.WriteLine(item);
                    }
                    SmallMenuBar();
                    Console.Write("   Input: ");
                    int choice = int.Parse(Console.ReadLine());
                    loop = MenuErrorHandling(choice, inputMenuList.Count);
                    MenuSelection = choice;
                }
                catch (Exception)
                {
                    loop = true; ;
                }
            } while (loop);

            return MenuSelection;
        }

        #endregion

        #region NewListObject
        //  Asks for inputs and returns list object
        public List<Vehicle> EnterVehicleInformation(List<Vehicle> inputStockList, List<string> inputMenuList, string inputTypeFilter, string inputStatusFilter, int inputIndex)
        {
            ListManager newInput = new ListManager();
            switch (BuildMenuAndReturnSelection(inputStockList, newInput.CarOrMotorCycle(), inputTypeFilter, inputStatusFilter))
            {
                case 1: //  Add Car
                    newInput.Type = "Car";
                    break;
                case 2: //  Add MC
                    newInput.Type = "MC";
                    break;
                default:
                    break;
            }
            switch (BuildMenuAndReturnSelection(inputStockList, newInput.NewOrUsedList(), inputTypeFilter, inputStatusFilter))
            {
                case 1: //  Add New Vehicle
                    newInput.Status = "New";
                    break;
                case 2: //  Add Used Vehicle
                    newInput.Status = "Used";
                    break;
                default:
                    break;
            }
            InputInformationMenu(inputStockList, newInput.InputBrand(), inputTypeFilter, inputStatusFilter);
            newInput.Brand = Console.ReadLine();
            InputInformationMenu(inputStockList, newInput.InputModel(), inputTypeFilter, inputStatusFilter);
            newInput.Model = Console.ReadLine();
            InputInformationMenu(inputStockList, newInput.InputColor(), inputTypeFilter, inputStatusFilter);
            newInput.Color = Console.ReadLine();
            try
            {
                InputInformationMenu(inputStockList, newInput.InputYear(), inputTypeFilter, inputStatusFilter);
                newInput.Year = int.Parse(Console.ReadLine());
            }
            catch (Exception) { }
            try
            {
                InputInformationMenu(inputStockList, newInput.InputPrice(), inputTypeFilter, inputStatusFilter);
                newInput.Price = int.Parse(Console.ReadLine());
            }
            catch (Exception) { }
            try
            {
                InputInformationMenu(inputStockList, newInput.InputQuantity(), inputTypeFilter, inputStatusFilter);
                newInput.Quantity = int.Parse(Console.ReadLine());
            }
            catch (Exception) { }

            newInput.Index = inputIndex;

            return newInput.AddVehicleToList(newInput.Index, newInput.Type, newInput.Status, newInput.Brand, newInput.Model, newInput.Year, newInput.Color, newInput.Price, newInput.Price);
        }
        public List<Vehicle> InputInformationMenu(List<Vehicle> inputStockList, List<string> inputMenuList, string inputTypeFilter, string inputStatusFilter)
        {
            List<Vehicle> filterMenu = new List<Vehicle>();
            Console.Clear();
            filterMenu.AddRange(CreatesAndPrintsFilteredStockMenu(inputStockList, inputMenuList, inputTypeFilter, inputStatusFilter));
            Console.WriteLine("{0} {1}", "   Filter:", Filter = String.Format("{0}/{1}", TypeFilter, StatusFilter));
            SmallMenuBar();
            foreach (var item in inputMenuList)
            {
                Console.WriteLine(item);
            }
            SmallMenuBar();
            Console.Write("   Input: ");

            return filterMenu;
        }

        #endregion

        #region EditOrRemoveMenu
        //  Prints list, menu and asks for input
        //  Checks if chosen index exists in list and returns selection
        public int EditOrRemoveVehicleMenuAndReturnSelection(List<Vehicle> inputStockList, List<string> inputMenuList, string inputTypeFilter, string inputStatusFilter)
        {
            List<Vehicle> filterList = new List<Vehicle>();
            bool loop;
            do
            {
                try
                {
                    filterList.AddRange(InputInformationMenu(inputStockList, inputMenuList, inputTypeFilter, inputStatusFilter));
                    int choice = int.Parse(Console.ReadLine());
                    loop = IsIndexInStockList(choice, filterList);
                    MenuSelection = choice;
                }
                catch (Exception)
                {
                    loop = true; ;
                }
            } while (loop);
            return MenuSelection;
        }

        #endregion

        #region EditList
        //  Returns chosen item from list
        public List<Vehicle> EditList(int inputIndex, List<Vehicle> inputStockList)
        {
            List<Vehicle> editMenu = new List<Vehicle>();
            editMenu.AddRange(inputStockList.Where(index => String.Equals(index.Index, inputIndex)).ToArray());
            return editMenu;
        }

        #endregion

        #region FilterList
        //  Creates a filtered stocklist and prints it
        public List<Vehicle> CreatesAndPrintsFilteredStockMenu(List<Vehicle> inputStockList, List<string> inputMenuList, string inputTypeFilter, string inputStatusFilter)
        {
            List<Vehicle> filterList = new List<Vehicle>();
            Console.Clear();
            LargeMenuBar();
            StockColumnNames();
            LargeMenuBar();

            if (inputTypeFilter == "All" && inputStatusFilter != "All")
            {
                filterList.AddRange(inputStockList.Where(status => String.Equals(status.Status, inputStatusFilter)).ToArray());
                PrintFilterMenu(filterList.OrderBy(index => index.Index).ToList());
            }
            else if (inputTypeFilter != "All" && inputStatusFilter == "All")
            {
                filterList.AddRange(inputStockList.Where(type => String.Equals(type.Type, inputTypeFilter)).ToArray());
                PrintFilterMenu(filterList.OrderBy(index => index.Index).ToList());
            }
            else if (inputTypeFilter != "All" && inputStatusFilter != "All")
            {
                filterList.AddRange(inputStockList.Where(filter => String.Equals(filter.Status, inputStatusFilter) && String.Equals(filter.Type, inputTypeFilter)).ToArray());
                PrintFilterMenu(filterList.OrderBy(index => index.Index).ToList());
            }
            else
            {
                filterList.AddRange(inputStockList);
                PrintFilterMenu(inputStockList.OrderBy(index => index.Index).ToList());
            }
            LargeMenuBar();
            return filterList;
        }
        public void PrintFilterMenu(List<Vehicle> inputFilterList)
        {
            foreach (var vehicle in inputFilterList)
            {
                Console.WriteLine(vehicle);
            }
        }

        #endregion

        #region SetFilter
        //  Sets type filter
        public string SetTypeFilter(int inputMenuSelection)
        {
            switch (MenuSelection)
            {
                case 1:
                    TypeFilter = "All";
                    break;
                case 2:
                    TypeFilter = "Car";
                    break;
                case 3:
                    TypeFilter = "MC";
                    break;
                default:
                    TypeFilter = "All";
                    break;
            }
            return TypeFilter;
        }
        //  Sets status filter
        public string SetStatusFilter(int inputMenuSelection)
        {
            switch (MenuSelection)
            {
                case 1:
                    StatusFilter = "All";
                    break;
                case 2:
                    StatusFilter = "New";
                    break;
                case 3:
                    StatusFilter = "Used";
                    break;
                default:
                    StatusFilter = "All";
                    break;
            }
            return StatusFilter;
        }

        #endregion

        #region ErrorHandling
        //  Checks for removed index in stock list
        public int CheckIfIndexBeenRemoved(List<Vehicle> inputStockList)
        {
            for (int i = 1; i <= AllStock.Count; i++)
            {
                if (!inputStockList.Select(usedIndex => usedIndex.Index).Contains(i))
                {
                    return i;
                }
            }
            return AllStock.Count + 1;
        }
        //  Checks if index exists in list
        public bool IsIndexInStockList(int inputChoice, List<Vehicle> inputStockList)
        {
            if (inputStockList.Select(input => input.Index).Contains(inputChoice))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //  Checks if choice exists in menu
        public bool MenuErrorHandling(int inputChoice, int inputNumberOfSelections)
        {
            int firstMenuChoice = 1;

            if (inputChoice >= firstMenuChoice && inputChoice <= inputNumberOfSelections)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region QuitProgram
        //  Ends the program
        public bool Quit()
        {
            bool loop;
            do
            {
                loop = false;
                LargeMenuBar();
                Console.WriteLine("\t\t\t\t       End program? (y/n)");
                LargeMenuBar();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.Y:
                        IsProgramOver = true;
                        break;
                    case ConsoleKey.N:
                        IsProgramOver = false;
                        break;
                    default:
                        IsProgramOver = true;
                        break;
                }
            } while (loop);

            return IsProgramOver;
        }

        #endregion

        #region MenuBars

        private void StockColumnNames()
        {
            Console.WriteLine("{0,-6}\t{1,-6}\t{2,-6}\t{3,-20}\t{4,-10}\t{5,-6}\t{6,-10}\t{7,-10}\t{8,-6}", "Index:", "Type:", "Status:", "Brand:", "Model:", "Year:", "Color:", "Price:", "Quantity:");
        }
        private void SmallMenuBar()
        {
            Console.WriteLine("---------------------");
        }
        private void LargeMenuBar()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }

        #endregion
    }
}