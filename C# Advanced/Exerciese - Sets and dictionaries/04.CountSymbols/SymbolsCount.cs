namespace _04.CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class SymbolsCount
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> sylmbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (!sylmbols.ContainsKey(currentSymbol))
                {
                    sylmbols.Add(currentSymbol, 1);
                }
                else
                {
                    int value = sylmbols[currentSymbol];
                    sylmbols[currentSymbol] = value + 1;
                }
            }

            foreach (var kvp in sylmbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
