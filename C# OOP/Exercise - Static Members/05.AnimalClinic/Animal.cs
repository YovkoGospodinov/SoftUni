namespace _05.AnimalClinic
{
    public class Animal
    {
        private string name;
        private string breed;

        public Animal(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public string Name => this.name;
        public string Breed => this.breed;
    }
}
