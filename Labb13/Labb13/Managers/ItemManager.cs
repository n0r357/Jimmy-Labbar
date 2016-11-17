using Labb13.Filters;
using Labb13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb13.Managers
{
    class ItemManager
    {
        public ListHandler ListEvent;
        public EventHandler RightInputEvent;
        public EventHandler WrongInputEvent;

        public List<Item> ItemList { get; set; }

        public ItemManager()
        {
            ItemList = new List<Item>()
            {
                new Models.Item { Name = "QuestBar", Type = Item.Types.Bars, Price = 25 },
                new Models.Item { Name = "BattleOats", Type = Item.Types.Bars, Price = 30 },
                new Models.Item { Name = "CleanFit", Type = Item.Types.Drinks, Price = 20 },
                new Models.Item { Name = "NOCCO", Type = Item.Types.Drinks, Price = 25 }
            };
        }

        public void AddItem(List<Item> inputList)
        {
            ItemFilters addItem = new ItemFilters();
            ListEvent = addItem.AddItemFilter;
            OnListEvent(inputList);
        }
        public void SortByBars(List<Item> inputList)
        {
            ItemFilters bars = new ItemFilters();
            ListEvent = bars.SortByBarsFilter;
            OnListEvent(inputList);
        }
        public void SortByDrinks(List<Item> inputList)
        {
            ItemFilters drinks = new ItemFilters();
            ListEvent = drinks.SortByDrinksFilter;
            OnListEvent(inputList);
        }

        public void CheckNameInput(int inputNameLength)
        {
            if (inputNameLength < 3)
            {
                OnWrongInputEvent(EventArgs.Empty);
            }
            else
            {
                OnRightInputEvent(EventArgs.Empty);
            }
        }
        public void CheckTypeInput(Item.Types inputType)
        {
            if ((int)inputType > 2 || (int)inputType == 0)
            {
                OnWrongInputEvent(EventArgs.Empty);
            }
            else
            {
                OnRightInputEvent(EventArgs.Empty);
            }
        }
        public void CheckPriceInput(int inputPrice)
        {
            if (inputPrice == 0 || inputPrice > 9999)
            {
                OnWrongInputEvent(EventArgs.Empty);
            }
            else
            {
                OnRightInputEvent(EventArgs.Empty);
            }
        }

        protected virtual void OnListEvent(List<Item> inputList)
        {
            ListEvent?.Invoke(inputList);
        }
        protected virtual void OnRightInputEvent(EventArgs e)
        {
            if (RightInputEvent != null)
            {
                RightInputEvent(this, e);
            }
        }
        protected virtual void OnWrongInputEvent(EventArgs e)
        {
            if (WrongInputEvent != null)
            {
                WrongInputEvent(this, e);
            }
        }
    }
}
