namespace _05.PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] pizzaDetails = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string pizzaName = pizzaDetails[1];
            int numberOfToppings = int.Parse(pizzaDetails[2]);

            if (numberOfToppings > 10)
            {
                Console.WriteLine("Number of toppings should be in range [0..10].");
                Environment.Exit(1);
            }

            input = Console.ReadLine();
            string[] doughDetails = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string flour = doughDetails[1];
            string bakeType = doughDetails[2];
            int doughWeight = int.Parse(doughDetails[3]);

            try
            {
                var pizza = new Pizza(pizzaName, new Dough(flour, bakeType, doughWeight));

                input = Console.ReadLine();

                while (input != "END")
                {
                    string[] toppingDetail = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                    string toppingType = toppingDetail[1];
                    int toppingWeight = int.Parse(toppingDetail[2]);

                    try
                    {
                        var currentTopping = new Topping(toppingType, toppingWeight);
                        pizza.AddTopping(currentTopping);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Environment.Exit(1);
                    }

                    input = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.Calories():F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
