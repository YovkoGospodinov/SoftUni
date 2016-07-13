namespace _01.Vehicles
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Vehicle> vehicles = new List<Vehicle>();

            string[] carDetails = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            double carFuel = double.Parse(carDetails[1]);
            double carConsumption = double.Parse(carDetails[2]);
            Vehicle car = new Car(carFuel, carConsumption);
            vehicles.Add(car);
            input = Console.ReadLine();

            string[] truckDetails = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double truckFuel = double.Parse(truckDetails[1]);
            double truckConsumption = double.Parse(truckDetails[2]);
            Vehicle truck = new Truck(truckFuel, truckConsumption);
            vehicles.Add(truck);

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                input = Console.ReadLine();
                string[] splittedInput = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = splittedInput[0];
                string vehicle = splittedInput[1];
                double number = double.Parse(splittedInput[2]);

                if (command == "Drive")
                {
                    if (vehicle == "Car")
                    {
                        car.Drive(number);
                    }
                    else
                    {
                        truck.Drive(number);
                    }
                }
                else
                {
                    if (vehicle == "Car")
                    {
                        car.Refuel(number);
                    }
                    else
                    {
                        truck.Refuel(number);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
