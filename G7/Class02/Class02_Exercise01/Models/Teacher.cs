using Models.Interfaces;

namespace Models
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; }

        public Teacher(int id, string name, string username, string password, List<string> subjects) :
            base(id, name, username, password)
        {
            Subjects = subjects;
        }

        public override string PrintUser()
        {
            return "Teacher: " + base.PrintUser() + $"[{string.Join(", ", Subjects)}]";
        }
    }
}
