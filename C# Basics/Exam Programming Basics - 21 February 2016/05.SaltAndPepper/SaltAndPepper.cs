using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SaltAndPepper
{
    class SaltAndPepper
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] spittedCommand = command.Split(' ');
                int position = int.Parse(spittedCommand[1]);

                if (spittedCommand[0] == "salt")
                {
                    for (int i = 0; i < 64; i += position)
                    {
                        ulong bitAtPosition = number & (1UL << i);
                        if (bitAtPosition == 1UL << i)
                        {
                            number ^= bitAtPosition;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 64; i += position)
                    {
                        ulong bitAtPosition = number & (1UL << i);
                        if (bitAtPosition == 0)
                        {
                            number ^= 1UL << i;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(number);
        }
    }
}
