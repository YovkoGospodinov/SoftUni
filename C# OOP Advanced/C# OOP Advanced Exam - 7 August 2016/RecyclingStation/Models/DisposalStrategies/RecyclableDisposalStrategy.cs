namespace RecyclingStation.Models.DisposalStrategies
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class RecyclableDisposalStrategy : DisposalStrategy
    {
        public override IProcessingData ProcessGarbage(IWaste garbage)
        {
            base.totalVolume = garbage.Weight * garbage.VolumePerKg;

            base.energyUsed = base.totalVolume / 2;
            base.capitalEarned = 400 * garbage.Weight;

            return new ProcessingData(base.energyProduced, base.energyUsed, base.capitalEarned, base.capitalUsed);
        }
    }
}