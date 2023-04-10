using QuizApp.Domain.Models;
using QuizApp.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class AppMain
    {
        private readonly IUserService _userService;
        private readonly IQuizService _quizService;

        public AppMain(IUserService userService, 
                       IQuizService quizService)
        {
            _userService = userService;
            _quizService = quizService;
        }

        public void Run() 
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        throw new Exception("You must enter valid username.");
                    }

                    Teacher teacher = _userService.GetTeacherByUserName(username);
                    if (teacher != null)
                    {
                        bool passwordMatch = _userService.PasswordMatch(teacher.Password);

                        if (!passwordMatch)
                        {
                            throw new Exception("Password did not match 3 times. Try again later.");
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        List<Student> studentsThatDidQuiz = _userService.GetStudentsThatDidTheQuiz();
                        foreach (Student student in studentsThatDidQuiz)
                        {
                            Console.WriteLine($"{student.Firstname} {student.Lastname} - {student.CorrectAnswers}");
                        }

                        Console.ForegroundColor = ConsoleColor.Red;
                        List<Student> studentsThatDidNotTakeQuiz = _userService.GetStudentThatDidNotFinishTheQuiz();
                        foreach (Student student in studentsThatDidNotTakeQuiz)
                        {
                            Console.WriteLine($"{student.Firstname} {student.Lastname}");
                        }

                        Console.ResetColor();
                    }
                    else
                    {
                        Student student = _userService.GetStudentByUsername(username);

                        if (student == null)
                        {
                            throw new Exception("That user does not exist.");
                        }

                        bool passwordMatch = _userService.PasswordMatch(student.Password);

                        if (!passwordMatch)
                        {
                            throw new Exception("Password did not match 3 times. Try again later.");
                        }

                        if (student.HasFinishedQuiz)
                        {
                            throw new Exception("You already did the quiz.");
                        }

                        _quizService.TakeQuiz(student);
                    }

                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occured!");
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
