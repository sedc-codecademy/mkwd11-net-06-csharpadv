namespace Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public string Bark()
        {
            return "Bark bark";
        }

        public static bool Validate(Dog dog)
        {
            if (dog.Id <= 0)
            {
                return false;
            }

            if (dog.Name.Length < 2)
            {
                return false;
            }

            return true;
        }
    }
}