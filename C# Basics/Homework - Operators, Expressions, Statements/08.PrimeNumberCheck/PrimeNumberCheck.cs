using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer number n (n<=100)");
            int number = int.Parse(Console.ReadLine());
            double maxDivider = Math.Sqrt(number);
            bool isPrime = true;
            while (number > 100)
            {
                Console.WriteLine("Invalid input, the number has to be <=100");
                number = int.Parse(Console.ReadLine());
            }

            if (number < 2)
            {
                Console.WriteLine("The number is prime: {0}", !isPrime);
                return;
            }

            for (int i = 2; i <= maxDivider; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("The number is prime: {0}", !isPrime);
                    return;
                }
            }
            Console.WriteLine("The number is prime: {0}", isPrime);
        }
    }
}
