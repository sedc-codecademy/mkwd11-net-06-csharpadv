namespace SEDC.Class06.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string Info();
    }
}
