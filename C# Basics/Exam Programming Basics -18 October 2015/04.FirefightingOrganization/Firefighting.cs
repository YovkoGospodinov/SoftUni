using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FirefightingOrganization
{
    class Firefighting
    {
        static void Main()
        {
            int firefighters = int.Parse(Console.ReadLine());
            string inputCommand = Console.ReadLine();
            int kidstotal = 0;
            int adultstotal = 0;
            int seniorstotal = 0; 
            while (inputCommand != "rain")
            {
                int kids = 0;
                int adults = 0;
                int seniors = 0;

                for (int i = 0; i < inputCommand.Length; i++)
                {
                    if (inputCommand[i] == 'K' && kids < firefighters)
                    {
                        kidstotal++;
                        kids++;
                    }
                }
                for (int i = 0; i < inputCommand.Length; i++)
                {
                    if (inputCommand[i] == 'A' && (kids + adults) < firefighters)
                    {
                        adultstotal++;
                        adults++;
                    }
                }
                for (int i = 0; i < inputCommand.Length; i++)
                {
                    if (inputCommand[i] == 'S' && (kids + adults + seniors) < firefighters)
                    {
                        seniorstotal++;
                        seniors++;
                    }
                }

                inputCommand = Console.ReadLine();
            }
            Console.WriteLine("Kids: {0}", kidstotal);
            Console.WriteLine("Adults: {0}", adultstotal);
            Console.WriteLine("Seniors: {0}", seniorstotal);
        }
    }
}
