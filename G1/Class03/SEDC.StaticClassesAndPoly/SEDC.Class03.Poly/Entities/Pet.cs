namespace SEDC.Class03.Poly.Entities
{
    public abstract class Pet
    {
        public string Name { get; set; }

        public Pet(string name)
        {
            Name = name;
        }


        public abstract void Eat();
    }
}
