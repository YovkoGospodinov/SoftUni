using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEvenInteger
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            bool isOdd = true;
            int number = int.Parse(Console.ReadLine());
            bool result = (number % 2) == 0 ? !isOdd : isOdd;
            Console.WriteLine("Odd? :{0}", result);
        }
    }
}
