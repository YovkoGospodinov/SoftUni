using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PlaidTowel
{
    class Towel
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char fillCharacter =  char.Parse(Console.ReadLine());
            char outlineCharacter = char.Parse(Console.ReadLine());

            int size = 4 * n + 1;
            int symbolsLeft = n;
            int increment = 1;
            int innerSymbolsInRhombus;
            int innerMaxSizeOfRhombus = 2 * n - 1;

            for (int row = 0; row < size; row++)
            {
                //First row with 2 outline symbols
                if (symbolsLeft == n)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string(fillCharacter, symbolsLeft), outlineCharacter, new string(fillCharacter, (size - 2 - 2 * symbolsLeft)));
                    increment *= -1;
                }
                //Middle row of rhombus with 3#
                else if (symbolsLeft == 0)
                {
                    Console.WriteLine("{0}{1}{0}{1}{0}", outlineCharacter, new string(fillCharacter, (size - 3) / 2));
                    increment *= -1;
                }
                //Main pattern of Rhombus
                else
                {
                    innerSymbolsInRhombus = innerMaxSizeOfRhombus - 2 * symbolsLeft;
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(fillCharacter, symbolsLeft), outlineCharacter, new string(fillCharacter, innerSymbolsInRhombus), new string(fillCharacter, size - 4 - 2 * innerSymbolsInRhombus - 2 * symbolsLeft));
                }
                symbolsLeft += increment;
            }
        }
    }
}
