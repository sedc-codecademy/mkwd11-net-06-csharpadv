using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class NonGenericListHelper
    {
        public void PrintListOfStrings(List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void PrintListOfInts(List<int> ints)
        {
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }

        public void PrintInfoForStringsList(List<string> strings)
        {
            Console.WriteLine($"The list has {strings.Count} members. They are of type {strings.First().GetType().Name}");
        }

        public void PrintInfoForIntsList(List<int> ints)
        {
            Console.WriteLine($"The list has {ints.Count} members. They are of type {ints.First().GetType().Name}");
        }
    }
}
