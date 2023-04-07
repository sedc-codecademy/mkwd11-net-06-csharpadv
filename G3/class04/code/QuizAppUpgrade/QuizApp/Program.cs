using QuizApp.Domain.Models;
using QuizApp.Services;

UserService userService = new UserService();
QuizService quizService = new QuizService();

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

        Teacher teacher = userService.GetTeacherByUserName(username);
        if (teacher != null)
        {
            bool passwordMatch = userService.PasswordMatch(teacher.Password);

            if (!passwordMatch)
            {
                throw new Exception("Password did not match 3 times. Try again later.");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            List<Student> studentsThatDidQuiz = userService.GetStudentsThatDidTheQuiz();
            foreach (Student student in studentsThatDidQuiz)
            {
                Console.WriteLine($"{student.Firstname} {student.Lastname} - {student.CorrectAnswers}");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            List<Student> studentsThatDidNotTakeQuiz = userService.GetStudentThatDidNotFinishTheQuiz();
            foreach (Student student in studentsThatDidNotTakeQuiz)
            {
                Console.WriteLine($"{student.Firstname} {student.Lastname}");
            }

            Console.ResetColor();
        }
        else 
        {
            Student student = userService.GetStudentByUsername(username);

            if (student == null) 
            {
                throw new Exception("That user does not exist.");
            }

            bool passwordMatch = userService.PasswordMatch(student.Password);

            if (!passwordMatch)
            {
                throw new Exception("Password did not match 3 times. Try again later.");
            }

            if (student.HasFinishedQuiz) 
            {
                throw new Exception("You already did the quiz.");
            }

            quizService.TakeQuiz(student);
        }

        Console.ReadLine();
    }
	catch (Exception ex)
	{
        Console.WriteLine("An error occured!");
        Console.WriteLine(ex.Message);
    }

} 