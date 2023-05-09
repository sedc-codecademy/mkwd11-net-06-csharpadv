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
            IUserTrainingService _userTrainingService = new UserTrainingService(_userDatabase, _trainingDatabase);

            while (true)
            {
                try
                {
                    Console.WriteLine("Choose an option: ");
                    Console.WriteLine("1. Log-in");
                    Console.WriteLine("2. Register");

                    int selection = InputHelper.InputNumber();

                    switch (selection)
                    {
                        case 1:
                            LoginChoice(_userService, _trainingService, _userTrainingService);
                            break;
                        case 2:
                            RegisterChoice(_userService);
                            break;
                        default:
                            throw new Exception("Invalid choice!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error happened: {ex.Message}");
                }
            }
        }

        static void LoginChoice(IUserService userService, ITrainingService trainingService, IUserTrainingService userTrainingService)
        {
            Console.Write("Please enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();

            User loginUser = userService.Login(username, password);

            if (loginUser.UserRole == Models.Enums.UserRole.Trainer)
            {
                Trainer trainer = (Trainer)loginUser;

                Console.WriteLine($"Hello trainer {trainer.FullName}, great to see you.");
                Console.WriteLine($"Those are your training sessions: ");

                foreach (LiveTraining liveTraining in trainer.LiveTrainings)
                {
                    Console.WriteLine(liveTraining.GetInfo());
                }

                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Reschedule a training session");
                Console.WriteLine("2. Log out");

                int option = InputHelper.InputNumber();

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Which training session you want to reschedule (insert the ID)?");
                            int trainingSessionId = InputHelper.InputNumber();
                            Console.WriteLine("What is the new date for the training session?");
                            DateTime newDate = InputHelper.InputDateTime();

                            LiveTraining liveTraining = trainingService.GetLiveTraining(trainingSessionId);
                            trainingService.RescheduleTraining(trainer, liveTraining, newDate);
                            Console.WriteLine($"Your session with id {liveTraining.Id} is rescheduled!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"See you again {loginUser.FullName}");
                            return;
                        }
                    default:
                        {
                            throw new Exception("Invalid choice!");
                        }
                }
            }
            if (loginUser.UserRole == Models.Enums.UserRole.Standard)
            {
                StandardUser standardUser = (StandardUser)loginUser;

                Console.WriteLine($"Hello {standardUser.FullName}, great to see you.");
                Console.WriteLine($"Those are your video training sessions: ");
                foreach (VideoTraining videoTraining in standardUser.VideoTrainings)
                {
                    Console.WriteLine(videoTraining.GetInfo());
                }

                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Upgrade to premium user");
                Console.WriteLine("2. Add new video training to your list");
                Console.WriteLine("3. Log out");

                int option = InputHelper.InputNumber();

                switch (option)
                {
                    case 1:
                        {
                            userService.UpgradeUser(standardUser.Id);
                            Console.WriteLine("Thank you for upgrading to premium user!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Select a videoTraining that you want to add to your list.");
                            List<VideoTraining> allVideoTrainings = trainingService.GetAllVideoTrainings();

                            foreach (VideoTraining videoTraining in allVideoTrainings)
                            {
                                Console.WriteLine(videoTraining.GetInfo());
                            }
                            Console.Write("Insert the video training ID: ");
                            int videoTrainingId = InputHelper.InputNumber();

                            userTrainingService.AddTrainingSessionToUser(standardUser.Id, videoTrainingId);
                            Console.Write($"You have been successfully assigned to the video training with ID: {videoTrainingId}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"See you again {loginUser.FullName}");
                            return;
                        }
                    default:
                        {
                            throw new Exception("Invalid choice!");
                        }
                }
            }
            if (loginUser.UserRole == Models.Enums.UserRole.Premium)
            {
                PremiumUser premiumUser = (PremiumUser)loginUser;

                Console.WriteLine($"Hello {premiumUser.FullName}, great to see you.");
                Console.WriteLine($"Those are your video training sessions: ");
                foreach (VideoTraining videoTraining in premiumUser.VideoTrainings)
                {
                    Console.WriteLine(videoTraining.GetInfo());
                }
                Console.WriteLine($"Those are your live training sessions: ");
                foreach (LiveTraining liveTraining in premiumUser.LiveTrainings)
                {
                    Console.WriteLine(liveTraining.GetInfo());
                }

                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Add new video training to your list");
                Console.WriteLine("2. Add new live training to your list");
                Console.WriteLine("3. Log out");

                int option = InputHelper.InputNumber();

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Select a videoTraining that you want to add to your list.");
                            List<VideoTraining> allVideoTrainings = trainingService.GetAllVideoTrainings();

                            foreach (VideoTraining videoTraining in allVideoTrainings)
                            {
                                Console.WriteLine(videoTraining.GetInfo());
                            }
                            Console.Write("Insert the video training ID: ");
                            int videoTrainingId = InputHelper.InputNumber();

                            userTrainingService.AddTrainingSessionToUser(premiumUser.Id, videoTrainingId);
                            Console.Write($"You have been successfully assigned to the video training with ID: {videoTrainingId}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Select a liveTraining that you want to add to your list.");
                            List<LiveTraining> allLiveTrainings = trainingService.GetAllLiveTrainings();

                            foreach (LiveTraining liveTraining in allLiveTrainings)
                            {
                                Console.WriteLine(liveTraining.GetInfo());
                            }
                            Console.Write("Insert the live training ID: ");
                            int liveTrainingId = InputHelper.InputNumber();

                            userTrainingService.AddTrainingSessionToUser(premiumUser.Id, liveTrainingId);
                            Console.WriteLine($"You have been successfully assigned to the live training with ID: {liveTrainingId}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"See you again {loginUser.FullName}");
                            return;
                        }
                    default:
                        {
                            throw new Exception("Invalid choice!");
                        }
                }
            }
        }

        static void RegisterChoice(IUserService userService)
        {
            Console.Write("Please insert you first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please insert you last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Please insert you username: ");
            string userName = Console.ReadLine();

            Console.Write("Please insert you password: ");
            string password = Console.ReadLine();

            Console.Write("Please insert you email: ");
            string email = Console.ReadLine();

            Console.Write("Please insert you phone: ");
            string phone = Console.ReadLine();

            userService.Register(firstName, lastName, userName, password, email, phone);
            Console.WriteLine($"Thank you for registration. Please proceed on to log-in");
        }
    }
}