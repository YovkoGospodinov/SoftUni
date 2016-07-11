namespace _05.PizzaCalories
{
    using System;

    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        private double caloriesPerGram;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.CaloriesPerGram = 2;
        }

        private string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            get { return this.bakingTechnique; }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade ")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        private int Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 200) 
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                double flourTypeIndex = 1.0;
                double bakaingTypeIndex = 1.0;

                if (this.FlourType.ToLower() == "white")
                {
                    flourTypeIndex = 1.5;
                }
                
                if (this.BakingTechnique.ToLower() == "crispy")
                {
                    bakaingTypeIndex = 0.9;
                }
                else if (this.bakingTechnique.ToLower() == "chewy")
                {
                    bakaingTypeIndex = 1.1;
                }
                
                return this.caloriesPerGram * flourTypeIndex * bakaingTypeIndex;
            }
            private set { this.caloriesPerGram = value; }
        }

        public double Calories()
        {
            return this.Weight * this.CaloriesPerGram;
        }
    }
}
