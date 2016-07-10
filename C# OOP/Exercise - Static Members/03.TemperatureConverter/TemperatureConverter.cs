namespace _03.TemperatureConverter
{
    public class TemperatureConverter
    {
        private static double coefficient;

        static TemperatureConverter()
        {
            coefficient = 1.8;
        }

        public static string CelsiusToFahrenheit(double temp)
        {
            double result = temp*coefficient + 32;
            return $"{result:F2} Fahrenheit";
        }

        public static string FahrenheitToCelsius(double temp)
        {
            double result = (temp - 32) / coefficient;
            return $"{result:F2} Celsius";
        }
    }
}
