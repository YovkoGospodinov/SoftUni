namespace _01.Vehicles
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Drive(double kilometers)
        {
            double posibleTravelKm = base.FuelQuantity / (base.FuelConsumption + 1.6);
            if (posibleTravelKm >= kilometers)
            {
                base.FuelQuantity -= kilometers * (base.FuelConsumption + 1.6);
                Console.WriteLine($"Truck travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            base.FuelQuantity += liters * 0.95;
        }
    }
}
