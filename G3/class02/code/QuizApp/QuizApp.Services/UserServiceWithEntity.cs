using QuizApp.Domain.Models;
using QuizApp.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public class UserServiceWithEntity : IUserService
    {
        public Student GetStudentByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentsThatDidTheQuiz()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentThatDidNotFinishTheQuiz()
        {
            throw new NotImplementedException();
        }

        public Teacher GetTeacherByUserName(string username)
        {
            throw new NotImplementedException();
        }

        public bool PasswordMatch(string password)
        {
            throw new NotImplementedException();
        }
    }
}
