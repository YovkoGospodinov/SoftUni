using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TakeThePlaneDown
{
    class Plane
    {
        static void Main()
        {
            int headquaterX = int.Parse(Console.ReadLine());
            int headquaterY = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());

            int planeNumbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < planeNumbers; i++)
            {
                int planeX = int.Parse(Console.ReadLine());
                int planeY = int.Parse(Console.ReadLine());

                if ((((headquaterX - planeX) * (headquaterX - planeX)) + ((headquaterY - planeY) * (headquaterY - planeY))) <= radius * radius)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
                }
            }

            

        }
    }
}
