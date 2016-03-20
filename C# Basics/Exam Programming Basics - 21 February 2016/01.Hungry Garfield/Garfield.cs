using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hungry_Garfield
{
    class Garfield
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal dollarRate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
            decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
            decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

            decimal moneyGarfiledNeed = ((pizzaPrice * pizzaQuantity) + (lasagnaPrice * lasagnaQuantity) + (sandwichPrice * sandwichQuantity)) / dollarRate;
            if (money >= moneyGarfiledNeed)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.", money - moneyGarfiledNeed);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.", moneyGarfiledNeed - money);
            }
        }
    }
}
