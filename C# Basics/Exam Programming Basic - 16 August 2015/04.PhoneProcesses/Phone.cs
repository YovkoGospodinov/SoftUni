using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhoneProcesses
{
    class Phone
    {
        static void Main()
        {
            string batteryStartInput = Console.ReadLine();
            int batteryStart = int.Parse(batteryStartInput.Substring(0, batteryStartInput.Length - 1));
            if (batteryStart >= 15)
            {
                string[] inputApps = Console.ReadLine().Split('_');
                int batteryCons = 0;
                int appsNotExecuted = -1;
                while (inputApps[0] != "END")
                {

                    batteryCons += int.Parse(inputApps[1].Substring(0, inputApps[1].Length - 1));
                    batteryStart -= batteryCons;
                    
                    if (batteryStart <= 15)
                    {
                        while (inputApps[0] != "END")
                        {
                            appsNotExecuted++;
                            inputApps = Console.ReadLine().Split('_');
                            inputApps[0] = inputApps[0].ToUpper();
                        }
                        break;
                    }
                    inputApps = Console.ReadLine().Split('_');
                    inputApps[0] = inputApps[0].ToUpper();
                    batteryCons = 0;
                    
                }
                if (batteryStart > 15)
                {
                    Console.WriteLine("Successful complete -> {0}%", batteryStart);
                }
                else if (batteryStart <= 15 && batteryStart > 0)
                {
                    Console.WriteLine("Connect charger -> {0}%", batteryStart);
                    Console.WriteLine("Programs left -> {0}", appsNotExecuted);
                }
                else if (batteryStart <= 0)
                {
                    Console.WriteLine("Phone Off");
                }
            }
            else if (batteryStart > 0 && batteryStart <= 15)
            {
                Console.WriteLine("Connect charger -> {0}%", batteryStart);
                Console.WriteLine("Programs left -> {0}", 1);
            }
            else if (batteryStart <= 0)
            {
                Console.WriteLine("Phone Off");
            }
        }
    }
}
