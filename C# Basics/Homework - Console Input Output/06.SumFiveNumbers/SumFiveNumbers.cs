using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumFiveNumbers
{
    class SumFiveNumbers
    {
        static void Main()
        {
            string sequence = Console.ReadLine();

            //If the sequences are entered in the code
            //string sequence = "1 2 3 4 5";
            //string sequence = "10 10 10 10 10";
            //string sequence = "1.5 3.14 8.2 -1 0";

            char[] delimer = new char[] { ' ' };

            string[] elements = sequence.Split(delimer);

            //Printing each number of the sequence on a separate line
            //Console.WriteLine(elements[0]);
            //Console.WriteLine(elements[1]);
            //Console.WriteLine(elements[2]);
            //Console.WriteLine(elements[3]);
            //Console.WriteLine(elements[4]);

            double firstElement = double.Parse(elements[0]);
            double secondElement = double.Parse(elements[1]);
            double thirdElement = double.Parse(elements[2]);
            double fourthElement = double.Parse(elements[3]);
            double fifthElement = double.Parse(elements[4]);


            double sum = firstElement + secondElement + thirdElement + fourthElement + fifthElement;
            Console.WriteLine(sum);


            //Easier and sorter way to solve the problem
            //string[] sequence = Console.ReadLine().Split();
            //double sum = 0;
            //for (int i = 0; i < sequence.Length; i++)
            //{
            //    double a = double.Parse(sequence[i]);
            //    sum += a;
            //}
            //Console.WriteLine(sum);
        }
    }
}
