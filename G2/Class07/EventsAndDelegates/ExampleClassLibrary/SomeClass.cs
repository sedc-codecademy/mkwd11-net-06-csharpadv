namespace ExampleClassLibrary
{
    public class SomeClass : BaseEntity
    {
        public string Name { get; set; }

        public override void SomeMethond(string text)
        {
            Console.WriteLine($"Text: {text}");
        }
    }
}
