namespace _07.GenericCountMethodDoubles
{
    using System;

    public class Box<T>
        where T : IComparable
    {
        public Box(T element)
        {
            this.Data = element;
        }

        public T Data { get; }
    }
}