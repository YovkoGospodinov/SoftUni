namespace _04.BeerCounter
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                int[] beers = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int boughtBeers = beers[0];
                int drankBeers = beers[1];

                BeerCounter.ByeBeer(boughtBeers);
                BeerCounter.DrinkBeer(drankBeers);

                input = Console.ReadLine();
            }

            Console.WriteLine($"{BeerCounter.BeersInStock} {BeerCounter.BeersDrankCount}");
        }
    }
}
