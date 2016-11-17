using Labb13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13.Filters
{
    class ItemFilters
    {
        public List<Item> AddItemFilter(List<Item> items)
        {
            Item newItem = new Item();
            newItem.Name = UI.AskForName();
            newItem.Type = UI.AskForType();
            newItem.Price = UI.AskForPrice();
            items.Add(newItem);
            return items;
        }
        public List<Item> SortByBarsFilter(List<Item> items)
        {
            List<Item> barList = new List<Item>();
            barList = items.Where(bars => bars.Type.Equals(Item.Types.Bars)).ToList();
            UI.PrintList(barList);
            UI.PressKeyToContinue();
            return barList;
        }
        public List<Item> SortByDrinksFilter(List<Item> items)
        {
            List<Item> drinkList = new List<Item>();
            drinkList = items.Where(drinks => drinks.Type.Equals(Item.Types.Drinks)).ToList();
            UI.PrintList(drinkList);
            UI.PressKeyToContinue();
            return drinkList;
        }
    }
}

