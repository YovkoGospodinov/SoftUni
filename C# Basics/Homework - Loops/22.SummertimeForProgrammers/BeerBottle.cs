﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.SummertimeForProgrammers
{
    class BeerBottle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string(' ', ((2 * n) - (n + 1)) / 2), new string('*', n + 1));

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(' ', ((2 * n) - (n + 1)) / 2), new string('*', 1), new string(' ', n - 1 ));
            }

            for (int i = (n - 2) / 2; i > 0; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(' ', (i)), new string('*', 1), new string(' ', 2*n - 2 - 2*i));
            }
            //for (int i = 0; i < (n - 2) / 2; i++)
            //{
            //    Console.WriteLine("{0}{1}{2}{1}{0}", new string(' ', (i + 1)), new string('*', 1), new string(' ', n + 2*i));
            //}

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('*', 1), new string('.', 2*n - 2));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('*', 1), new string('@', 2 * n - 2));
            }

            Console.WriteLine("{0}", new string('*', 2 * n));
        }
    }
}
