namespace RecyclingStation.Models.Waste
{
    using RecyclingStation.WasteDisposal.Interfaces;
    using RecyclingStation.WasteDisposal.Attributes;

    [Disposable]
    public abstract class Waste : IWaste
    {
        #region Fields
        private string name;
        private double volumePerKg;
        private double weight;
        #endregion

        #region Constructors
        protected Waste(string name, double weight, double volumePerKg)
        {
            this.name = name;
            this.volumePerKg = volumePerKg;
            this.weight = weight;
        }
        #endregion

        #region Properties
        public string Name => this.name;
        public double VolumePerKg => this.volumePerKg;
        public double Weight => this.weight;
        #endregion
    }
}