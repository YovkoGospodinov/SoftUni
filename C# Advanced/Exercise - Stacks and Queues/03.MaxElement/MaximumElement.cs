using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaxElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < queries; i++)
            {
                int[] input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (input.Length > 1)
                {
                    numbers.Push(input[1]);
                }
                else
                {
                    if (input[0] == 2)
                    {
                        numbers.Pop();
                    }
                    else
                    {
                        int maximumEl = int.MinValue;
                        foreach (int number in numbers)
                        {
                            if (number > maximumEl)
                            {
                                maximumEl = number;
                            }
                        }
                        Console.WriteLine(maximumEl);
                    }
                }
            }
        }
    }
}
