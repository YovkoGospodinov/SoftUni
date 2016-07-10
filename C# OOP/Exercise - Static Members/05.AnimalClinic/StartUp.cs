namespace _05.AnimalClinic
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] patientDetails = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string patientName = patientDetails[0];
                string patientBreed = patientDetails[1];
                string patientStatus = patientDetails[2];

                var currentPatient = new Animal(patientName, patientBreed);

                if (patientStatus == "heal")
                {
                    AnimalClinic.AddHealedAnimal(currentPatient);
                    Console.WriteLine($"Patient {AnimalClinic.PatientId}: [{patientName} ({patientBreed})] has been healed!");
                }
                else
                {
                    AnimalClinic.AddRehabilitatedAnimal(currentPatient);
                    Console.WriteLine($"Patient {AnimalClinic.PatientId}: [{patientName} ({patientBreed})] has been rehabilitated!");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total healed animals: {AnimalClinic.HealedAnimalsCount}");
            Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.RehabilitedAnimalsCount}");

            string command = Console.ReadLine();

            if (command == "heal")
            {
                AnimalClinic.HealedAnimals.ToList().ForEach(a => Console.WriteLine($"{a.Name} {a.Breed}"));
            }
            else
            {
                AnimalClinic.RehabilitatedAnimals.ToList().ForEach(a => Console.WriteLine($"{a.Name} {a.Breed}"));
            }
        }
    }
}
