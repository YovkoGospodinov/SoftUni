namespace _05.PizzaCalories
{
    using System;

    public class Topping
    {
        private string type;
        private int weight;
        private double caloriesPerGram;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
            this.CaloriesPerGram = 2;
        }

        private int Weight
        {
            get { return this.weight; }

            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range[1..50].");
                }
                this.weight = value;
            }
        }

        private string Type
        {
            get { return this.type; }

            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                double toppingTypeIndex = 1.2;

                if (this.Type.ToLower() == "veggies")
                {
                    toppingTypeIndex = 0.8;
                }
                else if (this.Type.ToLower() == "cheese")
                {
                    toppingTypeIndex = 1.1;
                }
                else if (this.Type.ToLower() == "sauce")
                {
                    toppingTypeIndex = 0.9;
                }

                return caloriesPerGram * toppingTypeIndex;
            }

            private set { this.caloriesPerGram = value; }
        }

        public double Calories()
        {
            return this.Weight * this.CaloriesPerGram;
        }
    }
}
