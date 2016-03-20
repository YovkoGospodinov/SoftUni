using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.Write("Please write your birthdate: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            Console.WriteLine("Now You are {0} years old.", age);
            Console.WriteLine("After ten years you will be {0} years old.", age + 10);
        }
    }
}
