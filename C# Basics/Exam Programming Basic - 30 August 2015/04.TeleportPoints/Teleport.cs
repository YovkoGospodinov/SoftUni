using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TeleportPoints
{
    class Teleport
    {
        static void Main()
        {
            double[] pointA = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] pointB = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] pointC = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] pointD = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double radius = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());
            int counter = 0;
            //right
            for (double x = 0; x <= radius; x+=step)
            {
                for (double y = 0; y <= radius; y+=step)
                {
                    if ((x * x) + (y * y) <= radius * radius)
                    {
                        if ((x > pointA[0] && x < pointC[0]) && (y > pointA[1] && y < pointC[1]))
                        {
                            counter++;
                        }
                    }
                }
                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((x * x) + (y * y) <= radius * radius)
                    {
                        if ((x > pointA[0] && x < pointC[0]) && (y > pointA[1] && y < pointC[1]))
                        {
                            counter++;
                        }
                    }
                }
            }
            //left
            for (double x = -step; x >= -radius; x -= step)
            {
                for (double y = 0; y <= radius; y += step)
                {
                    if ((x * x) + (y * y) <= radius * radius)
                    {
                        if ((x > pointA[0] && x < pointC[0]) && (y > pointA[1] && y < pointC[1]))
                        {
                            counter++;
                        }
                    }
                }
                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((x * x) + (y * y) <= radius * radius)
                    {
                        if ((x > pointA[0] && x < pointC[0]) && (y > pointA[1] && y < pointC[1]))
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
