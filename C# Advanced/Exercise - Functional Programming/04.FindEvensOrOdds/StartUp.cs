using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindEvensOrOdds
{
    class StartUp
    {
        static void Main()
        {
            int[] borders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = borders[0];
            int end = borders[1];

            List<int> numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            string command = Console.ReadLine();

            List<int> result = new List<int>();

            if (command == "even")
            {
                Predicate<int> isEven = x => x % 2 == 0;
                foreach (int number in numbers)
                {
                    if (isEven(number))
                    {
                        result.Add(number);
                    }
                }
            }
            else
            {
                Predicate<int> isOdd = x => x % 2 != 0;
                foreach (int number in numbers)
                {
                    if (isOdd(number))
                    {
                        result.Add(number);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
