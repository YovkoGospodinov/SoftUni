namespace _01.EventImplementation
{
    public class Handler
    {

        public string OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            return $"Dispatcher's name change to {args.Name}";
        }
    }
}