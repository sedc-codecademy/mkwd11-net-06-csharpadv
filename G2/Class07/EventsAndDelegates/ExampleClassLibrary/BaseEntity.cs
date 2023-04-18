namespace ExampleClassLibrary
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public abstract void SomeMethond(string text);
    }
}
