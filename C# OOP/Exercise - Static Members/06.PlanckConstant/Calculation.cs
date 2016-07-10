namespace _06.PlanckConstant
{
    public class Calculation
    {
        public const double planck = 6.62606896e-34;
        public const double pi = 3.14159;

        public static double Calculate()
        {
            return planck/(2 * pi);
        }
    }
}
