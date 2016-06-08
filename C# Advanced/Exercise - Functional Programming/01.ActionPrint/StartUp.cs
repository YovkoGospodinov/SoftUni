using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionPrint
{
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            Action<string> act = x => Console.WriteLine(x);

            foreach (string name in input)
            {
                act(name);
            }
        }
    }
}
