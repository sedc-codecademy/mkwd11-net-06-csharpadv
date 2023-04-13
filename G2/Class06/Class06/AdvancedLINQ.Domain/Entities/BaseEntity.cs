namespace AdvancedLINQ.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public abstract void PrintInfo();
    }
}
