using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TorrentPirate
{
    class Torrent
    {
        static void Main()
        {
            decimal movieSize = 1500;
            decimal wifiSpeed = 2;

            decimal megabytesDownload = decimal.Parse(Console.ReadLine());
            decimal oneMoviePrice = decimal.Parse(Console.ReadLine());
            decimal hourlySpendMoney = decimal.Parse(Console.ReadLine());

            decimal downloadTime = (megabytesDownload / wifiSpeed) / 3600m;
            decimal downloadPrice = downloadTime * hourlySpendMoney;
            decimal downloadMovies = megabytesDownload / movieSize;

            decimal cinemaPrice = downloadMovies * oneMoviePrice;
            if (cinemaPrice < downloadPrice)
            {
                Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
            }
            else
            {
                Console.WriteLine("mall -> {0:F2}lv", downloadPrice);
            }
        }
    }
}
