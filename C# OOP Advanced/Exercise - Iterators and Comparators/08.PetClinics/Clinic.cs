using System.Collections;
using System.Collections.Generic;

namespace _08.PetClinics
{
    using System;

    public class Clinic : IEnumerable<Room>
    {
        private string name;
        private Room[] rooms;
        private int numberOfRooms;

        public Clinic(string name, int numberOfRooms)
        {
            this.name = name;
            this.NumberOfRooms = numberOfRooms;
            this.rooms = new Room[this.NumberOfRooms];
        }

        public string Name => this.name;
        public Room[] Rooms => this.rooms;

        public int NumberOfRooms
        {
            get { return this.numberOfRooms; }
            private set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException();
                }

                this.numberOfRooms = value;
            }
        }

        public void AddPet(Pet pet)
        {
            int roomIndex = 0;

            foreach (var room in this.rooms)
            {
                if (room == null)
                {
                    break;
                }
                roomIndex++;
            }

            if (roomIndex == 0)
            {
                this.rooms[numberOfRooms % 2] = new Room(pet);
            }

            int direction = roomIndex%2; //1-left; 0-right
            int delta = roomIndex/2;

            //TODO
        }

        public IEnumerator<Room> GetEnumerator()
        {
            int startIndex = this.numberOfRooms % 2;

            yield return this.rooms[startIndex];

            for (int i = 0; i < this.numberOfRooms % 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    if (i % 2 == 0)
                    {
                        yield return this.rooms[startIndex + j];
                    }
                    else
                    {
                        yield return this.rooms[startIndex - j];
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}