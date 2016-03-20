using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SummertimeForProgrammers
{
    class Summertime
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int topWidth = input + 1;
            int bottomWidth = 2 * input;
            int height = 3 * input + 1;

            Console.WriteLine("{0}{1}{0}", new string(' ', (bottomWidth - topWidth) / 2), new string('*', topWidth));

            for (int i = 0; i < input / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(' ', (bottomWidth - topWidth) / 2), new string('*', 1), new string(' ', topWidth - 2));
            }

            for (int i = 0; i < input / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(' ', (bottomWidth - topWidth) / 2 - 1 - i), new string('*', 1), new string(' ', topWidth + 2 * i));
            }

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('*', 1), new string('.', bottomWidth - 2));
            }

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('*', 1), new string('@', bottomWidth - 2));
            }

            Console.WriteLine("{0}", new string('*', bottomWidth));
        }
    }
}
