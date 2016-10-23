using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Runtime
    {
        public void Start()
        {
            ListManager list = new ListManager();
            MenuManager menu = new MenuManager();
            menu.AllStock = list.StockList();
            menu.TypeFilter = "All";
            menu.StatusFilter = "All";

            while (!menu.IsProgramOver)
            {
                switch (menu.BuildMenuAndReturnSelection(menu.AllStock, list.CommandList(), menu.TypeFilter, menu.StatusFilter))
                {
                    case 1: //  Add Vehicle
                        List<Vehicle> addVehicle = new List<Vehicle>();
                        menu.AllStock.AddRange(addVehicle = menu.EnterVehicleInformation(menu.AllStock, list.EmptyList(), menu.TypeFilter, menu.StatusFilter, menu.CheckIfIndexBeenRemoved(menu.AllStock)));
                        break;
                    case 2: //  Remove Vehicle
                        int removeIndex = menu.EditOrRemoveVehicleMenuAndReturnSelection(menu.AllStock, list.RemoveList(), menu.TypeFilter, menu.StatusFilter);
                        menu.AllStock.RemoveAt(menu.AllStock.IndexOf(menu.AllStock.Find(allStockIndex => allStockIndex.Index.Equals(removeIndex))));
                        break;
                    case 3: //  Edit Vehicle
                        int selectedIndex = (menu.EditOrRemoveVehicleMenuAndReturnSelection(menu.AllStock, list.EditList(), menu.TypeFilter, menu.StatusFilter));
                        List<Vehicle> editVehicle = new List<Vehicle>();
                        editVehicle = menu.EnterVehicleInformation(menu.EditList(selectedIndex, menu.AllStock), list.EmptyList(), menu.TypeFilter, menu.StatusFilter, selectedIndex);
                        int editIndex = menu.AllStock.IndexOf(menu.AllStock.Find(allStockIndex => allStockIndex.Index.Equals(selectedIndex)));
                        menu.AllStock.RemoveAt(editIndex);
                        menu.AllStock.InsertRange(editIndex, editVehicle);
                        break;
                    case 4: // Change Type Filter
                        menu.SetTypeFilter(menu.BuildMenuAndReturnSelection(menu.AllStock, list.TypeFilterList(), menu.TypeFilter, menu.StatusFilter));
                        break;
                    case 5: // Change Status Filter
                        menu.SetStatusFilter(menu.BuildMenuAndReturnSelection(menu.AllStock, list.StatusFilterList(), menu.TypeFilter, menu.StatusFilter));
                        break;
                    case 6: //  Quit Program
                        menu.Quit();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
