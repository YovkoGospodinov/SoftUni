namespace _08.PokemonTrainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public string Element
        {
            get
            {
                return this.element;
            }

            private set
            {
                this.element = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }

            private set
            {
                this.health = value;
            }
        }

        public void LoseHealth()
        {
            this.Health -= 10;
        }
    }
}
