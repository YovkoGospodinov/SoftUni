using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLenght
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input.Length == 20)
            {
                Console.WriteLine(input);
            }
            else if (input.Length < 20)
            {
                string output = input.PadRight(20, '*');
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(input.Substring(0, 20));
            }
        }
    }
}
