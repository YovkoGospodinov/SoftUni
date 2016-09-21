namespace RecyclingStation.Models
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class RecyclingFactory : IRecyclingFactory
    {
        private double energy;
        private double capital;

        public RecyclingFactory()
        {
            this.energy = 0;
            this.capital = 0;
        }

        public void ProcessingData(IProcessingData data)
        {
            this.Energy += data.EnergyBalance;
            this.Capital += data.CapitalBalance;
        }

        public string FactoryStatus()
        {
            return $"Energy: {this.Energy:F2} Capital: {this.Capital:F2}";
        } 

        public double Energy { get; private set; }
        public double Capital { get; private set; }
    }
}