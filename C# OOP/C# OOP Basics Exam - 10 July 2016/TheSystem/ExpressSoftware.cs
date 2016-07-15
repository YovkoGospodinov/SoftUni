namespace TheSystem
{
    public class ExpressSoftware : SoftwareComponent
    {
        public ExpressSoftware(string name, int capacityCons, int memoryCons, string hardwareComponentName) 
            : base(name, capacityCons, memoryCons, hardwareComponentName)
        {
            //this.memoryCons = 2 * memoryCons;
        }

        #region 
        public override int MemoryCons
        {
            get { return base.MemoryCons; }
            set { base.MemoryCons = 2*value; }
        }
        #endregion

    }
}