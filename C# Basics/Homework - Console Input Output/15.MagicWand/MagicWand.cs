using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.MagicWand
{
    class MagicWand
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 2;

            Console.WriteLine("{0}{1}{0}", new string('.', (3 * n + 2)/2), '*');
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (width - (3 + 2 * i))/2), '*', new string('.', 1 + 2 * i));
            }

            Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n + 2));
            
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i + 1), '*', new string('.', width - (4 + 2 * i)));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{4}{1}{3}{1}{2}{1}{0}", new string('.', n/2 -1-i), '*', new string('.', n / 2), new string('.', i), new string('.', n));
            }

            Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", new string('*', n / 2 + 1), new string('.', n / 2), '*', new string('.', n));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}{1}{0}", new string('.', n), new string('*', 1));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n + 2));
        }
    }
}
