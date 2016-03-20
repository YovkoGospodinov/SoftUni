using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BeerTime
{
    class Beer
    {
        static void Main()
        {
            //To do is not done yet 

            DateTime input = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(input);

            DateTime start = new DateTime(13, 00);
            DateTime end = new DateTime(3, 00);

            if (input >= start && input <= end)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}
