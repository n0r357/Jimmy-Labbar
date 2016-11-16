using Labb11.Filters;
using Labb11.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb11
{
    class Runtime
    {
        public void Start()
        {
            int input;
            bool loop = true;

            do
            {
                NumberManager manager = new NumberManager();
                Console.Clear();
                Console.Write("Input number: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                    manager.PrintAllFilterResults(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
                Console.Write("Again? (y/n)");
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Y:
                        loop = true;
                        break;
                    case ConsoleKey.N:
                        loop = false;
                        break;
                    default:
                        break;
                }
            } while (loop); 
        }
    }
}
