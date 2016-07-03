using System.Collections.Generic;

namespace _08.PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        public List<Pokemon> pokemons;
        
        public Trainer(string name, List<Pokemon> pokemons, int badges = 0)
        {
            this.Name = name;
            this.badges = badges;
            this.pokemons = pokemons;
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

        public int Badges
        {
            get
            {
                return this.badges;
            }
        }

        public void AddingPokomon(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }

        public void RemovePokomon(Pokemon pokemon)
        {
            this.pokemons.Remove(pokemon);
        }

        public void AddingBadge()
        {
            this.badges++;
        }


    }
}
