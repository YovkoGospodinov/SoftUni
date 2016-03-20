using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAverageOfNNumbers
{
    class MinMaxSumAverage
    {
        static void Main()
        {
            int nNumber = int.Parse(Console.ReadLine());
            double sum = 0;
            double avg = 0;
            int min = int.MaxValue;
            int max = int.MinValue;


            for (int i = 0; i < nNumber; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                sum += firstNumber;
                min = Math.Min(min, firstNumber);
                max = Math.Max(max, firstNumber);
                avg = sum / nNumber;

            }

            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avg);
        }
    }
}
