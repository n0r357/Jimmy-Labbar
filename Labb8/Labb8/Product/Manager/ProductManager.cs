using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class ProductManager
    {
        public string[] FormatProductNamesFromList(List<IProduct> inputProductList)
        {
            string[] productNames = new string[inputProductList.Count];
            return productNames = inputProductList.Select(product => product.Name).ToArray();
        }
        public double[] FormatProductPricesFromList(List<IProduct> inputProductList)
        {
            double[] productPrices = new double[inputProductList.Count];
            return productPrices = inputProductList.Select(product => product.Price).ToArray();
        }

        public double AddPercentageToTotalPrice(double[] inputPriceArray)
        {
            double result = 0;

            foreach (var productprice in inputPriceArray)
            {
                result += productprice;
            }
            return result *= 1.2;
        }
        public double SubtractDiscountFromHighPrices(double[] inputPriceArray)
        {
            double result = 0;

            foreach (var productprice in inputPriceArray)
            {
                if (productprice >= 1000)
                {
                    result += productprice;
                }
            }
            return result *= 0.9;
        }
    }
}
