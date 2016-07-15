namespace TheSystem
{
    public class LightSoftware : SoftwareComponent
    {
        public LightSoftware(string name, int capacityCons, int memoryCons, string hardwareComponentName) 
            : base(name, capacityCons, memoryCons, hardwareComponentName)
        {
            //this.capacityCons = capacityCons + capacityCons / 2;
            //this.memoryCons = memoryCons - memoryCons / 2;
        }

        #region 
        public override int CapacityCons
        {
            get { return base.CapacityCons; }
            set { base.CapacityCons = value + value/2; }
        }

        public override int MemoryCons
        {
            get { return base.MemoryCons; }
            set { base.MemoryCons = value - value/2; }
        }
        #endregion

    }
}