using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IlluminatiLock
{
    class Illuminati
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int height = n + 1;
            int width = 3 * n;

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}", new string('.', n - 2 - 2 * i), "##", new string('.', 2 * i), '#', new string('.', n - 2));
            }

            for (int i = n / 2 - 1; i >= 0 ; i--)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}", new string('.', n - 2 - 2 * i), "##", new string('.', 2 * i), '#', new string('.', n - 2));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        }
    }
}
