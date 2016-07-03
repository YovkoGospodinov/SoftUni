﻿namespace _06.RawData
{
    public class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }

            private set
            {
                this.speed = value;
            }
        }

        public int Power
        {
            get
            {
                return this.power;
            }
            private set
            {
                this.power = value;
            }
        }
    }
}
