using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class Product
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int productOdd = 1;
            int productEven = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    productEven *= Convert.ToInt32(numbers[i]);
                }
                else
                {
                    productOdd *= Convert.ToInt32(numbers[i]);
                }
            }
            if (productEven == productOdd)
            {
                Console.WriteLine("yes\nproduct = {0}", productOdd);
            }
            else
            {
                Console.WriteLine("no\nodd_product = {0}\neven_product = ", productOdd, productEven);
            }
        }
    }
}
