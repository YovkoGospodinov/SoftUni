namespace TheSystem
{
    public abstract class SoftwareComponent : Component
    {
        #region Fields
        private const string Type = "Software";
        private int capacityCons;
        private int memoryCons;
        private string hardwareComponentName;
        #endregion


        protected SoftwareComponent(string name, int capacityCons, int memoryCons, string hardwareComponentName) 
            : base(name, Type)
        {
            this.CapacityCons = capacityCons;
            this.MemoryCons = memoryCons;
            this.HardwareComponentName = hardwareComponentName;
        }

        #region Properties
        public virtual int CapacityCons
        {
            get { return this.capacityCons; }

            set { this.capacityCons = value; }
        }

        public virtual int MemoryCons
        {
            get { return this.memoryCons; }

            set { this.memoryCons = value; }
        }

        public string HardwareComponentName
        {
            get { return this.hardwareComponentName; }

            set { this.hardwareComponentName = value; }
        }
        #endregion

    }
}