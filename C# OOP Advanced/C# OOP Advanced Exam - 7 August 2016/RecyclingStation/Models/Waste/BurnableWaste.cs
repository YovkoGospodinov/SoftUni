namespace RecyclingStation.Models.Waste
{
    using RecyclingStation.Enums;
    using RecyclingStation.WasteDisposal.Attributes;

    [Disposable]
    public class BurnableWaste : Waste
    {
        private WasteType type;

        public BurnableWaste(string name, double weight, double volumePerKg) 
            : base(name, weight, volumePerKg)
        {
            this.type = WasteType.Burnable;
        }

        public WasteType Type { get; private set; }
    }
}