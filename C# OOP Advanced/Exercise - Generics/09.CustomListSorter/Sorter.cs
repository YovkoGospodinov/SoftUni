namespace _09.CustomListSorter
{
    public class Sorter
    {
        public static void SortElements(CustomList<string> list)
        {
            CustomList<string> tempList = new CustomList<string>();
            
            var numberOfElements = list.Values.Count;

            for (int i = 0; i < numberOfElements; i++)
            {
                var minElement = list.Values[0];
                foreach (var value in list.Values)
                {
                    if (value.CompareTo(minElement) < 0)
                    {
                        minElement = value;
                    }
                }
                tempList.AddElement(minElement);
                list.Values.Remove(minElement);
            }

            for (int i = 0; i < numberOfElements; i++)
            {
                list.AddElement(tempList[i]);
            }
        }
    }
}