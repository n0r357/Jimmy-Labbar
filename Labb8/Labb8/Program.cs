using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class Program
    {
        static void Main(string[] args)
        {
            var runtime = new Runtime();
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine("     Huvudmeny:");
                Console.WriteLine("--------------------");
                Console.WriteLine("1 - G-uppgifter");
                Console.WriteLine("2 - VG-uppgifter");
                Console.WriteLine("3 - Avsluta program.");
                Console.WriteLine("--------------------");
                Console.Write("Ditt val: ");
                var input = Console.ReadKey(false).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        runtime.StartAssignment1();
                        break;
                    case ConsoleKey.D2:
                        runtime.StartAssignment2();
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
