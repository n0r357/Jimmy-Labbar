using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class Runtime
    {

        #region Delegates

        public delegate string StringConcatinator(string[] myStrings);
        public delegate double NumberOperator(double[] myPrices);

        #endregion

        #region G-Uppgifter

        public string CommaSeparatedString(string[] inputStringList)
        {
            string result = String.Empty;
            int index = 0;

            foreach (var inputstring in inputStringList)
            {
                index++;
                if (index < inputStringList.Count())
                {
                    result += inputstring + ", ";
                }
                else
                {
                    result += inputstring;
                }
            }
            return result;
        }

        public void NumberOperatorMethod(Func<List<float>, float> operatorResult)
        {
            MyLists myFloats = new MyLists();
            float result = operatorResult(myFloats.MyFloats);
            Console.WriteLine(result);
        }

        public void StartAssignment1()
        {
            MyLists myLists = new MyLists();
            string[] myStringArray = new string[myLists.MyStrings.Count];

            myStringArray = myLists.MyStrings.ToArray();
            Console.Clear();
            StringConcatinator newString = CommaSeparatedString;
            Console.WriteLine("{0} {1}", "Kommasepareradsträng:", newString(myStringArray));

            Func<List<float>, float> myAddFunc = (myFloats) =>
            {
                float result = 0;
                foreach (float inputFloat in myFloats)
                {
                    result += inputFloat;
                }
                return result;
            };
            Console.Write("Addition: ");
            NumberOperatorMethod(myAddFunc);

            Func<List<float>, float> myMultiFunc = (myFloats) =>
            {
                float result = 1;
                foreach (float inputFloat in myFloats)
                {
                    result *= inputFloat;
                }
                return result;
            };
            Console.Write("Multiplikation: ");
            NumberOperatorMethod(myMultiFunc);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Tryck på en knapp för att komma tillbaks till huvudmenyn.");
            Console.ReadKey();
        }

        #endregion

        #region VG-Uppgifter

        public void StartAssignment2()
        {
            MyLists list = new MyLists();
            ProductManager productManager = new ProductManager();
            StringConcatinator productString = CommaSeparatedString;

            Console.Clear();
            Console.WriteLine("{0} {1}", "Produktnamn:", productString(productManager.FormatProductNamesFromList(list.ProductList)));

            NumberOperator AddPercentageToTotalPrice = productManager.AddPercentageToTotalPrice;
            Console.WriteLine("{0} {1}", "Alla priser med 20%-påslag:", AddPercentageToTotalPrice(productManager.FormatProductPricesFromList(list.ProductList)));

            NumberOperator AddHighPricesAndSubtractDiscount = productManager.SubtractDiscountFromHighPrices;
            Console.WriteLine("{0} {1}", "Priser över 1000 med 10%-rabatt:", AddHighPricesAndSubtractDiscount(productManager.FormatProductPricesFromList(list.ProductList)));

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Tryck på en knapp för att komma tillbaks till huvudmenyn.");
            Console.ReadKey();
        }

        #endregion

    }
}
