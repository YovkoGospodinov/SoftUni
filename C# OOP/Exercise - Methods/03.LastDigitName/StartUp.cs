namespace _03.LastDigitName
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            var newNumber = new Number(input);

            var result = newNumber.LastDigitAsWord();

            Console.WriteLine(result);
        }
    }
}
