using SEDC.TryBeingFit.Domain.Database;
using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services;
using SEDC.TryBeingFit.Services.Implementations;
using SEDC.TryBeingFit.Services.Interfaces;

//1. SEED -> put some initial data in the db

//simulate of register of users  and adding trainings

//we make Program.cs dependent on interface, Program.cs uses variable of type IUserService
//That ensures that the variable will always have method Register, the implementation can be different
//the implementation depends on the type of the object assigned to the variable
//For example, standardUserService is always of type IUserService, which means always has the Register method
//the implementation of Register will be different, dependent on what we use, UserService or SecondUserService

IUserService<StandardUser> standardUserService = new UserService<StandardUser>();
//IUserService<StandardUser> standardUserService = new SecondUserService<StandardUser>();
IUserService<PremiumUser> premiumUserService = new UserService<PremiumUser>();
IUserService<Trainer> trainerService = new UserService<Trainer>();

ITrainingService<VideoTraining> videoTrainigService = new TrainingService<VideoTraining>();
ITrainingService<LiveTraining> liveTrainingService = new TrainingService<LiveTraining>();

//we created this service in order to extract some methods related to user input/output so that they don't take too much
//space in the main program
//The main program should just call methods containing logic
IUIService uiService = new UIService();

Seed();



//2. ASK THE USER TO CHOOSE OPTION LOGIN/REGISTER
User currentUser = null;
while (true)
{
    Console.WriteLine("Choose an option: 1).Login 2).Register");
    string input = Console.ReadLine();

    bool successParseInput = int.TryParse(input, out int userOption);
    if (!successParseInput)
    {
        // throw new Exception("Invalid user option");
        Console.WriteLine("Invalid user option");
        continue;
    }

    if (userOption == 1)
    {
        //login

        //1. enter username and password
        Console.WriteLine("Enter username");
        string inputUsername = Console.ReadLine();
        if (string.IsNullOrEmpty(inputUsername))
        {
            throw new Exception("You must enter username!");
        }

        Console.WriteLine("Enter password");
        string inputPassword = Console.ReadLine();
        if (string.IsNullOrEmpty(inputPassword))
        {
            throw new Exception("You must enter password!");
        }

        //2. enter user type
        Console.WriteLine("Enter user type: 1).Standard 2).Premium 3).Trainer");
        string typeInput = Console.ReadLine();
        bool successParseTypeInput = int.TryParse(typeInput, out int typeOption);
        if (!successParseTypeInput)
        {
            //throw new Exception("Invalid user type option");
            Console.WriteLine("Invalid user type option");
            continue;
        }
        if (typeOption < 1 || typeOption > 3)
        {
            //throw new Exception("Invalid user type option");
            Console.WriteLine("Invalid user type option");
            continue;
        }

        UserType userType = (UserType)typeOption;

        //3. search for user with the given type, username and password

        switch (userType)
        {
            case UserType.StandardUser:
                //login for standard user
                currentUser = standardUserService.Login(inputUsername, inputPassword);
                break;
            case UserType.PremiumUser:
                //login for premium user
                currentUser = premiumUserService.Login(inputUsername, inputPassword);
                break;
            case UserType.Trainer:
                //login for trainer
                currentUser = trainerService.Login(inputUsername, inputPassword);
                break;
        }

        break;
    }
    else if (userOption == 2)
    {
        //register

        //1. get data
        StandardUser standardUser = uiService.FillRegisterData();

        //2. try to register user
        //Users can only register as  standard users
        //the newly registered is immediatelly logged in
        currentUser = standardUserService.Register(standardUser);
        break;

    }
    else
    {
        Console.WriteLine("Invalid option! You must choose between 1).Login 2).Register");
        continue;
    }
}


//SHOW MAIN MENU
string mainMenuOption = uiService.MainMenu(currentUser.UserType);
switch (mainMenuOption)
{
    case "Train":
        if(currentUser.UserType == UserType.StandardUser)
        {
            videoTrainigService.GetChosenTraining();

            //SECOND OPTION
            List<VideoTraining> allVideoTrainings = videoTrainigService.GetAll();
            uiService.GetChosenTraining<VideoTraining>(allVideoTrainings);
        }
        else if(currentUser.UserType == UserType.PremiumUser)
        {
            Console.WriteLine("Enter option: 1)Video 2) Live");
            string input = Console.ReadLine();
            int trainingInput = int.Parse(input);

            switch (trainingInput)
            {
                case 1:
                    videoTrainigService.GetChosenTraining();
                    break;
                case 2:
                    liveTrainingService.GetChosenTraining();

                    //SECOND OPTION
                    List<LiveTraining> liveTrainings = liveTrainingService.GetAll();
                    uiService.GetChosenTraining<LiveTraining>(liveTrainings);
                    break;
                default:
                    Console.WriteLine("Invalid training option");
                    break;
            }
        }

        break;
    case "Account info":

        //change password
        Console.WriteLine("Enter old password:");
        string oldPassword = Console.ReadLine();
        Console.WriteLine("Enter new password:");
        string newPassword = Console.ReadLine();
        switch (currentUser.UserType)
        {
            case UserType.StandardUser:
                currentUser = standardUserService.ChangePassword(currentUser.Id, oldPassword, newPassword);
                break;
            case UserType.PremiumUser:
                currentUser = premiumUserService.ChangePassword(currentUser.Id, oldPassword, newPassword);
                break;
            case UserType.Trainer:
                currentUser = trainerService.ChangePassword(currentUser.Id, oldPassword, newPassword);
                break;
        }

       
        string currentUsername = currentUser.Username;
        //logout
        currentUser = null;

        standardUserService.Login(currentUsername, newPassword);

        break;

}



void Seed()
{

    StandardUser standardUser = new StandardUser
    {
        FirstName = "Bob",
        LastName = "Bobsky",
        Username = "bbobsky",
        Password = "Test12"
    };

    PremiumUser premiumUser = new PremiumUser
    {
        FirstName = "Ana",
        LastName = "Bobsky",
        Username = "abobsky",
        Password = "Test21"
    };

    Trainer trainer = new Trainer
    {
        FirstName = "Kate",
        LastName = "Katesky",
        Username = "kkatesky",
        Password = "Test31",
        YearsOfExperience = 5
    };

    standardUserService.Register(standardUser);
    premiumUserService.Register(premiumUser);
    trainerService.Register(trainer);

    //demo example
    List<StandardUser> allStandardUsers = standardUserService.GetAll();
    //Console.ReadLine();

    //seed trainings


    videoTrainigService.AddTraining(new VideoTraining
    {
        Title = "Cardio",
        Description = "Cardio training",
        Duration = 25,
        Level = TrainingLevel.Advanced,
        Trainer = trainer
    });

    liveTrainingService.AddTraining(new LiveTraining
    {
        Title = "Yoga",
        Description = "Yoga training",
        Duration = 35,
        Level = TrainingLevel.Intermediate,
        Trainer = trainer
    });
}

