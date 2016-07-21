using System;
using System.Collections;
using System.Collections.Generic;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private IList collection;
        private int currentIndex;

        public ListyIterator()
        {
            this.currentIndex = 0;
            this.collection = new List<T>();
        }

        public ListyIterator(IList collection) 
            : this()
        {
            this.collection = collection;
        }

        public bool Move()
        {
            if (this.currentIndex < collection.Count - 1)
            {
                currentIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return this.currentIndex < collection.Count - 1;
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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}