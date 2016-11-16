using Labb11.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb11.Managers
{
    public delegate void AnalyzeNumber(int number);

    class NumberManager
    {
        private event AnalyzeNumber NumberInput;

        public void PrintAllFilterResults(int input)
        {
            NumberInput += new AnalyzeNumber(NumberFilters.CheckIfEven);
            NumberInput += new AnalyzeNumber(NumberFilters.CheckIfDivisibleByThree);
            NumberInput += new AnalyzeNumber(NumberFilters.CheckIfPrime);
            NumberInput?.Invoke(input);
        }
    }
}
