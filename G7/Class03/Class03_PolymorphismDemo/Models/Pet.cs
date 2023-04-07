namespace Models
{
    public class Pet
    {
        public string Name { get; set; }

        public virtual string Eat()
        {
            return "Calling Eat function from Pet class";
        }
    }
}