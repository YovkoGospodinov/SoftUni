namespace _08.Cars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] carDetails = Console.ReadLine().Split(' ');

            long speed = long.Parse(carDetails[0]);
            long fuel = long.Parse(carDetails[1]);
            long fuelEconomy = long.Parse(carDetails[2]);

            var car = new Car(speed, fuel, fuelEconomy);

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split(' ');

                if (command.Length > 1)
                {
                    if (command[0] == "Travel")
                    {
                        string commandTravel = command[0];
                        long kilometersToTravel = long.Parse(command[1]);

                        car.Travel(kilometersToTravel);
                    }
                    else
                    {
                        string commandRefuel = command[0];
                        long litersToRefuel = long.Parse(command[1]);

                        car.Refuel(litersToRefuel);
                    }
                    
                }
                else
                {
                    if (input == "Distance")
                    {
                        Console.WriteLine("Total distance: {0:F1} kilometers", car.TravelDistance);
                    }
                    else if (input == "Time")
                    {
                        Console.WriteLine("Total time: {0} hours and {1} minutes", car.TravelTime / 60, car.TravelTime % 60);
                    }
                    else if (input == "Fuel")
                    {
                        Console.WriteLine("Fuel left: {0:F1} liters", car.Fuel);
                    }
                    
                }

                input = Console.ReadLine();
            }
        }
    }
}
