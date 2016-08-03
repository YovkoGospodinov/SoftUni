namespace _10.ExplicitInterfaces
{
    public class Citizen : IPerson, IResident
    {
        private string name;

        public Citizen(string name)
        {
            this.name = name;
        }

        string IPerson.Name {get;}

        string IResident.Name { get; }

        public string Country { get; }
        public int Age { get; }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.name}";
        }
        
        string IPerson.GetName()
        {
            return $"{this.name}";
        }
    }
}