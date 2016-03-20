using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FormattingNumbers
{
    class Formatting
    {
        static void Main()
        {
            Console.WriteLine("Please enter three numbers!");
            Console.Write("First number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            if (firstNumber >= 0 && firstNumber <= 500)
            {
                Console.Write("Second number: ");
                double secondNumber = double.Parse(Console.ReadLine());
                Console.Write("Third number: ");
                double thirdNumber = double.Parse(Console.ReadLine());
                string firstNumberBinary = Convert.ToString(firstNumber, 2).PadLeft(10, '0');
                Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|", firstNumber, firstNumberBinary, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("Please enter again first number must be in interval form 0 to 500!");
            }
        }
    }
}
