using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + hight);
            double area = width * hight;

            Console.WriteLine("The perimeter of the rectangle is {0} the area is of the rectangle is {1}", perimeter, area);
        }
    }
}
