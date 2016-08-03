namespace _09.CollectionHierarchy
{
    using System.Collections.Generic;

    public abstract class Collection
    {
        private IList<string> myCollection;

        protected Collection()
        {
            this.MyCollection = new List<string>();
        }

        public IList<string> MyCollection { get;}
    }
}