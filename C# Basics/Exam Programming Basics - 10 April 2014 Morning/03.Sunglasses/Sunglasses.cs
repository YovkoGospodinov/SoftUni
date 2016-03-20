using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int hight = int.Parse(Console.ReadLine());
            int widthFrame = 2 * hight;

            Console.WriteLine("{0}{1}{0}", new string('*', widthFrame), new string(' ', hight));

            for (int i = 0; i < (hight - 3) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', widthFrame - 2), new string(' ', hight));
            }

            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', widthFrame - 2), new string('|', hight));

            for (int i = 0; i < (hight - 3) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', widthFrame - 2), new string(' ', hight));
            }

            Console.WriteLine("{0}{1}{0}", new string('*', widthFrame), new string(' ', hight));
        }
    }
}
