namespace TheSystem
{
    public abstract class Component
    {
        #region Fields
        private string name;
        private string type;
        #endregion

        #region Constructors
        protected Component(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string Name => this.name;
        public string Type => this.type;

        #endregion


    }
}