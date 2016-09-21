namespace RecyclingStation.Models.Waste
{
    using RecyclingStation.Enums;
    using RecyclingStation.WasteDisposal.Attributes;

    [Disposable]
    public class StorableWaste : Waste
    {
        private WasteType type;

        public StorableWaste(string name, double weight, double volumePerKg) 
            : base(name, weight, volumePerKg)
        {
            this.type = WasteType.Storable;
        }

        public WasteType Type { get; private set; }
    }
}