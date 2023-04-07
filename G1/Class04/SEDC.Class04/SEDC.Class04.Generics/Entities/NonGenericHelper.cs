namespace SEDC.Class04.Generics.Entities
{
    public class NonGenericHelper
    {
        public void GoThroughList(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void GetInfoForList(List<string> strings)
        {
            Console.WriteLine($"The list has {strings.Count} elements and the elements are of type {strings.First().GetType()}");
        }

        public void GoThroughList(List<int> strings)
        {
            foreach (int s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void GetInfoForList(List<int> strings)
        {
            Console.WriteLine($"The list has {strings.Count} elements and the elements are of type {strings.First().GetType()}");
        }
    }
}
