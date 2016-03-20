using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.TorrentPirate
{
    class Torrent
    {
        static void Main()
        {
            int filmSize = 1500;
            int downloadSpeed = 2;
            int downloadData = int.Parse(Console.ReadLine());
            int priceOneMovie = int.Parse(Console.ReadLine());
            int moneyPerHour = int.Parse(Console.ReadLine());

            double downloadTime = (double)downloadData / downloadSpeed / 60 / 60;
            double priceDownload = downloadTime * moneyPerHour;

            double numbersMovies = (double)downloadData / filmSize;

            double cinemaPrice = numbersMovies * priceOneMovie;

            if (priceDownload > cinemaPrice)
            {
                Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
            }
            else
            {
                Console.WriteLine("mall -> {0:F2}lv", priceDownload);
            }
        }
    }
}
