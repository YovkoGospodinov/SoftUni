using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number < 400)
                {
                    p2++;
                }
                else if (number >= 400 && number < 600)
                {
                    p3++;
                }
                else if (number >= 600 && number < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }            

            Console.WriteLine("{0:F2}%", p1 * 100 / n);
            Console.WriteLine("{0:F2}%", p2 * 100 / n);
            Console.WriteLine("{0:F2}%", p3 * 100 / n);
            Console.WriteLine("{0:F2}%", p4 * 100 / n);
            Console.WriteLine("{0:F2}%", p5 * 100 / n);
        }
    }
}
