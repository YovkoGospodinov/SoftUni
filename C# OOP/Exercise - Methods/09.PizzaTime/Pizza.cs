namespace _09.PizzaTime
{
    public class Pizza
    {
        private string name;
        private int group;

        public Pizza(string name, int group)
        {
            this.name = name;
            this.group = group;
        }

        public string Name => this.name;
        public int Group => this.group;

        public string GetDescription()
        {
            return $"Name: {this.name} - Group: {this.group}";
        }

        //public SortedDictionary<int, List<string>> SortPizzas(params Pizza[] pizzas)
        //{
        //    var sortedPizzas = new SortedDictionary<int, List<string>>();

        //    foreach (string pizza in pizzas)
        //    {
        //        var letterPosition = pizza.IndexOf(pizza.First(char.IsLetter));
        //        int group = int.Parse(pizza.Substring(0, letterPosition + 1));
        //        string pizzaName = pizza.Substring(letterPosition + 1);

        //        if (!sortedPizzas.ContainsKey(group))
        //        {
        //            sortedPizzas.Add(group, new List<string>(new string[]{ pizzaName}));
        //        }
        //        else
        //        {
        //            sortedPizzas[group].Add(pizzaName);
        //        }
        //    }
        //    return sortedPizzas;
        //}
    }
}
