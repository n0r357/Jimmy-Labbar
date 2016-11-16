using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb11.Filters
{
    class NumberFilters
    {
        public static void CheckIfEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is an even number.", number);
            }
            else
            {
                Console.WriteLine("{0} is an odd number.", number);
            }
        }

        public static void CheckIfDivisibleByThree(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("{0} is divisable by three.", number);
            }
            else
            {
                Console.WriteLine("{0} is not divisable by three.", number);
            }
        }

        public static void CheckIfPrime(int number)
        {
            if (IsPrime(number))
            {
                Console.WriteLine("{0} is a prime number.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number.", number);
            }
        }
        private static bool IsPrime(int number)
        {
            if (!(number % 2 == 0) || number != 2)
            {
                if (number > 2)
                {
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return true;
        }
    }
}
