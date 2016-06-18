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
            Stack<int> maxNumbers = new Stack<int>();
            int maximumEl = int.MinValue;
            for (int i = 0; i < queries; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                if (command == "1")
                {
                    int numberToPush = int.Parse(input[1]);
                    numbers.Push(numberToPush);
                    if (maxNumbers.Count == 0 || numberToPush >= maxNumbers.Peek())
                    {
                        maxNumbers.Push(numberToPush);
                    }
                }
                else if (command == "2")
                {
                    int numberAtTop = numbers.Pop();
                    int maxNumber = maxNumbers.Peek();
                    if (numberAtTop == maxNumber)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count > 0)
                        {
                            maximumEl = maxNumbers.Peek();
                        }
                    }
                }
                else
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
