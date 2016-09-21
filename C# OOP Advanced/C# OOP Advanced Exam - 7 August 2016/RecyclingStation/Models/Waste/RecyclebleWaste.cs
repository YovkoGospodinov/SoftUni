namespace RecyclingStation.Models.Waste
{
    using RecyclingStation.Enums;
    using RecyclingStation.WasteDisposal.Attributes;

    [Disposable]
    public class RecyclebleWaste : Waste
    {
        private WasteType type;

        public RecyclebleWaste(string name, double weight, double volumePerKg) 
            : base(name, weight, volumePerKg)
        {
            this.type = WasteType.Recyclable;
        }

        public WasteType Type { get; private set; }
    }
}