using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Helpers
{
    public class NoneGenericListHelper
    {
        public void GoTroughSrings(List<string> strings) 
        {
            foreach (string str in strings) 
            {
                Console.WriteLine(str);
            }
        }

        public void GetInfoForStrings(List<string> strings) 
        {
            string firstElement = strings[0];
            Console.WriteLine($"This list has {strings.Count} " +
                $"members and is a type of {firstElement.GetType().Name}");
        }

        public void GoTroughIntegers(List<int> ints) 
        {
            foreach (int num in ints) 
            {
                Console.WriteLine(num);
            }
        }

        public void GetInfoForIntegers(List<int> ints)
        {
            int firstElement = ints[0];
            Console.WriteLine($"This list has {ints.Count} " +
                $"members and is a type of {firstElement.GetType().Name}");
        }
    }
}
