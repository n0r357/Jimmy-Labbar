using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class MenuManager : Event
    {
        #region Properties

        private int MenuSelection { get; set; }

        #endregion

        #region BuildMenu
        //  Bygger meny från en lista och returnerar ett val
        public int BuildMenuAndReturnSelection(List<string> inputMenuList)
        {
            bool loop;
            do
            {
                try
                {
                    Console.Clear();
                    SmallMenuBar();
                    foreach (var selection in inputMenuList)
                    {
                        Console.WriteLine(selection);
                    }
                    SmallMenuBar();
                    Console.Write("\t\t\t\t\t   Choice: ");
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

        #region ErrorHandling
        //  Kontrollerar att valet finns med i listan
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

        #region Menu Bar
        private void SmallMenuBar()
        {
            Console.WriteLine("\t\t\t\t     ---------------------");
        }
        #endregion
    }
}
