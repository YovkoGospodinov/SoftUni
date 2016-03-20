using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.EmergencyRepairs
{
    class Repairs
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int kits = int.Parse(Console.ReadLine());
            int numberOfAttacks = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfAttacks; i++)
            {
                int attack = int.Parse(Console.ReadLine());
                ulong bitattack = number & (1UL << attack);

                if (bitattack != 0)
                {
                    number ^= bitattack;
                }
            }
            
            for (int i = 0; i < 63; i++)
            {                
                ulong bitattack = number & (3UL << i);
                bitattack = bitattack >> i;

                if (bitattack == 0)
                {
                    if (kits >= 2)
                    {
                        number ^= 3UL << i;
                        kits -= 2;
                    }
                    else if (kits == 1)
                    {
                        number ^= 1UL << i;
                        kits -= 1;
                    }
                    else
                    {
                        break;
                    }
                }                
            }
            Console.WriteLine(number);
        }
    }
}
