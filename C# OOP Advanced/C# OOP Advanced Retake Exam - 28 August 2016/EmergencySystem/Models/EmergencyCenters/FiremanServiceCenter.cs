namespace EmergencySystem.Models.EmergencyCenters
{
    using System.Collections.Generic;
    using EmergencySystem.Attributes;
    using EmergencySystem.Contracts;

    [Emergency]
    public class FiremanServiceCenter : BaseEmergencyCenter
    {
        public FiremanServiceCenter(string name, int amountOfMaximumEmergencies) 
            : base(name, amountOfMaximumEmergencies)
        {
        }

        public override bool IsForRetirement()
        {
            bool isForRetirement = false;

            if (this.AmountOfMaximumEmergencies == this.ProcessedEmergencies.Count)
            {
                isForRetirement = true;
            }

            return isForRetirement;
        }
    }
}
