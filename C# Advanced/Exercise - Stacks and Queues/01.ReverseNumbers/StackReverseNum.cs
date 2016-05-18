using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseNumbers
{
    class StackReverseNum
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToArray();
            
            Stack<long> numbers = new Stack<long>();
            for (long i = 0; i < input.Length; i++)
            {
                numbers.Push(input[i]);
            }
            for (long i = 0; i < input.Length; i++)
            {
                Console.Write(numbers.Pop() + " ");
            }
        }
    }
}
