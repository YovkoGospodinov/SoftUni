using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LightTheTorches
{
    class Torches
    {
        static void Main()
        {
            int roomsTotal = int.Parse(Console.ReadLine());
            string characters = Console.ReadLine();
            char[] symbol = characters.ToCharArray();
            int index = 0;
            int currentPosition = roomsTotal / 2;
            int lightRooms = 0;
            int darkRooms = 0;

            char[] roomsType = new char[roomsTotal];
            for (int i = 0; i < symbol.Length; i++)
            {
                
                if (index >= characters.Length - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                    roomsType[i] = symbol[index];
                }
                
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                int lastPosition = currentPosition;
                string[] splitedCommand = command.Split(' ');
                int passedRooms = int.Parse(splitedCommand[1]);
                if (splitedCommand[0] == "LEFT")
                {
                    if ((currentPosition - passedRooms - 1) >= 0)
                    {
                        currentPosition -= (passedRooms - 1);
                        
                    }
                    else if ((currentPosition - passedRooms - 1) < 0)
                    {
                        currentPosition = 0;
                    }
                    if (currentPosition != lastPosition)
                    {
                        if (roomsType[currentPosition] == 'L')
                        {
                            roomsType[currentPosition] = 'D';
                        }
                        else if (roomsType[currentPosition] == 'D')
                        {
                            roomsType[currentPosition] = 'L';
                        }
                    }


                }
                else if (splitedCommand[0] == "RIGHT")
                {
                    if ((currentPosition + passedRooms + 1) <= roomsTotal)
                    {
                        currentPosition += (passedRooms + 1);
                        
                    }
                    else if ((currentPosition + passedRooms + 1) > roomsTotal)
                    {
                        currentPosition = roomsTotal;
                    }
                    if (currentPosition != lastPosition)
                    {
                        if (roomsType[currentPosition] == 'L')
                        {
                            roomsType[currentPosition] = 'D';
                        }
                        else if (roomsType[currentPosition] == 'D')
                        {
                            roomsType[currentPosition] = 'L';
                        }
                    }
                }

                command = Console.ReadLine();
            }
            for (int i = 0; i < roomsTotal; i++)
            {
                if (roomsType[i] == 'L')
                {
                    lightRooms++;
                }
                else if (roomsType[i] == 'D')
                {
                    darkRooms++;
                }
            }
            Console.WriteLine(darkRooms * 68);
        }
    }
}
