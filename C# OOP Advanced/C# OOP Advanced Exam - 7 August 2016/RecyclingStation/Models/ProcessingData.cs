namespace RecyclingStation.Models
{
    using RecyclingStation.WasteDisposal.Interfaces;
    using System;

    public class ProcessingData : IProcessingData
    {
        private double energyBalance;
        private double capitalBalance;

        public ProcessingData(double energyProduced, double energyUsed, double capitalEarned, double capitalUsed)
        {
            this.energyBalance = Math.Abs(energyProduced - energyUsed);
            this.capitalBalance = Math.Abs(capitalEarned - capitalUsed);
        }

        public double EnergyBalance { get; }
        public double CapitalBalance { get; }
    }
}