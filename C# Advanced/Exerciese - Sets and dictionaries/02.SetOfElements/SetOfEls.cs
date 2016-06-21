namespace _02.SetOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SetOfEls
    {
        public static void Main()
        {
            //string[] input = Console.ReadLine().Split(' ');

            //int n = int.Parse(input[0]);
            //int m = int.Parse(input[1]);

            //HashSet<int> nSet = new HashSet<int>();
            //HashSet<int> mSet = new HashSet<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    nSet.Add(int.Parse(Console.ReadLine()));
            //}
            //for (int i = 0; i < m; i++)
            //{
            //    mSet.Add(int.Parse(Console.ReadLine()));
            //}

            //var newSet = nSet.Intersect(mSet);

            //Console.WriteLine(string.Join(" ", newSet));


            int[] sizes = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x))
                .ToArray();

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < sizes[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < sizes[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            var result = firstSet.Intersect(secondSet);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
