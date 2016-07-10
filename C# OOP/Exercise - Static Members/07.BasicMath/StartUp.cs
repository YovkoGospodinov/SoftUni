namespace _07.BasicMath
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splittedInput = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string operation = splittedInput[0];
                double firstNumber = double.Parse(splittedInput[1]);
                double secondNumber = double.Parse(splittedInput[2]);

                switch (operation)
                {
                    case "Sum":
                        Console.WriteLine("{0:F2}", MathUtil.Sum(firstNumber, secondNumber));
                        break;
                    case "Subtract":
                        Console.WriteLine("{0:F2}", MathUtil.Subtract(firstNumber, secondNumber));
                        break;
                    case "Multiply":
                        Console.WriteLine("{0:F2}", MathUtil.Multiply(firstNumber, secondNumber));
                        break;
                    case "Divide":
                        Console.WriteLine("{0:F2}", MathUtil.Divide(firstNumber, secondNumber));
                        break;
                    case "Percentage":
                        Console.WriteLine("{0:F2}", MathUtil.Percentage(firstNumber, secondNumber));
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
