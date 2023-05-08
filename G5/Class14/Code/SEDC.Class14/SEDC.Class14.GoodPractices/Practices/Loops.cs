namespace SEDC.Class14.GoodPractices.Practices
{
    public class Loops
    {
        List<string> strings = new List<string>() { "Bob", "Jordan", "Jill", "Greg", "Anne", "Maximilian" };
        public void BadLoop()
        {
            // Print all names that are the same length of the list
            for (int counter = 0; counter < strings.Count(); counter++)
            {
                if (strings[counter].Length == strings.Count())
                {
                    Console.WriteLine(strings[counter]);
                }
            }
        }

        public void GoodLoop()
        {
            // Continue here ...        
        }
    }
}
