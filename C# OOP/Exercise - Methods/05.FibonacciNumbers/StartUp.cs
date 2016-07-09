namespace _05.FibonacciNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int startPosition = int.Parse(Console.ReadLine());
            int endPosition = int.Parse(Console.ReadLine());

            var sequence = new Fibonacci();

            var result = sequence.GetNumbersInRange(startPosition, endPosition);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
