namespace Class11_DatabaseJsonDemo
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public BaseEntity()
        {
            Random rnd = new Random();
            Id = rnd.Next(1, int.MaxValue);
        }

        public abstract string GetInfo();
    }
}