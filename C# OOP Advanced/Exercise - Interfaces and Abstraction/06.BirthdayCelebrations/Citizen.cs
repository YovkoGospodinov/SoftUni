namespace _06.BirthdayCelebrations
{
    public class Citizen : IBeing, IIdentifable
    {
        private int age;

        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Age = age;
            this.Name = name;
            this.BirthDate = birthDate;
            this.Id = id;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string BirthDate { get; private set; }
        public string Id { get; private set; }
    }
}