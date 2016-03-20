using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExchangeVariableValues
{
    class Exchange
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}
