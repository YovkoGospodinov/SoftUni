namespace _05.SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string model = input[0];
                double fuel = double.Parse(input[1]);
                double cost = double.Parse(input[2]);
                var newCar = new Car(model, fuel, cost);

                cars.Add(newCar);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splittedCommand = command.Split(' ');

                string car = splittedCommand[1];
                int kilometers = int.Parse(splittedCommand[2]);

                var carToDrive = cars.First(c => c.Model == car);

                try
                {
                    carToDrive.Drive(kilometers);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //foreach (var item in cars)
                //{
                //    if (car == item.Model)
                //    {
                //        try
                //        {
                //            item.Drive(kilometers);
                //        }
                //        catch (ArgumentException ex)
                //        {
                //            Console.WriteLine(ex.Message);
                //        }
                //        break;
                //    }
                //}

                command = Console.ReadLine();
            }

            cars.ForEach(car => Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}"));
        }
    }
}
