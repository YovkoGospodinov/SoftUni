namespace _02.VehiclesExtension
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Vehicle> vehicles = new List<Vehicle>();

            string[] carDetails = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double carFuel = double.Parse(carDetails[1]);
            double carConsumption = double.Parse(carDetails[2]);
            double carTankCapacity = double.Parse(carDetails[3]);
            Vehicle car = new Car(carFuel, carConsumption, carTankCapacity);
            vehicles.Add(car);

            input = Console.ReadLine();

            string[] truckDetails = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double truckFuel = double.Parse(truckDetails[1]);
            double truckConsumption = double.Parse(truckDetails[2]);
            double truckTankCapacity = double.Parse(truckDetails[3]);
            Vehicle truck = new Truck(truckFuel, truckConsumption, truckTankCapacity);
            vehicles.Add(truck);

            input = Console.ReadLine();

            string[] busDetails = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double busFuel = double.Parse(busDetails[1]);
            double busConsumption = double.Parse(busDetails[2]);
            double busTankCapacity = double.Parse(busDetails[3]);
            Bus bus = new Bus(busFuel, busConsumption, busTankCapacity);
            //vehicles.Add(bus);

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
                    else if (vehicle == "Truck")
                    {
                        truck.Drive(number);
                    }
                    else
                    {
                        bus.Drive(number);
                    }
                }
                else if(command == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.Refuel(number);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(number);
                    }
                    else
                    {
                        bus.Refuel(number);
                    }
                }
                else
                {
                    bus.DriveEmpty(number);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
