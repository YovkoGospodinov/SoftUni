using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BeerStock
{
    class Beer
    {
        static void Main()
        {
            int reservedBeers = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            long beers = 0;

            while (input != "Exam Over")
            {
                string[] inputSplited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                long beerDelivered = long.Parse(inputSplited[0]);

                if (inputSplited[1] == "cases")
                {
                    beers += 24 * beerDelivered;
                }
                else if (inputSplited[1] == "sixpacks")
                {
                    beers += 6 * beerDelivered;
                }
                else if (inputSplited[1] == "beers")
                {
                    beers += beerDelivered;
                }
                input = Console.ReadLine();
            }
            
            if (beers > 99)
            {
                beers = beers - (beers / 100);
            }
            
            if (beers >= reservedBeers)
            {
                beers -= reservedBeers;
                long cases = beers / 24;
                beers = beers % 24;
                long sixpacks = beers / 6;
                beers = beers % 6;
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
            }
            else
            {
                beers = reservedBeers - beers;
                long cases = beers / 24;
                beers = beers % 24;
                long sixpacks = beers / 6;
                beers = beers % 6;
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacks, beers);
            }
        }
    }
}
