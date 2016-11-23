using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15
{
    class UI
    {
        public static ConsoleKey MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Bike");
            Console.WriteLine("2 - Boulder");
            Console.WriteLine("3 - Button");
            Console.WriteLine("4 - Car");
            Console.WriteLine("5 - Spaceship");
            Console.WriteLine("6 - Quit");
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }
        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static void StartVehicle(string inputVehicleName)
        {
            Console.WriteLine("Start: {0}", inputVehicleName);
        }
        public static void StopVehicle(string inputVehicleName)
        {
            Console.WriteLine("Stop: {0}", inputVehicleName);
        }
        public static void LockVehicle(string inputVehicleName)
        {
            Console.WriteLine("Lock: {0}", inputVehicleName);
        }
        public static void UnlockVehicle(string inputVehicleName)
        {
            Console.WriteLine("Unlock: {0}", inputVehicleName);
        }
        public static void PushObject(string inputObjectName)
        {
            Console.WriteLine("Push: {0}", inputObjectName);
        }
    }
}
