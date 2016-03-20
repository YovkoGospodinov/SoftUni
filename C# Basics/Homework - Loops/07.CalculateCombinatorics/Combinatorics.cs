using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateCombinatorics
{
    class Combinatorics
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorialNMinusK = n - k;

            if (1 < k && k < n && n < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                    if (i <= k)
                    {
                        factorialK *= i;
                    }
                }

                for (int i = 1; i <= factorialNMinusK; i++)
                {
                    factorialNMinusK *= i;
                }

                Console.WriteLine("{0}", factorialN / (factorialK * factorialNMinusK));
            }
            else
            {
                Console.WriteLine("Incorect input");
            }
        }
    }
}
