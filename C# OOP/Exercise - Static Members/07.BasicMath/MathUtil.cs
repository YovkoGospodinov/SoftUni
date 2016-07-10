namespace _07.BasicMath
{
    public class MathUtil
    {
        public static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }

        public static double Subtract(double first, double second)
        {
            double result = first - second;
            return result;
        }

        public static double Multiply(double first, double second)
        {
            double result = first * second;
            return result;
        }

        public static double Divide(double first, double second)
        {
            double result = first / second;
            return result;
        }

        public static double Percentage(double first, double second)
        {
            double result = first * (second / 100);
            return result;
        }
    }
}
