namespace _03.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustumStack<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int currentIndex;

        public CustumStack()
        {
            this.collection = new List<T>();
            this.currentIndex = 0;
        }

        public void PushElement(List<T> elements)
        {
            this.collection.AddRange(elements);
            currentIndex = this.collection.Count - 1;
        }

        public void PopElement()
        {
            if (this.collection.Count > 0)
            {
                this.collection.RemoveAt(currentIndex);
                currentIndex--;
            }
            else
            {
                Console.WriteLine("No elements");
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.collection.Count - 1; i >= 0; i--)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}