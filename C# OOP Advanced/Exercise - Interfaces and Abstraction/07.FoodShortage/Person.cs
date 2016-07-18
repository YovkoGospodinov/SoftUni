namespace _07.FoodShortage
{
    public class Person : Human
    {
        private string id;
        private string birthDate;

        public Person(string name, int age, string id, string birthDate) 
            : base(name, age)
        {
            this.id = id;
            this.birthDate = birthDate;
        }

        public override void BuyFood()
        {
            base.Food += 10;
        }
    }
}