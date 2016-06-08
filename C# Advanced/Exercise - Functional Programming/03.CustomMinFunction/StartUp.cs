using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CustomMinFunction
{
    class StartUp
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            Func<int[], int> minValueFunc = list =>
            {
                int minValue = int.MaxValue;
                foreach (var number in list)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }

                return minValue;
            };
            
            Console.WriteLine(minValueFunc(numbers));
        }

    }
}
