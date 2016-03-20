using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideH = double.Parse(Console.ReadLine());
            double area = ((sideA + sideB) * sideH) / 2;
            Console.WriteLine("The area of the trapezoid is {0}", area);
        }
    }
}
