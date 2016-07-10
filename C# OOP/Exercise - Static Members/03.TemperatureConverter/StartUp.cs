namespace _03.TemperatureConverter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string output = String.Empty;

            while (input != "End")
            {
                string[] splittedInput = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                int degrees = int.Parse(splittedInput[0]);
                string system = splittedInput[1];

                if (system == "Celsius")
                {
                    output = TemperatureConverter.CelsiusToFahrenheit(degrees);
                }
                else
                {
                    output = TemperatureConverter.FahrenheitToCelsius(degrees);
                }

                Console.WriteLine(output);

                input = Console.ReadLine();
            }
        }
    }
}
