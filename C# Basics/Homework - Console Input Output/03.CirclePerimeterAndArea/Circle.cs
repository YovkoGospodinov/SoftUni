using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterAndArea
{
    class Circle
    {
        static void Main()
        {
            Console.WriteLine("Please enter radius of a circle to calculate its perimeter and area!");
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The perimeter of the circle with radius of {0}cm is {1:F2}cm and its area is {2:F2}cm!", radius, perimeter, area);
        }
    }
}
