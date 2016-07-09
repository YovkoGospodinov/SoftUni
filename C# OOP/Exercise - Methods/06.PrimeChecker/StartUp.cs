namespace _06.PrimeChecker
{
    using System;

    public class StartUp
    {
        public class Startup
        {
            public static void Main()
            {
                int inputNumber = int.Parse(Console.ReadLine());

                var num = new Number(inputNumber, true);

                Console.WriteLine(num.GetNextPrime().number + ", " + num.isPrime.ToString().ToLower());
            }
        }
    }
}
