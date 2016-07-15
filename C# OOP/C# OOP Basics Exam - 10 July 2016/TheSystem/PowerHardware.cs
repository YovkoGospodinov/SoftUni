namespace TheSystem
{
    using System.Collections.Generic;

    public class PowerHardware : HardwareComponent
    {
        public PowerHardware(string name, int maxCapacity, int maxMemory) 
            : base(name, maxCapacity, maxMemory)
        {
            //this.maxCapacity = maxCapacity - (maxCapacity * 3) / 4;
            //this.maxMemory = maxMemory + (maxMemory * 3) / 4;
        }

        #region 
        public override int MaxCapacity
        {
            get { return base.MaxCapacity; }
            set { base.MaxCapacity = value - (value*3)/4; }
        }

        public override int MaxMemory
        {
            get { return base.MaxMemory; }
            set { base.MaxMemory = value + (value*3)/4; }
        }
        #endregion

    }
}