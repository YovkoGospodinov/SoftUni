using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PrintSequence
{
    class Sequence
    {
        static void Main()
        {
            //for (int i = 2; i <= 11; i++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write("{0}{1}", i, ",");
            //    }
            //    else
            //    {
            //        Console.Write("{0}{1}", -i, ",");
            //    }
            //}
            for (int i = 2; i <= 11; i++)
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
