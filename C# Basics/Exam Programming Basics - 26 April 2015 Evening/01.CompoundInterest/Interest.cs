using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CompoundInterest
{
    class Interest
    {
        static void Main()
        {
            decimal tvPrice = decimal.Parse(Console.ReadLine());
            int loanTerm = int.Parse(Console.ReadLine());
            double yearlyInterest = double.Parse(Console.ReadLine());
            double friendInterest = double.Parse(Console.ReadLine());

            decimal fvBank = tvPrice * (decimal)(Math.Pow(1 + yearlyInterest, loanTerm));
            decimal fvFriend = tvPrice * (decimal)(1 + friendInterest);

            if (fvFriend <= fvBank)
            {
                Console.WriteLine("{0:F2} Friend", fvFriend);
            }
            else
            {
                Console.WriteLine("{0:F2} Bank", fvBank);
            }
        }
    }
}
