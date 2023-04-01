namespace SEDC.Class03.Domain.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public abstract void Eat();
    }
}
