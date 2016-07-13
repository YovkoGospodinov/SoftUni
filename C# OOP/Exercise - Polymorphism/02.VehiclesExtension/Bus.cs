namespace _02.VehiclesExtension
{
    using System;

    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double kilometers)
        {
            double posibleTravelKm = base.FuelQuantity / (base.FuelConsumption + 1.4);
            if (posibleTravelKm >= kilometers)
            {
                base.FuelQuantity -= kilometers * (base.FuelConsumption + 1.4);
                Console.WriteLine($"Bus travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void DriveEmpty(double kilometers)
        {
            double posibleTravelKm = base.FuelQuantity / base.FuelConsumption;
            if (posibleTravelKm >= kilometers)
            {
                base.FuelQuantity -= kilometers * base.FuelConsumption;
                Console.WriteLine($"Bus travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
    }
}
