using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();
            decimal price = 0;

            if (kilometers < 20)
            {
                price += 0.7m;
                if (d == "day")
                {
                    price += kilometers * 0.79m;
                }
                else
                {
                    price += kilometers * 0.90m;
                }
            }
            else if (kilometers >= 100)
            {
                price += kilometers * 0.06m;
            }
            else
            {
                price += kilometers * 0.09m;
            }

            Console.WriteLine("{0:0.##}", price);
        }
    }
}
