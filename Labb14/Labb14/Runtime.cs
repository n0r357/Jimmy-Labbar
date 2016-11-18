using Labb14.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    class Runtime
    {
        public void Start()
        {
            ListManager manager = new ListManager();

            bool loop = true;

            while (loop)
            {
                switch (UI.PrintMainMenu())
                {
                    case ConsoleKey.D1:
                        UI.PrintAuthorList(manager);
                        break;
                    case ConsoleKey.D2:
                        UI.PrintPublicationList(manager);
                        break;
                    case ConsoleKey.D3:
                        UI.PrintSearchMenu(manager);
                        break;
                    case ConsoleKey.D4:
                        loop = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
