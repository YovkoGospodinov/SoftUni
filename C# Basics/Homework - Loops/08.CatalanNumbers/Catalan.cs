using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08.CatalanNumbers
{
    class Catalan
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorialN = 1;
            BigInteger factorial2N = 1;
            BigInteger factorialNPlus1 = 1;

            if (1 < n && n < 100)
            {
                for (int i = 1; i <= 2*n; i++)
                {
                    factorial2N *= i;
                    if (i <= n)
                    {
                        factorialN *= i;
                    }
                }

                for (int i = 1; i <= n+1; i++)
                {
                    factorialNPlus1 *= i;
                }

                Console.WriteLine("{0}", factorial2N / (factorialNPlus1 * factorialN));
            }
            else
            {
                Console.WriteLine("Incorect input");
            }
            
        }
    }
}
