namespace _09.CollectionHierarchy
{
    using _09.CollectionHierarchy.Contracts;

    public class AddRemoveCollection : Collection, IAddable, IRemovable
    {
        public int Add(string text)
        {
            base.MyCollection.Insert(0, text);
            return 0;
        }

        public string Remove()
        {
            int index = base.MyCollection.Count - 1;
            string elementToRemove = base.MyCollection[index];
            base.MyCollection.RemoveAt(index);
            return elementToRemove;
        }
    }
}