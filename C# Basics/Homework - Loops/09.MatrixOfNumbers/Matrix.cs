using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class Matrix
    {
        static void Main()
        {
            Console.WriteLine("Please enter a positive number");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
           
            if (n >= 1 && n <= 20)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j < n + 1; j++)
                    {
                        if (j + i > 9)
                        {
                            Console.Write("{0} ", j + i);
                        }
                        else
                        {
                            Console.Write("{0}  ", j + i);
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid numbers, the requirments for n are \"1 ≤ n ≤ 20\"");
            }
        }
    }
}
