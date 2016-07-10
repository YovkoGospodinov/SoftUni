namespace _05.AnimalClinic
{
    using System.Collections.Generic;

    public class AnimalClinic
    {
        private static int patientId;
        private static int healedAnimalsCount;
        private static int rehabilitedAnimalsCount;
        private static List<Animal> overralPatients;
        private static List<Animal> healedAnimals;
        private static List<Animal> rehabilitatedAnimals;

        static AnimalClinic()
        {
            patientId = 0;
            healedAnimalsCount = 0;
            rehabilitedAnimalsCount = 0;
            overralPatients = new List<Animal>();
            healedAnimals = new List<Animal>();
            rehabilitatedAnimals = new List<Animal>();
        }

        public static int HealedAnimalsCount => healedAnimalsCount;
        public static int RehabilitedAnimalsCount => rehabilitedAnimalsCount;
        public static int PatientId => patientId;
        public static List<Animal> OverralPatients => overralPatients;
        public static List<Animal> HealedAnimals => healedAnimals;
        public static List<Animal> RehabilitatedAnimals => rehabilitatedAnimals;

        public static void AddHealedAnimal(Animal animal)
        {
            overralPatients.Add(animal);
            healedAnimals.Add(animal);
            healedAnimalsCount++;
            patientId++;
        }

        public static void AddRehabilitatedAnimal(Animal animal)
        {
            overralPatients.Add(animal);
            rehabilitatedAnimals.Add(animal);
            rehabilitedAnimalsCount++;
            patientId++;
        }
    }
}

