namespace EmergencySystem.Collection
{
    using System.Collections.Generic;
    using Contracts;

    public class EmergencyCentersRegister
    {
        private Queue<IEmergencyCenter> emergencyCentersQueue;

        public EmergencyCentersRegister()
        {
            this.emergencyCentersQueue = new Queue<IEmergencyCenter>();
        }

        public int EmergencyCentersQueue => this.emergencyCentersQueue.Count;

        public void EnqueueEmergencyCenter(IEmergencyCenter emergencyCenter)
        {
            this.emergencyCentersQueue.Enqueue(emergencyCenter);
        }

        public IEmergencyCenter DequeueEmergencyCenter()
        {
            IEmergencyCenter removedCenter = this.emergencyCentersQueue.Dequeue();

            return removedCenter;
        }

        public IEmergencyCenter PeekEmergency()
        {
            IEmergencyCenter peekedEmergencyCenter = this.emergencyCentersQueue.Peek();

            return peekedEmergencyCenter;
        }

        public bool IsEmpty()
        {
            return this.emergencyCentersQueue.Count == 0;
        }
    }
}
