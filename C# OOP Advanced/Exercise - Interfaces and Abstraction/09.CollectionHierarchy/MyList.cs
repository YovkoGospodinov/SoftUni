namespace _09.CollectionHierarchy
{
    using _09.CollectionHierarchy.Contracts;

    public class MyList : Collection, IMyList
    {
        public int Add(string text)
        {
            base.MyCollection.Insert(0, text);
            return 0;
        }

        public string Remove()
        {
            string elementToRemove = base.MyCollection[0];
            base.MyCollection.RemoveAt(0);
            return elementToRemove;
        }
        
        public int Used
        {
            get { return base.MyCollection.Count; }
        }
    }
}