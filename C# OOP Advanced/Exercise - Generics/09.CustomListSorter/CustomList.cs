namespace _09.CustomListSorter
{
    using System;
    using System.Collections.Generic;

    public class CustomList<T>
        where T : IComparable
    {
        private IList<T> values;

        public CustomList()
        {
            this.Values = new List<T>();
        }

        public IList<T> Values
        {
            get { return this.values; }
            set { this.values = value; }
        }

        public T this[int index]
        {
            get { return this.Values[index]; }
        }

        public void AddElement(T element)
        {
            this.Values.Add(element);
        }

        public void RemoveElement(int index)
        {
            this.Values.RemoveAt(index);
        }

        public bool ContainsElement(T element)
        {
            foreach (var value in this.Values)
            {
                if (value.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var tempIndex = this.Values[firstIndex];
            this.Values[firstIndex] = this.Values[secondIndex];
            this.Values[secondIndex] = tempIndex;
        }

        public int CountGreaterThan(T element)
        {
            int numberOfGreaterThan = 0;

            foreach (var value in this.Values)
            {
                if (value.CompareTo(element) > 0)
                {
                    numberOfGreaterThan++;
                }
            }

            return numberOfGreaterThan;
        }

        public T MaxElement()
        {
            //int numberOfElements = this.Values.Count;
            //return this.Values[numberOfElements - 1];

            T maxElement = this.Values[0];

            foreach (var value in this.Values)
            {
                if (value.CompareTo(maxElement) > 0)
                {
                    maxElement = value;
                }
            }

            return maxElement;
        }

        public T MinElement()
        {
            //return this.Values[0];

            T minElement = this.Values[0];

            foreach (var value in this.Values)
            {
                if (value.CompareTo(minElement) < 0)
                {
                    minElement = value;
                }
            }

            return minElement;
        }
    }
}