namespace RecyclingStation.Models.DisposalStrategies
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public abstract class DisposalStrategy : IGarbageDisposalStrategy
    {
        protected double energyProduced;
        protected double energyUsed;
        protected double capitalEarned;
        protected double capitalUsed;
        protected double totalVolume;

        public abstract IProcessingData ProcessGarbage(IWaste garbage);
    }
}