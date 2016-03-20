using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrintFirstLastName
{
    class FirstLastName
    {
        static void Main()
        {
            string firstName = "Pesho";
            string lastName = "Ivanov";
            Console.WriteLine("{0}{1}{2}", firstName, Environment.NewLine, lastName);
            //Console.WriteLine("Pesho\nIvanov"); This is another way to solve the problem.
        }
    }
}
