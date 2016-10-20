using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class GFX
    {
        #region Properties

        public bool IsProgramOver { get; set; }

        #endregion

        #region StartMenu

        //  Välkomstmeny, frågar efter användarens namn och returnerar det
        public string StartMenu()
        {
            string firstName;
            string lastName;
            string fullName;

            LargeMenuBar();
            Console.WriteLine("\t\t\t\tWelcome to Booking Manager 1.0");
            LargeMenuBar();
            do
            {
                Console.Write("\t\t\t\tEnter first name: ");
                firstName = Console.ReadLine();
            } while (firstName.Length < 1 || firstName.Length > 10);
            do
            {
                Console.Write("\t\t\t\tEnter last  name: ");
                lastName = Console.ReadLine();
            } while (lastName.Length < 1 || lastName.Length > 10);
            return fullName = String.Format("{0} {1}", firstName, lastName);
        }

        #endregion

        #region MainMenu

        public List<string> MainMenu()
        {
            List<string> mainMenu = new List<string>()
            {
                "\t\t\t\t      1 - Book Event",
                "\t\t\t\t      2 - View All Events",
                "\t\t\t\t      3 - View Bookings",
                "\t\t\t\t      4 - Quit"
            };
            return mainMenu;
        }

        #endregion

        #region EventMenu

        public List<string> EventMenu()
        {
            List<string> eventMenu = new List<string>()
            {
                "\t\t\t\t       1 - Book Concert",
                "\t\t\t\t       2 - Book Festival",
                "\t\t\t\t       3 - Book Movie"
            };
            return eventMenu;
        }

        #endregion

        #region QuitProgram

        //  Kontrollerar om användaren vill avsluta programmet och returnerar boolvärde
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
                        MainMenu();
                        break;
                    default:
                        IsProgramOver = true;
                        break;
                }
            } while (loop);

            return IsProgramOver;
        }

        #endregion

        #region Graphics

        public void BookingAdded()
        {
            LargeMenuBar();
            Console.WriteLine("\t\t\t\t\t Booking added.");
            PressKeyToContinue();
        }
        public void PressKeyToContinue()
        {
            LargeMenuBar();
            Console.WriteLine("\t\t\t\t     Press key to continue.");
            LargeMenuBar();
            Console.ReadKey();
        }
        private void LargeMenuBar()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }

        #endregion
    }
}
