namespace _05.PizzaCalories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> topping;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.topping = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }

        public int Topping
        {
            get { return this.topping.Count; }
            set
            {
                if (this.topping.Count > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
            }

        }

        public double Calories()
        {
            double doughCalories = this.dough.Calories();
            double toppingCalories = this.topping.Select(t => t.Calories()).Sum();

            return doughCalories + toppingCalories;
        }

        public void AddTopping(Topping topping)
        {
            this.topping.Add(topping);
        }
    }
}
