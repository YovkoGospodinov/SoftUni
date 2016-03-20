using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ChristmasTree
{
    class Tree
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('\'', input - i),
                    new string('^', 2 * i + 1));
            }

            for (int i = 1; i <= input / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('\'', input - i),
                    new string('^', 2 * i + 1));
            }
            for (int i = 0; i < input / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('\'', input - 1), '|', ' ');
            }

            Console.WriteLine(new string('-', 2 * input + 1));


        }
    }
}
