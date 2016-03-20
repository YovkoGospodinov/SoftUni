using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AceOfDiamonds
{
    class Diamonds
    {
        static void Main()
        {
            
            int input = int.Parse(Console.ReadLine());
            int dash = (input - 3) / 2;
            

            Console.WriteLine("{0}", new string('*', input));

            for (int i = 0; i < (input - 3) / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('*', 1), new string('-', dash - i), new string('@', 1 + 2*i));
            }

            Console.WriteLine("{0}{1}{0}", new string('*', 1), new string('@', input - 2));

            for (int i = (input - 3) / 2; i > 0; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('*', 1), new string('-', dash - i + 1), new string('@', 2 * i -  1));
            }

            Console.WriteLine("{0}", new string('*', input));

        }
    }
}
