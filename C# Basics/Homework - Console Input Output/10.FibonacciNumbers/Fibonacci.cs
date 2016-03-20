using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class Fibonacci
    {
        static void Main()
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int thirdNumber = 0;
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine(firstNumber);
            }
            else
                Console.Write("{0} {1} ", firstNumber, secondNumber);
            for (int i = 2; i < userInput; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                Console.Write("{0} ", thirdNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;

                //The other way to solve the problem with big numbers
                //int firstNumber = 0; //BigInteger
                //int secondNumber = 1; //BigInteger
                //int thirdNumber = 0; //BigInteger
                //int userInput = int.Parse(Console.ReadLine());
                //for (int i = 2; i < userInput; i++)
                //{
                //    thirdNumber = firstNumber + secondNumber;
                //    firstNumber = secondNumber;
                //    secondNumber = thirdNumber;
                //}
                //Console.Write("The {1}th fibonacci number is:{0} ", thirdNumber, userInput);
            }
        }
    }
}
