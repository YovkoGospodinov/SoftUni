using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            int digitPosition = int.Parse(Console.ReadLine());
            int digitForReplace = int.Parse(Console.ReadLine());

            string binaryNumber = Convert.ToString(decimalNumber, 2).PadLeft(16, '0');
            Console.WriteLine(binaryNumber);

            int mask = 1 << digitPosition;

            int newDecimalNumber = 0;
            if (digitForReplace == 1)
            {
                newDecimalNumber = decimalNumber | mask;
            }
            else if (digitForReplace == 0)
            {
                newDecimalNumber = decimalNumber ^ mask;
            }

            string newBinaryNumber = Convert.ToString(newDecimalNumber, 2).PadLeft(16, '0');
            Console.WriteLine(newBinaryNumber);
            Console.WriteLine(newDecimalNumber);

        }
    }
}
