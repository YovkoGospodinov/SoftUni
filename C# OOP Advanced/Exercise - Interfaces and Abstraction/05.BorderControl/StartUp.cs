namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<IIdentifable> entity = new List<IIdentifable>();

            while (input != "End")
            {

                string[] details = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (details.Length == 2)
                {
                    string model = details[0];
                    string id = details[1];
                    IIdentifable currentRobot = new Robot(model, id);
                    entity.Add(currentRobot);
                }
                else
                {
                    string name = details[0];
                    int age = int.Parse(details[1]);
                    string id = details[2];
                    IIdentifable currentCitizen = new Citizen(name, age, id);
                    entity.Add(currentCitizen);
                }

                input = Console.ReadLine();
            }

            string detainId = Console.ReadLine();

            entity.Where(x => x.Id.Substring(x.Id.Length - detainId.Length) == detainId).ToList().ForEach(x => Console.WriteLine(x.Id));
        }
    }
}
