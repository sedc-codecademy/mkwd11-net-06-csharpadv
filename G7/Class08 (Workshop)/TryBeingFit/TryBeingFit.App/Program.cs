using TryBeingFit.Models;
using TryBeingFit.Models.Database;
using TryBeingFit.Services;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interface;
using TryBeingFit.Services.Seeder;

namespace TryBeingFit.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDatabase<User> _userDatabase = new Database<User>();
            IDatabase<Training> _trainingDatabase = new Database<Training>();

            DatabaseSeeder seeder = new DatabaseSeeder(_userDatabase, _trainingDatabase);
            seeder.Seed();

            IUserService _userService = new UserService(_userDatabase);
            ITrainingService _trainingService = new TrainingService(_trainingDatabase);

            while(true)
            {
                try
                {
                    Console.WriteLine("Choose an option: ");
                    Console.WriteLine("1. Log-in");
                    Console.WriteLine("2. Register");

                    int selection = InputHelper.InputNumber();

                    switch(selection)
                    {
                        case 1:
                            LoginChoice(_userService, _trainingService);
                            break;
                        case 2:
                            RegisterChoice(_userService);
                            break;
                        default:
                            throw new Exception("Invalid choice!");
                    }
                } catch(Exception ex)
                {
                    Console.WriteLine($"Error happened: {ex.Message}");
                }
            }
        }

        static void LoginChoice(IUserService userService, ITrainingService trainingService)
        {
            Console.Write("Please enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();

            User loginUser = userService.Login(username, password);

            if(loginUser.UserRole == Models.Enums.UserRole.Trainer)
            {
                Trainer trainer = (Trainer)loginUser;

                Console.WriteLine($"Hello trainer {trainer.FullName}, great to see you.");
                Console.WriteLine($"Those are your training sessions: ");

                foreach(LiveTraining liveTraining in trainer.LiveTrainings)
                {
                    Console.WriteLine(liveTraining.GetInfo());
                }

                Console.WriteLine("Which training do you want to reschedule: ");
                int trainingId = InputHelper.InputNumber();
            }
        }

        static void RegisterChoice(IUserService userService)
        {

        }
    }
}