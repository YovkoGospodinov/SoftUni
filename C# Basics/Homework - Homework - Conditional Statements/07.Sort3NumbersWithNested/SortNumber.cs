using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort3NumbersWithNested
{
    class SortNumber
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", firstNumber, " ", secondNumber, " ", thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", firstNumber, " ", thirdNumber, " ", secondNumber);
                }
            }

            else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber))
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", secondNumber, " ", firstNumber, " ", thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", secondNumber, " ", thirdNumber, " ", firstNumber);
                }
            }

            else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber))
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", thirdNumber, " ", firstNumber, " ", secondNumber);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", thirdNumber, " ", secondNumber, " ", firstNumber);
                }
            }

            else
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", thirdNumber, " ", secondNumber, " ", firstNumber); //In case when the numbers are equal
            }
        }
    }
}
