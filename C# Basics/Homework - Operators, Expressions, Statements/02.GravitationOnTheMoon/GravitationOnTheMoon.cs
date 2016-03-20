using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            {
                double weightEarth = double.Parse(Console.ReadLine());
                double weightMoon = weightEarth * 0.17;
                Console.WriteLine("If the weight on earth is:{0}, the weight on the moon will be:{1}", weightEarth, weightMoon);
            }
        }
    }
}

