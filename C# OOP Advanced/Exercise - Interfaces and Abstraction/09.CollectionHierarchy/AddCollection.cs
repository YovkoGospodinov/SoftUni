namespace _09.CollectionHierarchy
{
    using _09.CollectionHierarchy.Contracts;

    public class AddCollection : Collection, IAddable
    {
        public int Add(string text)
        {
            base.MyCollection.Add(text);
            return base.MyCollection.Count - 1;
        }
    }
}