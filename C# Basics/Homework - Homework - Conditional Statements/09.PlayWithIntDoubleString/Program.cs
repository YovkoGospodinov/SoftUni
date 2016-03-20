using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithIntDoubleString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            int digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 1:
                    Console.WriteLine("Please enter a int");
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0}", intNumber + 1);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double");
                    double doubleNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0}", doubleNumber + 1);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string");
                    string stringInput = Console.ReadLine();
                    Console.WriteLine("{0}", stringInput + "*");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;

            }
        }
    }
}
