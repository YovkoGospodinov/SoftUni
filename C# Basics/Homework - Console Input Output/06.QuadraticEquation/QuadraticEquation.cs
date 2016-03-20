using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Please enter coefficients a, b and c for the quadratic equation ax^2 + bx + c = 0 ");
            Console.Write("a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Your quadratic equation is {0}x^2 + {1}x + {2} = 0", a, b, c);
            double discriminative = Math.Pow(b, 2) - (4 * a * c);
            double result1 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            double result2 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            if (discriminative < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (result1 != result2)
            {
                Console.WriteLine("The real roots of your quadratic equation are x1={0} and x2={1}", result1, result2);
            }
            else if (result1 == result2)
            {
                Console.WriteLine("The real roots of your quadratic equation are x1=x2={0}", result1);
            }
        }
    }
}
