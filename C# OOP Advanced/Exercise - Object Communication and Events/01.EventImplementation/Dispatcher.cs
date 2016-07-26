namespace _01.EventImplementation
{
    public class Dispatcher
    {
        private string name;

        private delegate NameChangeEventHandler nameChange();

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public string OnNameChange(NameChangeEventArgs args)
        {
            return ;
        }
    }

    public delegate void NameChangeEventHandler();
}