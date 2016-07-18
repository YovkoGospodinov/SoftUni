namespace _07.FoodShortage
{
    public abstract class Human : IBuyer
    {
        private string name;
        private int age;
        
        protected Human(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
        }

        public string Name { get; protected set; }

        public int Age { get; protected set; }
        public int Food { get; protected set; }

        public abstract void BuyFood();
    }
}