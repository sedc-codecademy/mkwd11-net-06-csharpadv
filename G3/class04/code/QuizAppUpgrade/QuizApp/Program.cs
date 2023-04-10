using QuizApp;
using QuizApp.Services;
using QuizApp.Services.Abstraction;

IUserService userService = new UserService();
IQuizService quizService = new QuizService();

var appMain = new AppMain(userService, quizService);
appMain.Run();