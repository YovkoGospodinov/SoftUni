using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheBiggestOfFiveNumbers
{
    class BiggestOfFive
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            double fourthNumber = double.Parse(Console.ReadLine());
            double fifthNumber = double.Parse(Console.ReadLine());

            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber) && (firstNumber > fourthNumber) && (firstNumber > fifthNumber))
            {
                Console.WriteLine("The biggest number is {0}", firstNumber);
            }

            else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber) && (secondNumber > fourthNumber) && (secondNumber > fifthNumber))
            {
                Console.WriteLine("The biggest number is {0}", secondNumber);
            }

            else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber) && (thirdNumber > fourthNumber) && (thirdNumber > fifthNumber))
            {
                Console.WriteLine("The biggest number is {0}", thirdNumber);
            }

            else if ((fourthNumber > firstNumber) && (fourthNumber > secondNumber) && (fourthNumber > thirdNumber) && (fourthNumber > fifthNumber))
            {
                Console.WriteLine("The biggest number is {0}", fourthNumber);
            }

            else
            {
                Console.WriteLine("The biggest number is {0}", fifthNumber);
            }
        }
    }
}
