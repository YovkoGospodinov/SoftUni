using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpressTheGirlfriend
{
    class ImpressGirlfriend
    {
        static void Main()
        {
            decimal priceRubbles = decimal.Parse(Console.ReadLine());
            decimal priceDollars = decimal.Parse(Console.ReadLine());
            decimal priceEuros = decimal.Parse(Console.ReadLine());
            decimal priceBLevas = decimal.Parse(Console.ReadLine());
            decimal priceMLevas = decimal.Parse(Console.ReadLine());

            decimal rBgn = priceRubbles * 3.5m / 100;
            decimal dBgn = priceDollars * 1.5m;
            decimal eBGN = priceEuros * 1.95m;
            decimal bBGN = priceBLevas / 2m;
            

            if ((rBgn > dBgn) && (rBgn > eBGN) && (rBgn > bBGN) && (rBgn > priceMLevas))
            {
                Console.WriteLine("{0:F2}", Math.Ceiling(rBgn));
            }
            else if ((dBgn > rBgn) && (dBgn > eBGN) && (dBgn > bBGN) && (dBgn > priceMLevas))
            {
                Console.WriteLine("{0:F2}", Math.Ceiling(dBgn));
            }
            else if ((eBGN > rBgn) && (eBGN > dBgn) && (eBGN > bBGN) && (eBGN > priceMLevas))
            {
                Console.WriteLine("{0:F2}", Math.Ceiling(eBGN));
            }
            else if ((bBGN > rBgn) && (bBGN > dBgn) && (bBGN > eBGN) && (bBGN > priceMLevas))
            {
                Console.WriteLine("{0:F2}", Math.Ceiling(bBGN));
            }
            else
            {
                Console.WriteLine("{0:F2}", Math.Ceiling(priceMLevas));
            }
        }
    }
}
