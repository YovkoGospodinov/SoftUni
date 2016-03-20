using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TheBetterMusicProduser
{
    class Program
    {
        static void Main(string[] args)
        {
            int albumsSoldEurope = int.Parse(Console.ReadLine());
            decimal priceAlbumEuro = decimal.Parse(Console.ReadLine());
            int albumsSoldNorthAmerica = int.Parse(Console.ReadLine());
            decimal priceAlbumsDollar = decimal.Parse(Console.ReadLine());
            int albumsSoldSouthAmerica = int.Parse(Console.ReadLine());
            decimal priceAlbumsPesos = decimal.Parse(Console.ReadLine());
            int numberConcerts = int.Parse(Console.ReadLine());
            decimal profitConcertEuro = decimal.Parse(Console.ReadLine());

            decimal moneyEuropeEuro = albumsSoldEurope * priceAlbumEuro;
            decimal moneyEuropeLv = moneyEuropeEuro * 1.94m;
            decimal moneyNorthAmericaDollar = albumsSoldNorthAmerica * priceAlbumsDollar;
            decimal moneyNorthAmericaLv = moneyNorthAmericaDollar * 1.72m;
            decimal moneySouthAmericaPesos = albumsSoldSouthAmerica * priceAlbumsPesos;
            decimal moneySouthAmericaLv = moneySouthAmericaPesos / 332.74m;
            decimal moneyAlbumsLv = moneyEuropeLv + moneyNorthAmericaLv + moneySouthAmericaLv;
            decimal earnedMoneyAlbumsLv = moneyAlbumsLv * 0.65m;
            decimal earnedMoneyAlbumsNetLv = earnedMoneyAlbumsLv * 0.8m;

            decimal moneyTourEuro = numberConcerts * profitConcertEuro;
            decimal moneyTourLv = moneyTourEuro * 1.94m;
            if (moneyTourLv > 100000)
            {
                moneyTourLv *= 0.85m;
            }

            if (earnedMoneyAlbumsNetLv > moneyTourLv)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", earnedMoneyAlbumsNetLv);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", moneyTourLv);
            }
        }
    }
}
