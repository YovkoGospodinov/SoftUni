namespace _08.PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();

            string command = Console.ReadLine().Trim();
            while (command != "Tournament")
            {
                string[] splittedCommand = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string trainerName = splittedCommand[0];
                string pokemonName = splittedCommand[1];
                string pokemonElement = splittedCommand[2];
                int pokemonHealth = int.Parse(splittedCommand[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                bool isContainTrainer = false;

                foreach (var trainer in trainers)
                {
                    if (trainer.Name == trainerName)
                    {
                        isContainTrainer = true;
                    }
                }

                if (isContainTrainer)
                {
                    foreach (var trainer in trainers)
                    {
                        if (trainer.Name == trainerName)
                        {
                            trainer.AddingPokomon(currentPokemon);
                        }
                    }
                }
                else
                {
                    Trainer currentTrainer = new Trainer(trainerName, new List<Pokemon>());
                    currentTrainer.AddingPokomon(currentPokemon);
                    trainers.Add(currentTrainer);
                }

                command = Console.ReadLine().Trim();
            }

            string input = Console.ReadLine().Trim();
            while (input != "End")
            {
                foreach (var trainer in trainers)
                {
                    int match = 0;

                    foreach (var pokemon in trainer.pokemons)
                    {
                        if (pokemon.Element == input)
                        {
                            match++;
                        }
                    }

                    if (match > 0)
                    {
                        trainer.AddingBadge();
                    }
                    else
                    {
                        foreach (var pokemon in trainer.pokemons)
                        {
                            pokemon.LoseHealth();
                        }

                        trainer.pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }

                input = Console.ReadLine().Trim();
            }

            trainers.OrderByDescending(tr => tr.Badges).ToList().ForEach(tr => Console.WriteLine($"{tr.Name} {tr.Badges} {tr.pokemons.Count}"));
        }
    }
}
