using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            int digitPosition = int.Parse(Console.ReadLine());
            bool isOne = true;
            string binaryNumber = Convert.ToString(decimalNumber, 2).PadLeft(16, '0');
            Console.WriteLine(binaryNumber);
            int shiftDecimalNumber = decimalNumber >> digitPosition;
            string newBinaryNumber = Convert.ToString(shiftDecimalNumber, 2).PadLeft(16, '0');
            Console.WriteLine(newBinaryNumber);
            int digit = shiftDecimalNumber & 1;
            if (digit == 1)
            {
                Console.WriteLine(isOne);
            }
            else
            {
                Console.WriteLine(!isOne);
            }

        }
    }
}
