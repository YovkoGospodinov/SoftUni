using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KnightsOfHonor
{
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Action<string> act = x => Console.WriteLine("Sir " + x);

            foreach (string name in input)
            {
                act(name);
            }
        }
    }
}
