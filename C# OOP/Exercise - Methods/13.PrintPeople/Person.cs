namespace _13.PrintPeople
{
    public class Person
    {
        private string name;
        private int age;
        private string occupation;

        public Person(string name, int age, string occupation)
        {
            this.name = name;
            this.age = age;
            this.occupation = occupation;
        }

        public string Name => this.name;
        public int Age => this.age;
        public string Occupation => this.occupation;
        
    }
}
