using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.ConvertNBaseTo10
{
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            int systemBase = int.Parse(input[0]);
            string nBaseNumber = input[1];
            BigInteger result = 0;
            for (int i = 0; i < nBaseNumber.Length; i++)
            {
                int digit = (nBaseNumber[i] - '0');
                result = digit + systemBase * result;
            }

            Console.WriteLine(result);
        }
    }
}
