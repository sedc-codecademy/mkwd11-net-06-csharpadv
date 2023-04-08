namespace Generic_Demo01
{
    public static class GenericListHelper
    {
        public static string GetFormatedItemsOfList<T>(List<T> items)
        {
            return string.Join(", ", items);
        }

        public static string PrintInfoForList<T>(List<T> items)
        {
            return $"The list has {items.Count} items. They are of type {items.First().GetType().Name}";
        }
    }
}
