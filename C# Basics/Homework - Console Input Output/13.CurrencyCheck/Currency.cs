using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CurrencyCheck
{
    class Currency
    {
        static void Main()
        {
            decimal rubles = decimal.Parse(Console.ReadLine());
            decimal russianSite = rubles * 0.035m;
            decimal dollars = decimal.Parse(Console.ReadLine());
            decimal usaSite = dollars * 1.5m;
            decimal euro = decimal.Parse(Console.ReadLine());
            decimal euroSite = euro * 1.95m;
            decimal levaSpecialDeal = decimal.Parse(Console.ReadLine()) / 2;
            decimal levaNormal = decimal.Parse(Console.ReadLine());

            if (russianSite < usaSite && russianSite < euroSite && russianSite < levaSpecialDeal && russianSite < levaNormal)
            {
                Console.WriteLine("{0:F2}", russianSite);
            }
            else if (usaSite < russianSite && usaSite < euroSite && usaSite < levaSpecialDeal && usaSite < levaNormal)
            {
                Console.WriteLine("{0:F2}", usaSite);
            }
            else if (euroSite < russianSite && euroSite < usaSite && euroSite < levaSpecialDeal && euroSite < levaNormal)
            {
                Console.WriteLine("{0:F2}", euroSite);
            }
            else if (levaSpecialDeal < russianSite && levaSpecialDeal < usaSite && levaSpecialDeal < euroSite && levaSpecialDeal < levaNormal)
            {
                Console.WriteLine("{0:F2}", levaSpecialDeal);
            }
            else if (levaNormal < russianSite && levaNormal < usaSite && levaNormal < euroSite && levaNormal < levaSpecialDeal)
            {
                Console.WriteLine("{0:F2}", levaNormal);
            }
        }
    }
}
