using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HalfSum
{
    class Sum
    {
        static void Main()
        {
            int firstSum = 0;
            int secondSum = 0;

            int rounds = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2 * rounds; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < rounds)
                {
                    firstSum += number;
                }
                else
                {
                    secondSum += number;
                }
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum={0}", firstSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(firstSum - secondSum));
            }
        }
    }
}
