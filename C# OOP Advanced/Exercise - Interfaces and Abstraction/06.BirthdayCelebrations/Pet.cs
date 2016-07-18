namespace _06.BirthdayCelebrations
{
    public class Pet : IBeing
    {
        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name { get; private set; }
        public string BirthDate { get; private set; }
    }
}