namespace _08.MilitaryElite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            IList<Soldier> soldiers = new List<Soldier>();

            while (input != "End")
            {
                var command = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                
                switch (command[0])
                {
                    case "Private":
                        string id = command[1];
                        string firstName = command[2];
                        string lastName = command[3];
                        double salary = double.Parse(command[4]);
                        var currentPrivate = new Private(id, firstName, lastName, salary);
                        soldiers.Add(currentPrivate);
                        break;
                    case "LeutenantGeneral":
                        id = command[1];
                        firstName = command[2];
                        lastName = command[3];
                        salary = double.Parse(command[4]);
                        var privateNumbers = new List<Private>();
                        for (int i = 5; i < command.Length; i++)
                        {
                            string privateId = command[i];

                            var searchedPrivate = soldiers.SingleOrDefault(s => s.Id == privateId);

                            if (searchedPrivate != null)
                            {
                                privateNumbers.Add(searchedPrivate as Private);
                            }
                        }

                        var currentLeutenant = new LeutenantGeneral(id, firstName, lastName, salary, privateNumbers);

                        soldiers.Add(currentLeutenant);

                        break;
                    case "Engineer":
                        id = command[1];
                        firstName = command[2];
                        lastName = command[3];
                        salary = double.Parse(command[4]);
                        string corps = command[5];
                        IList<Repair> repairs = new List<Repair>();

                        for (int i = 6; i < command.Length - 1; i += 2)
                        {
                            string repairName = command[i];
                            int repairHours = int.Parse(command[i + 1]);
                            var currentRepair = new Repair(repairName, repairHours);
                            repairs.Add(currentRepair);
                        }

                        try
                        {
                            var currentEngineer = new Engineer(id, firstName, lastName, salary, corps, repairs);

                            soldiers.Add(currentEngineer);
                        }
                        catch (ArgumentException)
                        {
                        }

                        break;
                    case "Commando":
                        id = command[1];
                        firstName = command[2];
                        lastName = command[3];
                        salary = double.Parse(command[4]);
                        corps = command[5];
                        IList<Mission> missions = new List<Mission>();

                        for (int i = 6; i < command.Length - 1; i+= 2)
                        {
                            string missionCodeName = command[i];
                            string missionState = command[i + 1];
                            try
                            {
                                var currentMission = new Mission(missionCodeName, missionState);
                                missions.Add(currentMission);
                            }
                            catch (ArgumentException)
                            {
                            }
                        }

                        try
                        {
                            var currentCommando = new Commando(id, firstName, lastName, salary, corps, missions);
                            soldiers.Add(currentCommando);
                        }
                        catch (ArgumentException)
                        {
                        }
                        break;
                    case "Spy":
                        id = command[1];
                        firstName = command[2];
                        lastName = command[3];
                        string codeNumbers = command[4];

                        var currentSpy = new Spy(id, firstName, lastName, codeNumbers);

                        soldiers.Add(currentSpy);
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }
    }
}
