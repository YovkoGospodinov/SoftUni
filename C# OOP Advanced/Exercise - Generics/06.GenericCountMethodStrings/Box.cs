namespace _06.GenericCountMethodStrings
{
    using System;

    public class Box<T>
        where T : IComparable<T>
    {
        private T data;

        public Box(T element)
        {
            this.data = element;
        }

        public T Data
        {
            get { return this.data; }
        }
    }
}