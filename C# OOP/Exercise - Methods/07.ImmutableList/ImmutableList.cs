namespace _07.ImmutableList
{

    public class ImmutableList
    {
        public int[] collection;

        public ImmutableList(int[] collection)
        {
            this.collection = collection;
        }

        public ImmutableList GetNewImmutableList()
        {
            int[] newCollection = new int[this.collection.Length];

            for (int i = 0; i < collection.Length; i++)
            {
                newCollection[i] = this.collection[i];
            }

            return new ImmutableList(newCollection);
        }
    }
}
