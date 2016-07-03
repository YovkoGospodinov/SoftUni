namespace _07.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            //var car = new Car("BMW", new Engine("OPC", 230), null, "White");


            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] inputEngines = Console.ReadLine().Trim().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

                string engineModel = inputEngines[0];
                int enginePower = int.Parse(inputEngines[1]);
                int engineDispacement;
                string engineEfficiency;

                if (inputEngines.Length == 2)
                {
                    var currentEngine = new Engine(engineModel, enginePower);
                    engines.Add(currentEngine);
                }

                else if (inputEngines.Length == 3)
                {
                    if (inputEngines[2].All(char.IsDigit))
                    {
                        engineDispacement = int.Parse(inputEngines[2]);
                        var currentEngine = new Engine(engineModel, enginePower, engineDispacement);
                        engines.Add(currentEngine);
                    }
                    else
                    {
                        engineEfficiency = inputEngines[2];
                        var currentEngine = new Engine(engineModel, enginePower, engineEfficiency);
                        engines.Add(currentEngine);
                    }
                }
                else if (inputEngines.Length == 4)
                {
                    engineDispacement = int.Parse(inputEngines[2]);
                    engineEfficiency = inputEngines[3];
                    var currentEngine = new Engine(engineModel, enginePower, engineDispacement, engineEfficiency);
                    engines.Add(currentEngine);
                }


            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputCars = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string carModel = inputCars[0];
                Engine carEngine = engines.First(eng => eng.Model == inputCars[1]);

                if (inputCars.Length == 2)
                {
                    var currentCar = new Car(carModel, carEngine);
                    cars.Add(currentCar);
                }
                else if (inputCars.Length == 3)
                {
                    if (inputCars[2].All(char.IsDigit))
                    {
                        int carWeight = int.Parse(inputCars[2]);
                        var currentCar = new Car(carModel, carEngine, carWeight);
                        cars.Add(currentCar);
                    }
                    else
                    {
                        string carColor = inputCars[2];
                        var currentCar = new Car(carModel, carEngine, carColor);
                        cars.Add(currentCar);
                    }
                }
                else if (inputCars.Length == 4)
                {
                    int carWeight = int.Parse(inputCars[2]);
                    string carColor = inputCars[3];
                    var currentCar = new Car(carModel, carEngine, carWeight, carColor);
                    cars.Add(currentCar);
                }
            }

            foreach (var car in cars)
            {
                Console.Write(car.ToString());
            }
        }
    }
}
