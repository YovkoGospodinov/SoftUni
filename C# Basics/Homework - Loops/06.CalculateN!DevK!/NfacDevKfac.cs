using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.CalculateN_DevK_
{
    class NfacDevKfac
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;

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

                Console.WriteLine("{0}", factorialN / factorialK);
            }
            else
            {
                Console.WriteLine("Incorect input");
            }
        }
    }
}
