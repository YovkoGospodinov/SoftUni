using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintASCIITable
{
    class AsciiTable
    {
        static void Main()
        {
            //Using loops
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine((char)i);
            }
            
            //Using while
            //int n = 0;
            //while (n <= 255)
            //{
            //    n++;
            //    Console.WriteLine((char)n);
            //}
        }
    }
}
