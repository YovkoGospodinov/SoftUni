using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FormatingNums
{
    class StartUp
    {
        static void Main()
        {
            //254	11.6	0.5
            string[] numbers = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            long firstNumber = long.Parse(numbers[0]);
            double secondNumber = double.Parse(numbers[1]);
            double thirdNumber = double.Parse(numbers[2]);
            string firstNumberBinary = Convert.ToString(firstNumber, 2).PadLeft(10, '0').Substring(0, 10);
            Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|", firstNumber, firstNumberBinary, secondNumber, thirdNumber);
        }
    }
}
