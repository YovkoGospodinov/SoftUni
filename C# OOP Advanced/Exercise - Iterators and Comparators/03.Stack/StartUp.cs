namespace _03.Stack
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var myCustumStack = new CustumStack<int>();

            string[] input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                if (input[0] == "Push")
                {
                    List<int> numbers = new List<int>();

                    for (int i = 1; i < input.Length; i++)
                    {
                        int currentNumber = int.Parse(input[i].Substring(0, 1));
                        numbers.Add(currentNumber);
                    }

                    myCustumStack.PushElement(numbers);
                }
                else if (input[0] == "Pop")
                {
                    myCustumStack.PopElement();
                }

                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var number in myCustumStack)
            {
                Console.WriteLine(number);
            }

            foreach (var number in myCustumStack)
            {
                Console.WriteLine(number);
            }
        }
    }
}
