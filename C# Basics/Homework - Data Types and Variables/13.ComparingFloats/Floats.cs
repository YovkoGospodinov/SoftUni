using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class Floats
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            bool isEqual = true;
            double eps = (a - b);
            if (Math.Abs(eps) < 0.000001)
            {
                Console.WriteLine(isEqual);
            }
            else
            {
                Console.WriteLine(!isEqual);
            }
        }
    }
}
