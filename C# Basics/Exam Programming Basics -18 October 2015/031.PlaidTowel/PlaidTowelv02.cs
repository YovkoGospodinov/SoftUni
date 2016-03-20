using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031.PlaidTowel
{
    class PlaidTowelv02
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char outerlineSymbols = char.Parse(Console.ReadLine());
            char innerlineSymbols = char.Parse(Console.ReadLine());
            int size = 4 * n + 1;

            Console.WriteLine("{0}{1}{2}{1}{0}", new string(outerlineSymbols, n), innerlineSymbols, new string(outerlineSymbols, 2*n -1));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(outerlineSymbols, n - 1 - i), innerlineSymbols, new string(outerlineSymbols, 1 + 2 * i), new string(outerlineSymbols, (2 * n - 3) - 2 * i));
            }

            Console.WriteLine("{0}{1}{0}{1}{0}", innerlineSymbols, new string(outerlineSymbols, 2 * n - 1));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(outerlineSymbols, 1 + i), innerlineSymbols, new string(outerlineSymbols, (2 * n - 3) - 2 * i), new string(outerlineSymbols, 1 + 2 * i));
            }

            Console.WriteLine("{0}{1}{2}{1}{0}", new string(outerlineSymbols, n), innerlineSymbols, new string(outerlineSymbols, 2 * n - 1));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(outerlineSymbols, n - 1 - i), innerlineSymbols, new string(outerlineSymbols, 1 + 2 * i), new string(outerlineSymbols, (2 * n - 3) - 2 * i));
            }

            Console.WriteLine("{0}{1}{0}{1}{0}", innerlineSymbols, new string(outerlineSymbols, 2 * n - 1));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(outerlineSymbols, 1 + i), innerlineSymbols, new string(outerlineSymbols, (2 * n - 3) - 2 * i), new string(outerlineSymbols, 1 + 2 * i));
            }

            Console.WriteLine("{0}{1}{2}{1}{0}", new string(outerlineSymbols, n), innerlineSymbols, new string(outerlineSymbols, 2 * n - 1));
        }
    }
}
