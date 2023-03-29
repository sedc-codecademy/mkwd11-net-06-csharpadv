using QuizApp.Domain.Enums;

namespace QuizApp.Domain.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Role Role { get; set; }
    }
}
