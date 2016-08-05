namespace _04.Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private List<int> numbers;

        public Lake(List<int> elements)
        {
            this.numbers = elements;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.numbers[i];
                }
            }
            for (int i = this.numbers.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.numbers[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}