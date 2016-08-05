namespace _08.PetClinics
{
    public class Pet
    {
        private string name;
        private int age;
        private string kind;

        public Pet(string name, int age, string kind)
        {
            this.name = name;
            this.age = age;
            this.kind = kind;
        }

        public string Name => this.name;
        public int Age => this.age;
        public string Kind => this.kind;
    }
}