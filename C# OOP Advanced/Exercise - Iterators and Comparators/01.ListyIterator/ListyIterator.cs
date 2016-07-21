namespace _01.ListyIterator
{
    using System;
    using System.Collections.Generic;

    public class ListyIterator<T>
    {
        private IList<T> collection;
        private int currentIndex;

        public ListyIterator()
        {
            this.collection = new List<T>();
            this.currentIndex = 0;
        }

        public ListyIterator(IList<T> collection)
            : this()
        {
            this.collection = collection;
        }

        public bool Move()
        {
            if (this.currentIndex < this.collection.Count - 1)
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex < this.collection.Count - 1)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (this.collection.Count != 0)
            {
                Console.WriteLine(collection[currentIndex]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}