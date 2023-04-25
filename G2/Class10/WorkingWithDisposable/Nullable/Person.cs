namespace Nullable
{
    public class Person
    {
        public int Id { get; set; }

        public int? Score { get; set; }

        public bool IsEmployed { get; set; }

        public bool? HasPet { get; set; }

        public string Name { get; set; }

        public Wife Wife { get; set; }
    }
}
