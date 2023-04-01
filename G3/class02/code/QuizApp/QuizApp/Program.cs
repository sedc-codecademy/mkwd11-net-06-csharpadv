using QuizApp.Domain;
using QuizApp.Domain.Models;
using QuizApp.Services;

UserService userService = new UserService();

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

        if (teacher != null) { }

        Console.ReadLine();
    }
	catch (Exception ex)
	{
        Console.WriteLine("An error occured!");
        Console.WriteLine(ex.Message);
    }

} 