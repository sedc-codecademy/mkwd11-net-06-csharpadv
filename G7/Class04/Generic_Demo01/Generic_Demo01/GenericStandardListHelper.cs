namespace Generic_Demo01
{
    public class GenericStandardListHelper<T>
    {
        public string GetFormatedItemsOfList(List<T> items)
        {
            return string.Join(", ", items);
        }

        public string PrintInfoForList(List<T> items)
        {
            return $"The list has {items.Count} items. They are of type {items.First().GetType().Name}";
        }
    }
}
