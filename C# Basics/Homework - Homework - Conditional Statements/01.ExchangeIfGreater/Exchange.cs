using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeIfGreater
{
    class Exchange
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("The first number is {0}\nThe second number is {1}", firstNumber, secondNumber);

            if (firstNumber > secondNumber)
            {
                double thirdNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                Console.WriteLine("{0}{1}{2}", firstNumber, ' ', secondNumber);
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", firstNumber, ' ', secondNumber);
            }
        }
    }
}
