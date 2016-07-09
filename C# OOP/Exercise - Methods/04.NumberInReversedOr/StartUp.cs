namespace _04.NumberInReversedOr
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());

            var number = new DecimalNumber(input);

            var result = number.ReverseDigits();

            Console.WriteLine(result);
        }
    }
}
