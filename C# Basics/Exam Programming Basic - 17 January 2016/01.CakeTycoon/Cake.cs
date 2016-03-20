using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CakeTycoon
{
    class Cake
    {
        static void Main()
        {
            long cakesWanted = long.Parse(Console.ReadLine());
            double floorneededOneCake = double.Parse(Console.ReadLine());
            int floorAvailable = int.Parse(Console.ReadLine());
            int trufflesAvailable = int.Parse(Console.ReadLine());
            decimal trufflePrice = decimal.Parse(Console.ReadLine());

            int cakes = (int)(floorAvailable / floorneededOneCake);
            decimal trufflesCost = trufflesAvailable * trufflePrice;            
            
            if (cakes >= cakesWanted)
            {

                decimal cakePrice = (trufflesCost / cakesWanted) * 1.25m;
                Console.WriteLine("All products available, price of a cake: {0:F2}", cakePrice);
            }
            else
            {
                double totalFloorNeed = cakesWanted * floorneededOneCake;
                Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", cakes, totalFloorNeed - floorAvailable);
            }
        }
    }
}
