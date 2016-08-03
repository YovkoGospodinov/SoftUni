namespace _10.ExplicitInterfaces
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] citizenDetails = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            while (citizenDetails[0] != "End")
            {
                string name = citizenDetails[0];

                Citizen citizen = new Citizen(name);

                IPerson pCitizen = (IPerson) citizen;
                IResident rCitizen = (IResident) citizen;
 
                Console.WriteLine(pCitizen.GetName());
                Console.WriteLine(rCitizen.GetName());

                citizenDetails = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
