using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GrandTheftExamo
{
    class Program
    {
        
        static void Main()
        {
            long beers = 0;
            long thievesEscaped = 0;
            long thievesSlapped = 0;
            int escapeAttempts = int.Parse(Console.ReadLine());

            for (int i = 0; i < escapeAttempts; i++)
            {
                int attempteEcapeThieves = int.Parse(Console.ReadLine());
                if (attempteEcapeThieves >= 5)
                {
                    thievesSlapped += 5;
                    thievesEscaped = thievesEscaped + (attempteEcapeThieves - 5);
                }
                else
                {
                    thievesSlapped += attempteEcapeThieves;
                }
                int drinkedBeers = int.Parse(Console.ReadLine());
                beers += drinkedBeers;                             
            }
            Console.WriteLine("{0} thieves slapped.{2}{1} thieves escaped.", thievesSlapped, thievesEscaped, Environment.NewLine);
            long packBeers = beers / 6;
            long bottleBeers = beers % 6;
            Console.WriteLine("{0} packs, {1} bottles.", packBeers, bottleBeers);
        }
    }
}
