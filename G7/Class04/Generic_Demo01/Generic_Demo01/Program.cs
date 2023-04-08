namespace Generic_Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "risto", "tijana", "djoko", "frosina" };
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<char> letters = new List<char> { 'A', 'a', 'b', 'B', 'c', 'C' };
            List<bool> flags = new List<bool> { true, false, false, true, false };

            //Console.WriteLine(NonGenericListHelper.GetFormatedItemsOfStringList(names));
            //Console.WriteLine(NonGenericListHelper.GetFormatedItemsOfIntList(numbers));
            //Console.WriteLine(NonGenericListHelper.GetFormatedItemsOfCharList(letters));


            //Console.WriteLine(NonGenericListHelper.PrintInfoForStringList(names));
            //Console.WriteLine(NonGenericListHelper.PrintInfoForIntsList(numbers));
            //Console.WriteLine(NonGenericListHelper.PrintInfoForCharsList(letters));

            //Usage of static class with generic methods
            Console.WriteLine(GenericListHelper.GetFormatedItemsOfList<string>(names));
            Console.WriteLine(GenericListHelper.GetFormatedItemsOfList<int>(numbers));
            Console.WriteLine(GenericListHelper.GetFormatedItemsOfList<char>(letters));
            Console.WriteLine(GenericListHelper.GetFormatedItemsOfList<bool>(flags));

            Console.WriteLine(GenericListHelper.PrintInfoForList<string>(names));
            Console.WriteLine(GenericListHelper.PrintInfoForList<int>(numbers));
            Console.WriteLine(GenericListHelper.PrintInfoForList<char>(letters));
            Console.WriteLine(GenericListHelper.PrintInfoForList<bool>(flags));

            //Usage of a standard generic class
            GenericStandardListHelper<string> stringHelper = new GenericStandardListHelper<string>();
            Console.WriteLine(stringHelper.GetFormatedItemsOfList(names));
            Console.WriteLine(stringHelper.PrintInfoForList(names));


            //Printing an object
            List<Person> people = new List<Person>
            {
                new Person() {Name = "Risto"},
                new Person() {Name = "Tijana"}
            };

            Console.WriteLine(GenericListHelper.GetFormatedItemsOfList<Person>(people));
            Console.WriteLine(GenericListHelper.GetFormatedItemsOfList<string>(people.Select(x => x.Name).ToList()));
            Console.WriteLine(GenericListHelper.PrintInfoForList<Person>(people));
        }
    }
}