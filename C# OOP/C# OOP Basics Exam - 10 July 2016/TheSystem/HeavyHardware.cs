namespace TheSystem
{
    using System.Collections.Generic;

    public class HeavyHardware : HardwareComponent
    {
        public HeavyHardware(string name, int maxCapacity, int maxMemory) 
            : base(name, maxCapacity, maxMemory)
        {
            //this.maxCapacity = 2 * maxCapacity;
            //this.maxMemory = maxMemory - maxMemory / 4;
        }

        #region 
        public override int MaxCapacity
        {
            get { return base.MaxCapacity; }
            set { base.MaxCapacity = 2*value; }
        }

        public override int MaxMemory
        {
            get { return base.MaxMemory; }
            set { base.MaxMemory = value - value/4; }
        }
        #endregion

    }
}