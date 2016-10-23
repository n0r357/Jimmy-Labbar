using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class ListManager : Vehicle
    {
        #region Stock List

        public List<Vehicle> StockList()
        {
            List<Vehicle> allStock = new List<Vehicle>()
            {
                new ListManager {Index = 1, Type = "Car", Status = "New", Brand = "Volvo", Model = "C70", Color = "White", Year = 2016, Price = 1000000, Quantity = 10 },
                new ListManager {Index = 2, Type = "Car", Status = "New", Brand = "Volvo", Model = "S40", Color = "Blue", Year = 2016, Price = 700000, Quantity = 10 },
                new ListManager {Index = 3, Type = "Car", Status = "Used", Brand = "Volvo", Model = "740", Color = "White", Year = 1988, Price = 6000, Quantity = 1 },
                new ListManager {Index = 4, Type = "MC", Status = "Used", Brand = "Harley Davidson", Model = "Fat Boy", Color = "Black", Year = 2010, Price = 250000, Quantity = 10 },
                new ListManager {Index = 5, Type = "MC", Status = "New", Brand = "Harley Davidson", Model = "Sportster", Color = "Red", Year = 2008, Price = 500000, Quantity = 10 },
                new ListManager {Index = 6, Type = "Car", Status = "Used", Brand = "Saab", Model = "900", Color = "Grey", Year = 1991, Price = 6500, Quantity = 1 },
                new ListManager {Index = 7, Type = "Car", Status = "Used", Brand = "Lotus", Model = "Espirit", Color = "White", Year = 2002, Price = 1200000, Quantity = 1 },
                new ListManager {Index = 8, Type = "Car", Status = "New", Brand = "Ferrari", Model = "F12", Color = "Red", Year = 2012, Price = 2100000, Quantity = 1 },
                new ListManager {Index = 9, Type = "Car", Status = "New", Brand = "Tesla", Model = "Roadster", Color = "Blue", Year = 2015, Price = 300000, Quantity = 10 },
                new ListManager {Index = 10, Type = "Car", Status = "New", Brand = "Tesla", Model = "Model S", Color = "Black", Year = 2016, Price = 500000, Quantity = 10 },
                new ListManager {Index = 11, Type = "Car", Status = "Used", Brand = "Tesla", Model = "Model X", Color = "Black", Year = 2016, Price = 800000, Quantity = 10 }
            };                            
            return allStock;
        }

        #endregion

        #region AddVehicleToList

        public List<Vehicle> AddVehicleToList(int inputIndex, string inputType, string inputStatus, string inputBrand, string inputModel, int inputYear, string inputColor, int inputPrice, int inputQuantity)
        {
            List<Vehicle> addVehicle = new List<Vehicle>()
            {
                new ListManager { Index = inputIndex, Type = inputType, Status = inputStatus, Brand = inputBrand, Model = inputModel, Year = inputYear, Color = inputColor, Price = inputPrice, Quantity = inputQuantity },
            };
            return addVehicle;
        }

        #endregion

        #region CommandMenues

        public List<string> CommandList()
        {
            List<string> commandList = new List<string>()
            {
                " 1 - Add Vehicle",
                " 2 - Remove Vehicle",
                " 3 - Edit Vehicle",
                " 4 - Filter: Type",
                " 5 - Filter: Status",
                " 6 - Quit"
            };
            return commandList; 
        }
        public List<string> TypeFilterList()
        {
            List<string> typeFilterList = new List<string>()
            {
                " 1 - All Vehicles",
                " 2 - Show Cars",
                " 3 - Show Motorcycles",
            };
            return typeFilterList;
        }
        public List<string> StatusFilterList()
        {
            List<string> statusFilterList = new List<string>()
            {
                " 1 - All Vehicles",
                " 2 - Show New",
                " 3 - Show Used",
            };
            return statusFilterList;
        }

        #endregion

        #region AddVehicleMenues

        public List<string> CarOrMotorCycle()
        {
            List<string> addVehicleList = new List<string>()
            {
                "   1 - Car",
                "   2 - Motorcycle"
            };
            return addVehicleList;
        }
        public List<string> NewOrUsedList()
        {
            List<string> newOrUsedList = new List<string>()
            {
                "   1 - New Vehicle",
                "   2 - Used Vehicle"
            };
            return newOrUsedList;
        }
        public List<string> InputBrand()
        {
            List<string> inputInformationList = new List<string>()
            {
                "   Enter:  Brand"
            };
            return inputInformationList;
        }
        public List<string> InputModel()
        {
            List<string> inputInformationList = new List<string>()
            {
                "   Enter:  Model"
            };
            return inputInformationList;
        }
        public List<string> InputYear()
        {
            List<string> inputInformationList = new List<string>()
            {
                "   Enter:  Year"
            };
            return inputInformationList;
        }
        public List<string> InputColor()
        {
            List<string> inputInformationList = new List<string>()
            {
                "   Enter:  Color"
            };
            return inputInformationList;
        }
        public List<string> InputPrice()
        {
            List<string> inputInformationList = new List<string>()
            {
                "   Enter:  Price"
            };
            return inputInformationList;
        }
        public List<string> InputQuantity()
        {
            List<string> inputInformationList = new List<string>()
            {
                "   Enter:  Quantity"
            };
            return inputInformationList;
        }

        #endregion

        #region EditAndRemoveCommands

        public List<string> EditList()
        {
            List<string> editList = new List<string>()
            {
                "   Edit:   Index"
            };
            return editList;
        }
        public List<string> RemoveList()
        {
            List<string> removeList = new List<string>()
            {
                "   Remove: Index"
            };
            return removeList;
        }

        #endregion

        #region EmptyMenu

        public List<string> EmptyList()
        {
            List<string> emptyList = new List<string>()
            {
            };
            return emptyList;
        }

        #endregion
    }
}
