namespace _08.MilitaryElite
{
    using _08.MilitaryElite.Contracts;

    public abstract class Soldier : ISoldier
    {
        private string id;
        private string firstName;
        private string lastName;

        protected Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}