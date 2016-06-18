namespace _05.CalcSequence
{
    using System;
    using System.Collections.Generic;

    public class SequanceCalc
    {
        public static void Main()
        {
            long startNumber = long.Parse(Console.ReadLine());
            Queue<long> numbers = new Queue<long>();
            Queue<long> indexes = new Queue<long>();
            numbers.Enqueue(startNumber);
            //indexes.Enqueue(startNumber);

            for (int i = 0; i < 17; i++)
            {
                long firstNumber = startNumber + 1;
                numbers.Enqueue(firstNumber);
                indexes.Enqueue(firstNumber);
                if (i == 16)
                {
                    break;
                }
                long secondNumber = (2 * startNumber) + 1;
                numbers.Enqueue(secondNumber);
                indexes.Enqueue(secondNumber);
                long thirdNumber = startNumber + 2;
                numbers.Enqueue(thirdNumber);
                indexes.Enqueue(thirdNumber);

                startNumber = indexes.Dequeue();
            }

            Console.WriteLine(string.Join(" ", numbers));

            //for (int i = 0; i < 50; i++)
            //{
            //    Console.Write("{0} ", numbers.Dequeue());
            //}
        }
    }
}
