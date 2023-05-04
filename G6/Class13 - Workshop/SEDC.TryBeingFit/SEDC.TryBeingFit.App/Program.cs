using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Implementations;
using SEDC.TryBeingFit.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.TryBeingFit.App
{
    class Program
    {
        //Added reference to SEDC.TryBeingFit.Services
        //each service has its own database
        public static ITrainingService<VideoTraining> _videoTrainingService = new TrainingService<VideoTraining>();
        public static ITrainingService<LiveTraining> _liveTrainingService = new TrainingService<LiveTraining>();
        public static IUserService<Trainer> _trainerService = new UserService<Trainer>();
        public static IUserService<StandardUser> _standardUserService = new UserService<StandardUser>();
        public static IUserService<PremiumUser> _premiumUserService = new UserService<PremiumUser>();
        public static IUIService _uiService = new UIService();
        public static User _currentUser;
        static void Main(string[] args)
        {
            //call seed when you don't work with file db
            Seed();

            //List<VideoTraining> videoTrainingsDb = _videoTrainingService.GetAllTrainings();
            //Trainer trainerBill = _trainerService.LogIn("bill", "bill");
            //Trainer trainerPaul = _trainerService.LogIn("paul.paulsky", "paul.paulsky3");
            //_trainerService.ChangePassword(trainerPaul.Id, "paul.paulsky3", "paul.paulsky3333");
            //Trainer paulDb = _trainerService.ChangeInfo(trainerPaul.Id, "PaulUpdated", "Paulsky2");



            //int hashedString = "test123".GetHashCode();
            //int hashedString2 = "test123".GetHashCode();


            int option = _uiService.LogInMenu();
            Console.Clear();
            if (option == 1) //login
            {
                int roleChoice = _uiService.RoleMenu();
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                if (string.IsNullOrEmpty(username))
                {
                    throw new Exception("You must enter username");
                }
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (string.IsNullOrEmpty(password))
                {
                    throw new Exception("You must enter password");
                }
                UserRole role = (UserRole)roleChoice;
                switch (role)
                {
                    case UserRole.Standard:
                        _currentUser = _standardUserService.LogIn(username, password);
                        break;
                    case UserRole.Premium:
                        _currentUser = _premiumUserService.LogIn(username, password);
                        break;
                    case UserRole.Trainer:
                        _currentUser = _trainerService.LogIn(username, password);
                        break;
                }
            }
            else
            {
                StandardUser standardUser = _uiService.FillNewUserData();
                _currentUser = _standardUserService.Register(standardUser);
            }

            int mainMenuOption = _uiService.MainMenu(_currentUser.Role);
            string menuItem = _uiService.MenuItems[mainMenuOption - 1];

            switch (menuItem)
            {
                case "Train":
                    int trainOption = 1;
                    if(_currentUser.Role == UserRole.Premium)
                    {
                        trainOption = _uiService.TrainMenu();
                    }
                    if(trainOption == 1) //video
                    {
                        List<VideoTraining> videoTrainings = _videoTrainingService.GetAllTrainings();
                        int trainingOption = _uiService.TrainMenuItems(videoTrainings);
                        VideoTraining videoTraining = videoTrainings[trainingOption - 1];
                        Console.WriteLine("You chose:");
                        Console.WriteLine($"{videoTraining.Title} - {videoTraining.Time} minutes");
                        Console.ReadLine();
                    }
                    else
                    {
                        List<LiveTraining> liveTrainings = _liveTrainingService.GetAllTrainings();
                        int trainingChoice = _uiService.TrainMenuItems(liveTrainings);
                        LiveTraining liveTraining = liveTrainings[trainingChoice - 1];
                        Console.WriteLine(liveTraining.Title);
                        Console.WriteLine($"{liveTraining.Time} - Trainer: {liveTraining.Trainer.FirstName}");
                        Console.ReadLine();
                    }
                    break;
                case "Upgrade to Premium":
                    _uiService.UpgradeToPremiumInfo();
                    _standardUserService.RemoveById(_currentUser.Id);
                    _currentUser = _premiumUserService.Register(new PremiumUser()
                    {
                        FirstName = _currentUser.FirstName,
                        LastName = _currentUser.LastName,
                        Username = _currentUser.Username,
                        Password = _currentUser.Password
                    });
                    break;
                case "Reschedule training":
                    List<LiveTraining> liveTrainingsForCurrentUser = _liveTrainingService.GetAllTrainings()
                        .Where(x => x.Trainer.Id == _currentUser.Id).ToList();
                    if(liveTrainingsForCurrentUser.Count == 0)
                    {
                        Console.WriteLine("There are no live trainings!");
                    }
                    else
                    {
                        int trainingItem = _uiService.TrainMenuItems(liveTrainingsForCurrentUser);
                        Console.WriteLine("Enter number of days");
                        int days = ValidationHelper.ValidateNumber(Console.ReadLine(), 10);
                        //try boxing and unboxing of current user to cast to Trainer
                        _trainerService.GetById(_currentUser.Id)
                            .Reschedule(liveTrainingsForCurrentUser[trainingItem - 1], days);

                    }
                
                    break;
                case "Log Out":
                    _currentUser = null;
                    break;
                case "Account":
                    int accountChoice = _uiService.AccountMenu();
                    if(accountChoice == 1)
                    {
                        Console.WriteLine("Enter first name:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter last name:");
                        string lastName = Console.ReadLine();
                        switch (_currentUser.Role)
                        {
                            case UserRole.Standard:
                                _standardUserService.ChangeInfo(_currentUser.Id, firstName, lastName);
                                break;
                            case UserRole.Premium:
                                _premiumUserService.ChangeInfo(_currentUser.Id, firstName, lastName);
                                break;
                            case UserRole.Trainer:
                                _trainerService.ChangeInfo(_currentUser.Id, firstName, lastName);
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter old password:");
                        string oldPassword = Console.ReadLine();
                        Console.WriteLine("Enter new password:");
                        string newPassword = Console.ReadLine();
                        switch (_currentUser.Role)
                        {
                            case UserRole.Standard:
                                _standardUserService.ChangePassword(_currentUser.Id, oldPassword, newPassword);
                                break;
                            case UserRole.Premium:
                                _premiumUserService.ChangePassword(_currentUser.Id, oldPassword, newPassword);
                                break;
                            case UserRole.Trainer:
                                _trainerService.ChangePassword(_currentUser.Id, oldPassword, newPassword);
                                break;
                        }

                    }
                    break;
            }


            Console.ReadLine();

        }

        public static void Seed()
        {
            _standardUserService.Register(new StandardUser()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Username = "bob.bobsky",
                Password = "bob.bobsky1"
            });
            _premiumUserService.Register(new PremiumUser()
            {
                FirstName = "Anne",
                LastName = "Bobsky",
                Username = "anne.bobsky",
                Password = "anne.bobsky2"
            });
            Trainer paul = new Trainer()
            {
                FirstName = "Paul",
                LastName = "Paulsky",
                Username = "paul.paulsky",
                Password = "paul.paulsky3",
                YearsOfExperience = 3
            };
            Trainer registeredTrainer = _trainerService.Register(paul);
            _videoTrainingService.AddTraining(new VideoTraining()
            {
                Title = "Abs workout",
                Description = "Abs workout made easy",
                Difficulty = TrainingDifficulty.Easy,
                Link = "someLink",
                Rating = 3,
                Time = 15.55
            });
            _videoTrainingService.AddTraining(new VideoTraining()
            {
                Title = "Cardio",
                Description = "Dance cardio",
                Difficulty = TrainingDifficulty.Medium,
                Link = "someLink",
                Rating = 5,
                Time = 25
            });

            _liveTrainingService.AddTraining(new LiveTraining()
            {

                Title = "Cardio",
                Description = "Dance cardio",
                Difficulty = TrainingDifficulty.Medium,
                NextSession = DateTime.Now.AddDays(1),
                Trainer = registeredTrainer,
                Rating = 5,
                Time = 25,
            });
        }
    }
}
