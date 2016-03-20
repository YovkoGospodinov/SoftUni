using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fallen_In_Love
{
    class FallenInLove
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}{1}{0}", new string('#', 2), new string('.', 2 * n));

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", new string('#', 1), new string('~', 1 + i), new string('.', 2 * n - 2 - 2 * i), new string('.', 2 + 2 * i));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', 1 + 2 * i), new string('#', 1), new string('~', n - i), new string('.', 2 * n - 2 * i));
            }

            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('#', 4));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 2), new string('#', 2));
            }            
        }
    }
}
