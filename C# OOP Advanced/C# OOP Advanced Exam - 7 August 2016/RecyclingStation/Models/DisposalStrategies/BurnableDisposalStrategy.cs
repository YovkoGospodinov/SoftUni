namespace RecyclingStation.Models.DisposalStrategies
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public class BurnableDisposalStrategy : DisposalStrategy
    {
        public override IProcessingData ProcessGarbage(IWaste garbage)
        {
            base.totalVolume = garbage.Weight * garbage.VolumePerKg;

            base.energyProduced = base.totalVolume;
            base.energyUsed = base.totalVolume / 5;

            return new ProcessingData(base.energyProduced, base.energyUsed, base.capitalEarned, base.capitalUsed);
        }
    }
}