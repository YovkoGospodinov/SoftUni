namespace _04.BeerCounter
{
    public class BeerCounter
    {
        public static int beersInStock;
        public static int beersDrankCount;

        static BeerCounter()
        {
            beersInStock = 0;
            beersDrankCount = 0;
        }

        public static int BeersInStock => beersInStock;
        public static int BeersDrankCount => beersDrankCount;

        public static void ByeBeer(int beer)
        {
            beersInStock += beer;
        }

        public static void DrinkBeer(int beer)
        {
            beersDrankCount += beer;
            beersInStock -= beer;
        }
    }
}
