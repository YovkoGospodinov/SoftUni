using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheBiggestOf3Numbers
{
    class BiggerOfThree
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("The biggest number is {0}", firstNumber);
            }

            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The biggest number is {0}", secondNumber);
            }

            else
            {
                Console.WriteLine("The biggest number is {0}", thirdNumber);
            }
        }
    }
}
