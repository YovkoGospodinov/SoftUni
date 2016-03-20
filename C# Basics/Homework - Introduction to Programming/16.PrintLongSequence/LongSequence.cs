using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintLongSequence
{
    class LongSequence
    {
        static void Main()
        {
            for (int i = 2; i <= 1001; i++)
            {
                int num = i;
                if (i % 2 != 0)
                {
                    num = -num;
                }
                Console.Write("{0}{1}", num, ",");
            }

            Console.WriteLine();
        }
    }
}
