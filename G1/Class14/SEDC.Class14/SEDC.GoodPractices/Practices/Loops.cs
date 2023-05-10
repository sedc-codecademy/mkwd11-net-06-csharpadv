using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.GoodPractices.Practices
{
    public class Loops
    {
        List<string> names = new List<string>()
        { 
            "Martin",
            "Damjan",
            "Antonio",
            "Stole",
            "Marija"
        };


        public void LoopExample()
        {



            //Bad example
            // Print all names that are the same length of the list length
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Length == names.Count)
                {
                    Console.WriteLine(names[i]);
                }
            }

            //Don't request fixed values inside a loop, declare a variable outside with the value

            //Good example
            // Print all names that are the same length of the list length
            int listLength = names.Count;
            for (int j = 0; j < listLength; j++)
            {
                if (names[j].Length == listLength)
                {
                    Console.WriteLine(names[j]);
                }
            }

        }
    }
}
