namespace GoodPractices.Practices
{
    public class Loops
    {
        List<string> strings = new List<string>() { "Bob", "Jordan", "Jill", "Greg", "Anne", "Maximilian" };

        public void LoopsExamples()
        {
            // Bad example
            // Print all names that are the same length of the list
            for (int counter = 0; counter < strings.Count; counter++)
            {
                if (strings[counter].Length == strings.Count)
                {
                    Console.WriteLine(strings[counter]);
                }
            }

            // Good example
            // Print all names that are the same length of the list
            int listLength = strings.Count;
            for (int counter = 0; counter < listLength; counter++)
            {
                if (strings[counter].Length == listLength)
                {
                    Console.WriteLine(strings[counter]);
                }
            }
        }
    }
}
