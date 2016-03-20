using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumThreeNumbers
{
    class SumOfThree
    {
        static void Main()
        {
            Console.WriteLine("Pleae enter three number to calculate their sum!");
            Console.Write("First number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Third number:");
            double thirdNumber = double.Parse(Console.ReadLine());
            double sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("The sum of the entered numbers is: {0}", sum);
        }
    }
}
