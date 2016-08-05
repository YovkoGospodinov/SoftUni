using System.Collections.Generic;

namespace _08.PetClinics
{
    public class Room
    {
        private Pet petInRoom;

        public Room(Pet pet)
        {
            this.petInRoom = pet;
        }

        public Pet PetInRoom => this.petInRoom;
    }
}