namespace Models
{
    public class PetService
    {
        public string PetStatus(Cat cat)
        {
            return $"Hello {cat.Name}. This cat is {cat.Age} old.";
        }

        public string PetStatus(Cat cat, string greetingMessage)
        {
            return $"{greetingMessage} {cat.Name}. This cat is {cat.Age} years old";
        }

        public string PetStatus(Dog dog)
        {
            return $"Hello {dog.Name}. This dog is {dog.Color}.";
        }

        public string PetStatus()
        {
            return $"Hello. This is empty implementation";
        }

        //Will raise an error because the difference between methods with same name is made by the input params
        //public int PetStatus()
        //{
        //    return 1;
        //}
    }
}
