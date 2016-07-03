namespace _06.RawData
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
                string[] input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);

                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);

                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);

                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                var tire1 = new Tire(tire1Pressure, tire1Age);
                var tire2 = new Tire(tire2Pressure, tire2Age);
                var tire3 = new Tire(tire3Pressure, tire3Age);
                var tire4 = new Tire(tire4Pressure, tire4Age);

                var currentTires = new List<Tire> { tire1, tire2, tire3, tire4 };
                var currentEngine = new Engine(engineSpeed, enginePower);
                var currentCargo = new Cargo(cargoWeight, cargoType);

                var car = new Car(model, currentEngine, currentCargo, currentTires);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).ToList().ForEach(c => Console.WriteLine(c.Model));
            }
            else if (command == "flamable")
            {
                cars.Where(c => c.Cargo.Type == "flamable").Where(c => c.Engine.Power > 250).ToList().ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
