namespace TheSystem
{
    using System.Collections.Generic;

    public abstract class HardwareComponent : Component
    {
        #region Fields
        private const string Type = "Hardware";
        private int maxCapacity;
        private int usedCapacity;
        private int maxMemory;
        private int usedMemory;
        private List<SoftwareComponent> software;
        #endregion


        protected HardwareComponent(string name, int maxCapacity, int maxMemory) 
            : base(name, Type)
        {
            this.MaxCapacity = maxCapacity;
            this.MaxMemory = maxMemory;
            this.Software = new List<SoftwareComponent>();
            this.usedCapacity = 0;
            this.usedMemory = 0;
        }

        #region Properties
        public virtual int MaxCapacity
        {
            get { return this.maxCapacity; }

            set { this.maxCapacity = value; }
        }

        public virtual int MaxMemory
        {
            get { return this.maxMemory; }

            set { this.maxMemory = value; }
        }

        public List<SoftwareComponent> Software
        {
            get { return this.software; }

            set { this.software = value; }
        }

        public int UsedCapacity => this.usedCapacity;

        public int UsedMemory => this.usedMemory;

        #endregion


        #region Methods
        //Checking whether the hardware component have enough resources for the new software
        public static bool haveEnoughMemCap(HardwareComponent currentHardware, SoftwareComponent currentSoftware)
        {
            bool result = true;

            if (currentHardware.MaxCapacity < currentSoftware.CapacityCons || currentHardware.MaxMemory < currentSoftware.MemoryCons)
            {
                result = false;
            }

            return result;
        }

        //Adding software which belongs to the current hardware component and update used capacity and memory
        public void AddSoftware(SoftwareComponent currentSoftware)
        {
            this.Software.Add(currentSoftware);
            this.usedCapacity += currentSoftware.CapacityCons;
            this.usedMemory += currentSoftware.MemoryCons;
        }

        //Removing software which belongs to the current hardware component and update used capacity and memory
        public void RemoveSoftware(SoftwareComponent currentSofware)
        {
            this.Software.Remove(currentSofware);
            this.usedCapacity -= currentSofware.CapacityCons;
            this.usedMemory -= currentSofware.CapacityCons;
        }
        #endregion

    }
}