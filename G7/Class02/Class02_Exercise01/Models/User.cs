using Models.Interfaces;

namespace Models
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        protected string Password { get; set; }

        public User(int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }

        public virtual string PrintUser()
        {
            return $"{Id}. {Name} ({Username})";
        }
    }
}
