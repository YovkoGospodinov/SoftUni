using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int originalNumber = int.Parse(Console.ReadLine());
            int firstDigit = originalNumber % 10;

            int threeDigitNumber = originalNumber / 10;
            int secondDigit = threeDigitNumber % 10;

            int twoDigitNumber = originalNumber / 100;
            int thirdDigit = twoDigitNumber % 10;

            int oneDigitNumber = originalNumber / 1000;
            int fourthDigit = oneDigitNumber % 10;

            int digitSum = firstDigit + secondDigit + thirdDigit + fourthDigit;

            Console.WriteLine("The sum of digits is {0}", digitSum);

            Console.WriteLine("The number with reversed digits is {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);

            Console.WriteLine("The number with last digit in front is {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);

            Console.WriteLine("The number with second and third digits exchanged is {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        }
    }
}
