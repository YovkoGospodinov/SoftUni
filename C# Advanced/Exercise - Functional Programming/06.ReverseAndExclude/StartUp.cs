using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseAndExclude
{
    class StartUp
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> Isdivisible = x => x % n == 0;

            Action<int> act = x => Console.WriteLine(x);

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (!Isdivisible(numbers[i]))
                {
                    result.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
