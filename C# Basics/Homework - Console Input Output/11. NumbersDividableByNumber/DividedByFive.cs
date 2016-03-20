using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersDividableByNumber
{
    class DividedByFive
    {
        static void Main()
        {
            int userInput1 = int.Parse(Console.ReadLine());
            int userInput2 = int.Parse(Console.ReadLine());
            int numbersDividable = 0;
            for (int i = userInput1; i <= userInput2; i++)
            {
                if (i % 5 == 0)
                {
                    numbersDividable += 1;
                    //This will print the numbers divided by five in the sequence
                    //Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine("\n{0}", numbersDividable);
        }
    }
}
