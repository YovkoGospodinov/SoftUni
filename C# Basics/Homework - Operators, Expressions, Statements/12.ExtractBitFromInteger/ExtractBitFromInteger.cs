using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            int digitPosition = int.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(decimalNumber, 2).PadLeft(16, '0');
            Console.WriteLine(binaryNumber);
            int shiftDecimalNumber = decimalNumber >> digitPosition;
            string newBinaryNumber = Convert.ToString(shiftDecimalNumber, 2).PadLeft(16, '0');
            Console.WriteLine(newBinaryNumber);
            int digit = shiftDecimalNumber & 1;
            Console.WriteLine(digit);
        }
    }
}
