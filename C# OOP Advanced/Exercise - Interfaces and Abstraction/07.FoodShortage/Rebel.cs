namespace _07.FoodShortage
{
    public class Rebel : Human
    {
        private string group;

        public Rebel(string name, int age, string group) 
            : base(name, age)
        {
            this.group = group;
        }

        public override void BuyFood()
        {
            base.Food += 5;
        }
    }
}