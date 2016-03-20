using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberComparer
{
    class Comparer
    {
        static void Main()
        {
            Console.WriteLine("Please enter two numbers to find out which one is the greater!");
            Console.Write("First number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            double greaterNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The greater number between {0} and {1} is {2}!", firstNumber, secondNumber, greaterNumber);
        }
    }
}
