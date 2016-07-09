namespace _08.Cars
{
    public class Car
    {
        private long speed;
        private long fuel;
        private long fuelEconomy;
        private long travelDistance;
        private long travelTime;

        public Car(long speed, long fuel, long fuelEconomy)
        {
            this.Speed = speed;
            this.Fuel = fuel;
            this.FuelEconomy = fuelEconomy;
        }

        public long Speed
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

        public long Fuel
        {
            get
            {
                return this.fuel;
            }

            private set
            {
                this.fuel = value;
            }
        }

        public long FuelEconomy
        {
            get
            {
                return this.fuelEconomy;
            }

            private set
            {
                this.fuelEconomy = value;
            }
        }

        public long TravelDistance
        {
            get
            {
                return this.travelDistance;
            }

            private set
            {
                this.travelDistance = value;
            }
        }

        public long TravelTime
        {
            get
            {
                return this.travelTime;
            }

            private set
            {
                this.travelTime = value;
            }
        }

        public void Travel(long distance)
        {
            long posibleTravelDistance = (this.Fuel / this.FuelEconomy) * 100;
            long fuelConsumed = 0;
            long time = 0;

            if (posibleTravelDistance > distance)
            {
                this.TravelDistance += distance;
                fuelConsumed = (distance / 100) * this.FuelEconomy;
                time = (distance / this.Speed) * 60;
                this.TravelTime += time;
                this.Fuel -= fuelConsumed;
            }
            else
            {
                this.TravelDistance += posibleTravelDistance;
                time = (posibleTravelDistance / this.speed) * 60;
                this.TravelTime += time;
                this.Fuel = 0;
            }
        }

        public void Refuel(long liters)
        {
            this.Fuel += liters;
        }
    }
}
