namespace _09.PizzaTime
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            var pizzas = new Pizza[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int letterPosition = input[i].IndexOf(input[i].First(char.IsLetter));
                int group = int.Parse(input[i].Substring(0, letterPosition));
                string pizzaName = input[i].Substring(letterPosition);

                var currentPizza = new Pizza(pizzaName, group);
                pizzas[i] = currentPizza;
            }
            //{
            //    var letterPosition = pizza.IndexOf(pizza.First(char.IsLetter));
            //    int group = int.Parse(pizza.Substring(0, letterPosition + 1));
            //    string pizzaName = pizza.Substring(letterPosition + 1);

            //    var currentPizza = new Pizza(pizzaName, group);
            //    pizzas.Add(currentPizza);
            //}

            var result = SortPizzas(pizzas);

            foreach (var item in result)
            {
                Console.WriteLine("{0} - {1}", item.Key, string.Join(", ", item.Value));
            }
        }
        public static SortedDictionary<int, List<string>> SortPizzas(params Pizza[] pizzas)
        {
            var sortedPizzas = new SortedDictionary<int, List<string>>();

            foreach (Pizza pizza in pizzas)
            {
                int group = pizza.Group;
                string pizzaName = pizza.Name;

                if (!sortedPizzas.ContainsKey(group))
                {
                    sortedPizzas.Add(group, new List<string>(new string[] { pizzaName }));
                }
                else
                {
                    sortedPizzas[group].Add(pizzaName);
                }
            }
            return sortedPizzas;
        }
    }
}
