namespace _03.DependencyInversion
{
    using System;
    using _03DependencyInversion;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var calculator = new PrimitiveCalculator();

            while (input != "End")
            {
                string[] inputArgs = input.Split();
                if (inputArgs[0] == "mode")
                {
                    switch (inputArgs[1][0])
                    {
                        case '/':
                            var devision = new DevisionStrategy();
                            calculator.ChangeStrategy(devision);
                            break;
                        case '*':
                            var multyplication = new MultyplicationStrategy();
                            calculator.ChangeStrategy(multyplication);
                            break;
                        case '-':
                            var substraction = new SubstractionStrategy();
                            calculator.ChangeStrategy(substraction);
                            break;
                        case '+':
                            var addition = new AdditionStrategy();
                            calculator.ChangeStrategy(addition);
                            break;
                    }
                }
                else
                {
                    int firstOperand = int.Parse(inputArgs[0]);
                    int secondOperand = int.Parse(inputArgs[1]);

                    int result = calculator.PerformCalculation(firstOperand, secondOperand);

                    Console.WriteLine(result);
                }

                input = Console.ReadLine();
            }
        }
    }
}
