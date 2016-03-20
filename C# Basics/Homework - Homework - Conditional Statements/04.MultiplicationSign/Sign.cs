using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class Sign
    {
        static void Main()
        {
            //Easier way to solve the problem with product of three numbers
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            double product = firstNumber * secondNumber * thirdNumber;

            if (product > 0)
            {
                Console.WriteLine("+");
            }
            else if (product < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
// Other way for solving the problem
//using System;
					
//public class Program
//{
//    public static void Main()
//    {
//        double firstNumber = double.Parse(Console.ReadLine());
//        double secondNumber = double.Parse(Console.ReadLine());
//        double thirdNumber = double.Parse(Console.ReadLine());

//        bool isNegativeFirstNumber = (firstNumber < 0);
//        bool isNegativeSecondNumber = (secondNumber < 0);
//        bool isNegativeThirdNumber = (thirdNumber < 0);

//        if (!isNegativeFirstNumber && !isNegativeSecondNumber && !isNegativeThirdNumber)
//        {
//            Console.WriteLine("+");
//        }

//        if (isNegativeFirstNumber)
//        {
//            if (!isNegativeSecondNumber && !isNegativeThirdNumber)
//            {
//                Console.WriteLine("-");
//            }
//            else if (isNegativeSecondNumber && !isNegativeThirdNumber)
//            {
//                Console.WriteLine("+");
//            }
//            else if (isNegativeSecondNumber && isNegativeThirdNumber)
//            {
//                Console.WriteLine("-");
//            }
//            else if (!isNegativeSecondNumber && isNegativeThirdNumber)
//            {
//                Console.WriteLine("+");
//            }
//        }

//        if (isNegativeSecondNumber)
//        {
//            if (!isNegativeFirstNumber && !isNegativeThirdNumber)
//            {
//                Console.WriteLine("-");
//            }
//            else if (isNegativeFirstNumber && !isNegativeThirdNumber)
//            {
//                Console.WriteLine("+");
//            }
//            else if (!isNegativeFirstNumber && isNegativeThirdNumber)
//            {
//                Console.WriteLine("+");
//            }
//            else if (isNegativeFirstNumber && isNegativeThirdNumber)
//            {
//                Console.WriteLine("-");
//            }
//        }

//        if (isNegativeThirdNumber)
//        {
//            if (!isNegativeFirstNumber && !isNegativeSecondNumber)
//            {
//                Console.WriteLine("-");
//            }
//            else if (isNegativeFirstNumber && !isNegativeSecondNumber)
//            {
//                Console.WriteLine("+");
//            }
//            else if (!isNegativeFirstNumber && isNegativeSecondNumber)
//            {
//                Console.WriteLine("+");
//            }
//            else if (isNegativeFirstNumber && isNegativeSecondNumber)
//            {
//                Console.WriteLine("-");
//            }
//        }

//        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
//        {
//            Console.WriteLine("0");
//        }

//    }
//}