namespace GenericClasses.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public abstract void GetInfo();
    }
}
