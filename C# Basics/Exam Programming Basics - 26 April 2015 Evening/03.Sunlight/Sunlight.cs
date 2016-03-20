using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sunlight
{
    class Sunlight
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int size = 3 * n;

            Console.WriteLine("{0}{1}{0}", new string('.', (size - 1) / 2), '*');

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', 1 + i), '*', new string('.', (size - 1) / 2 - (2 + i)));
            }

            for (int i = 0; i < (size - 3 - 2 * (n - 1)) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }

            Console.WriteLine(new string('*', size));

            for (int i = 0; i < (size - 3 - 2 * (n - 1)) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }

            for (int i = n - 2; i >= 0; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', 1 + i), '*', new string('.', (size - 1) / 2 - (2 + i)));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', (size - 1) / 2), '*');
        }
    }
}
