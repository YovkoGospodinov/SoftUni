namespace RecyclingStation.Models.DisposalStrategies
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class StorableDisposalStrategy : DisposalStrategy
    {
        public override IProcessingData ProcessGarbage(IWaste garbage)
        {
            base.totalVolume = garbage.Weight * garbage.VolumePerKg;

            base.energyUsed = (13 * base.totalVolume) / 100;
            base.capitalUsed = (65 * base.totalVolume) / 100;

            return new ProcessingData(base.energyProduced, base.energyUsed, base.capitalEarned, base.capitalUsed);
        }
    }
}