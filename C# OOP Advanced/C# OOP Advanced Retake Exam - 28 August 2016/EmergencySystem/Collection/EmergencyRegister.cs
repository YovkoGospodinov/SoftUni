namespace EmergencySystem.Collection
{
    using System.Collections.Generic;
    using Contracts;
    
    public class EmergencyRegister
    {
        private Queue<IEmergency> emergencyQueue;

        // It is better to use the built-in class Queue and solving the Task 2. The reason for commenting every line of code below is the same.

        // private const int InitialSize = 16;
        // private IEmergency[] emergencyQueue;
        // private int currentSize;
        // private int nextIndex;
        
        public EmergencyRegister()
        {
            this.emergencyQueue = new Queue<IEmergency>();

            // this.emergencyQueue = new IEmergency[InitialSize];
            // this.currentSize = 0;
            // this.nextIndex = 0;
        }

        public int EmergencyQueueSize => this.emergencyQueue.Count;

        public void EnqueueEmergency(IEmergency emergency)
        {
            this.emergencyQueue.Enqueue(emergency);

            // this.CheckIfResizeNeeded();
            // this.emergencyQueue[this.nextIndex] = emergency;
            // this.IncrementNextIndex();
            // this.IncrementCurrentSize();
        }

        public IEmergency DequeueEmergency()
        {
            IEmergency removedEmergency = this.emergencyQueue.Dequeue();

            return removedEmergency;

            // for (int i = 0; i < this.currentSize - 1; i++)
            // {
            //     this.emergencyQueue[i] = this.emergencyQueue[i + 1];
            // }
            // this.DecrementNextIndex();
            // this.DecrementCurrentSize();
        }

        public IEmergency PeekEmergency()
        {
            IEmergency peekedEmergency = this.emergencyQueue.Peek();

            return peekedEmergency;
        }

        public bool IsEmpty()
        {
            return this.emergencyQueue.Count == 0;
        }

        //// private void IncrementNextIndex()
        // {
        //     this.nextIndex++;
        // }
        // private void DecrementNextIndex()
        // {
        //     this.nextIndex--;
        // }
        // private void IncrementCurrentSize()
        // {
        //     this.currentSize++;
        // }
        // private void DecrementCurrentSize()
        // {
        //     this.currentSize--;
        // }
        // private void CheckIfResizeNeeded()
        // {
        //     if (this.currentSize == this.emergencyQueue.Length)
        //     {
        //         this.Resize();
        //     }
        // }
        // private void Resize()
        // {
        //     IEmergency[] newArray = new IEmergency[2 * this.currentSize];
        //      for (int i = 0; i < this.currentSize; i++)
        //     {
        //         newArray[i] = this.emergencyQueue[i];
        //     }
        //      this.emergencyQueue = newArray;
        // }
    }
}
