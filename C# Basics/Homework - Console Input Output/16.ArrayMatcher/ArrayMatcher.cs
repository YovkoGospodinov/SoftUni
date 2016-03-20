using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ArrayMatcher
{
    class ArrayMatcher
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('\\');
            string leftSide = input[0];
            string rightSide = input[1];
            if (input[2] == "join")
            {
                for (int i = 0; i < leftSide.Length; i++)
                {
                    for (int j = 0; j < rightSide.Length; j++)
                    {
                        if (leftSide[i] == rightSide[j])
                        {
                            Console.Write(leftSide[i]);
                        }
                    }
                }
                Console.WriteLine();
            }

            else if (input[2] == "right exclude")
            {
                //for (int i = 0; i < leftSide.Length; i++)
                //{
                //    for (int j = 0; j < rightSide.Length; j++)
                //    {
                //        if (leftSide[i] != rightSide[j])
                //        {
                //            Console.Write(leftSide[i]);
                //        }
                //    }
                //}
                char[] output = leftSide.Except(rightSide).ToArray();
                Array.Sort(output);
                Console.WriteLine(output);
            }

            else if (input[2] == "left exclude")
            {
                //for (int i = 0; i < leftSide.Length; i++)
                //{
                //    for (int j = 0; j < rightSide.Length; j++)
                //    {
                //        if (leftSide[i] != rightSide[j])
                //        {
                //            Console.Write(leftSide[j]);
                //        }
                //    }
                //}
                char[] output = rightSide.Except(leftSide).ToArray();
                Array.Sort(output);
                Console.WriteLine(output);
            }
        }
    }
}
