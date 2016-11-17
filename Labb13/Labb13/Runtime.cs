using Labb13.Filters;
using Labb13.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13
{
    class Runtime
    {
        public void Start()
        {
            ItemManager manager = new ItemManager();
            bool loop = true;

            while (loop)
            {
                switch (UI.PrintMainMenu(manager.ItemList))
                {
                    case ConsoleKey.D1: //  Add object to list
                        manager.AddItem(manager.ItemList);
                        break;
                    case ConsoleKey.D2: //  Filter bars
                        manager.SortByBars(manager.ItemList);
                        break;
                    case ConsoleKey.D3: //  Filter drinks
                        manager.SortByDrinks(manager.ItemList);
                        break;
                    case ConsoleKey.D4: //  Quit program
                        loop = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
