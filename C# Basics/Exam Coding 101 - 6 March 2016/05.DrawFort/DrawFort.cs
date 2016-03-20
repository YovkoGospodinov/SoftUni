using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int hight = n;

            Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}", new string('/', 1), new string('^', n / 2), new string('\\', 1), new string('_', width - 4 - 2 * (n / 2)));

            if (n < 5)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.WriteLine("{0}{1}{0}", new string('|', 1), new string(' ', width - 2));
                }
            }
            else
            {
                for (int i = 0; i < n - 3; i++)
                {
                    Console.WriteLine("{0}{1}{0}", new string('|', 1), new string(' ', width - 2));
                }

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('|', 1), new string(' ', n / 2 + 1), new string('_', width - 4 - 2 * (n / 2)));
                }
            }            

            Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}", new string('\\', 1), new string('_', n / 2), new string('/', 1), new string(' ', width - 4 - 2 * (n / 2)));
        }
    }
}
