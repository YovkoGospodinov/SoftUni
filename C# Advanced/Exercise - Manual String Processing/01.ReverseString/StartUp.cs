using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();

            //char[] output = new char[input.Length];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[input.Length - 1 - i]);
            }
            //Console.WriteLine(string.Join("", output));
            Console.WriteLine(sb.ToString());
        }
    }
}
