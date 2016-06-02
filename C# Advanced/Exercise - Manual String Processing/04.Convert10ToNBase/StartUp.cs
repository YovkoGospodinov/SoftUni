using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.Convert10ToNBase
{
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int systemBase = int.Parse(input[0]);
            BigInteger decNumber = BigInteger.Parse(input[1]);
            string result = "";
            do
            {
                result = decNumber % systemBase + result;
                decNumber /= systemBase;
            } while (decNumber > 0);

            Console.WriteLine(result);
        }
    }
}
