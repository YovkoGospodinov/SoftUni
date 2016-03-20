using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Sunlight
{
    class Sun
    {
        static void Main()
        {
            //To do is not done yet 

            int number = int.Parse(Console.ReadLine());

            char dot = '.';
            char star = '*';


            Console.WriteLine("{0}{1}{0}", new String(dot, (number * 3) / 2), star);

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new String(dot, 1 + i), star, new String(dot, 2 - i));

            }

            Console.WriteLine("{0}", new String(star, number * 3));

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new String(dot, 3 - i), star, new String(dot, i));

            }

            Console.WriteLine("{0}{1}{0}", new String(dot, (number * 3) / 2), star);
        }
    }
}
