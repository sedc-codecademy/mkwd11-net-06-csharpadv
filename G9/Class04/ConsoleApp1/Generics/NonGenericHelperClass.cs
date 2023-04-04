using Microsoft.VisualBasic;

namespace Generics
{
    public class NonGenericHelperClass
    {
        public void PrintAllStrings(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void GetStringInfo(List<string> strings)
        {
            Console.WriteLine($"The list is {strings.Count} long");
        }

        public void PrintAllInt(List<int> ints)
        {
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }

        public void GetIntInfo(List<int> ints)
        {
            Console.WriteLine($"The list is {ints.Count}" +
                $" long");
        }
    }
}