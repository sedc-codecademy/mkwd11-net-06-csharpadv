namespace ControledGenerics
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public abstract void GetInfo();
    }
}