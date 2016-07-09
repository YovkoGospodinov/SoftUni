namespace _02.OldestFamily
{
    using System;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            int numberOfPersons = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < numberOfPersons; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string personName = input[0];
                int personAge = int.Parse(input[1]);

                var currentPerson = new Person(personName, personAge);

                family.AddMember(currentPerson);
            }

            var oldestPerson = family.GetOldestMember();

            Console.WriteLine("{0} {1}", oldestPerson.Name, oldestPerson.Age);
        }
    }
}
