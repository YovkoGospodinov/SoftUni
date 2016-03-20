using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate1plusNfacDXN
{
    class NfacDXN
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1.00;

            double factorial = 1.00;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial / Math.Pow(x, i);
            }.

            Console.WriteLine("{0:F5}", sum);
        }
    }
}
