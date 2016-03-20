using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumNNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            double sum = 0;
            double n = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
