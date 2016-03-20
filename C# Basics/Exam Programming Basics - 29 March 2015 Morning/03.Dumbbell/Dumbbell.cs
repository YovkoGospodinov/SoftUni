using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Dumbbell
{
    class Dumbbell
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int width = 3 * input;
            int pattern = (width - input) / 2;
            int stars = input / 2;
            int dots = input / 2 - 1;

            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (input / 2)), new string('&', (input / 2) + 1), new string('.', input));

            for (int i = 0; i < input / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', dots - i), '&', new string('*', stars + i), new string('.', input));
            }

            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '&', new string('*', pattern - 2), new string('=', input));

            for (int i = input / 2 - 1; i > 0; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', dots - i + 1), '&', new string('*', stars + i - 1), new string('.', input));
            }

            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (input / 2)), new string('&', (input / 2) + 1), new string('.', input));
        }
    }
}
