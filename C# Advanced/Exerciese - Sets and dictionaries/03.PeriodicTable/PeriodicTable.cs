namespace _03.PeriodicTable
{
    using System;
    using System.Collections.Generic;

    public class PeriodicTable
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> chemicalelements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < input.Length; j++)
                {
                    chemicalelements.Add(input[j]);
                }
            }

            Console.WriteLine(string.Join(" ", chemicalelements));
        }
    }
}
