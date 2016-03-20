using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool result = ((number % 5) == 0) && ((number % 7) == 0);
            Console.WriteLine("The entered number {0} is devide by 5 and 7 at the same time - {1}", number, result);
        }
    }
}
