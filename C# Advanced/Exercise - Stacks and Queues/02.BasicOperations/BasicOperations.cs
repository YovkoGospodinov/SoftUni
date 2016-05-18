using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BasicOperations
{
    class BasicOperations
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int pushedEl = input[0];
            int popedEl = input[1];
            int containedEl = input[2];
            int smallestEl = int.MaxValue;
            Stack<int> numbers = new Stack<int>();
            int[] inputNumbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < pushedEl; i++)
            {
                numbers.Push(inputNumbers[i]);
            }
            for (int i = 0; i < popedEl; i++)
            {
                int currentPoped = numbers.Pop();
            }
            bool isContainEl = numbers.Contains(containedEl);

            if (isContainEl)
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.Count > 0)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentPoped = numbers.Pop();
                        if (currentPoped < smallestEl)
                        {
                            smallestEl = currentPoped;
                        }
                    }
                    Console.WriteLine(smallestEl);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
