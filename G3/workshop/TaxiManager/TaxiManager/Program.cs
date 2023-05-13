using TaxiManager.Domain.Enums;
using TaxiManager.Domain.Models;
using TaxiManager.Services.Abstraction;
using TaxiManager.Services.Implementation;
using TaxiManager.Services.Utilities;
using TaxiManager.Services.Utilities.Models;

IUserService userService = new UserService();
ICarService carService = new CarService();
IDriverService driverService = new DriverService();
IUiService uiService = new UiService();

InitializeStartingData();

while (true) 
{
    Console.Clear();

    if (userService.CurrentUser == null) 
    {
        try
        {
            User inputUser = uiService.LogInMenu();
            userService.Login(inputUser.Username, inputUser.Password);
            uiService.Welcome(userService.CurrentUser);
        }
        catch (Exception ex)
        {
            ExtendedConsole.WriteLine(ex.Message, ConsoleColor.Red);
            Console.ReadLine();
            continue;
        }
    }

    int menuChoiceNumber = uiService.MainMenu(userService.CurrentUser.Role);

    if (menuChoiceNumber == -1) 
    {
        continue;
    }

    MenuChoices mainMenuChoice = uiService.MenuItems[menuChoiceNumber - 1];
    switch (mainMenuChoice)
    {
        case MenuChoices.AddNewUser:
            string username = ExtendedConsole.GetInput("Enter username: ");
            string password = ExtendedConsole.GetInput("Enter password: ");
            if (!StringValidator.ValidateUsername(username) || !StringValidator.ValidatePassword(password)) 
            {
                ExtendedConsole.WriteLine("Add faield. Username and Password must have atleast 5 characters", ConsoleColor.Red);
                Console.ReadLine();
                continue;
            }
            break;
        case MenuChoices.RemoveExistingUser:
            List<User> users = userService.GetAll(user => user.Id != userService.CurrentUser.Id).ToList();
            int choice = uiService.ChooseEntitiesMenu(users);
            if (choice == -1) 
            {
                continue;
            }
            userService.Remove(users[choice - 1].Id);
            break;
        case MenuChoices.ListAllDivers:
            driverService.GetAll().Print();
            break;
        case MenuChoices.TaxiLicenseStatus:
            driverService.GetAll().PrintStatus();
            break;
        case MenuChoices.DriverManager:
            var driverManagerMenu = new List<DriverManagerChoice>() 
            { DriverManagerChoice.AssignDriver, DriverManagerChoice.UnassignDriver };

            int driverManagerChoice = uiService.ChooseMenu(driverManagerMenu);

            var availableDrivers = driverService.GetAll(driver => driverService.IsAvailableDriver(driver));

            if (driverManagerChoice == 1)
            {
                var availableForAssigningDrivers = availableDrivers.Where(driver => driver.Car == null).ToList();
                var assigningDrvierChoice = uiService.ChooseEntitiesMenu(availableForAssigningDrivers);

                if (assigningDrvierChoice == -1) 
                {
                    continue;
                }

                var availableCarsForAssigning = carService.GetAll(car => carService.IsAvailableCar(car)).ToList();
                var assigningCarChoice = uiService.ChooseEntitiesMenu(availableCarsForAssigning);

                if (assigningCarChoice == -1)
                {
                    continue;
                }

                driverService.AssignDriver(availableForAssigningDrivers[assigningDrvierChoice - 1], 
                                           availableCarsForAssigning[assigningCarChoice - 1]);
            }
            else if (driverManagerChoice == 2) 
            {
                var availableForUnassigningDrivers = availableDrivers.Where(driver => driver.Car != null).ToList();
                var unassigningDrvierChoice = uiService.ChooseEntitiesMenu(availableForUnassigningDrivers);

                if (unassigningDrvierChoice == -1)
                {
                    continue;
                }

                driverService.UnassignDriver(availableForUnassigningDrivers[unassigningDrvierChoice - 1]);
            }
            break;
        case MenuChoices.ListAllCars:
            carService.GetAll().Print();
            break;
        case MenuChoices.LicensePlateStatuses:
            carService.GetAll().PrintStatus();
            break;
        case MenuChoices.ChangePassword:
            string oldPassword = ExtendedConsole.GetInput("Enter old password: ");
            string newPassword = ExtendedConsole.GetInput("Enter new password: ");

            bool changeSuccesfull = userService.ChangePassword(oldPassword, newPassword);

            if (changeSuccesfull)
            {
                ExtendedConsole.WriteLine("Password changed", ConsoleColor.Green);
            }
            else 
            {
                ExtendedConsole.WriteLine("Password change failed. Please try again.", ConsoleColor.Red);
            }

            Console.ReadLine();
            break;
        case MenuChoices.Exit:
            userService.CurrentUser = null;
            continue;
    }

}


void InitializeStartingData() 
{
    User easyadministrator = new User("adm", "123", Role.Administrator);
    User administrator = new User("BobBobsky", "bobbest1", Role.Administrator);
    User easymanager = new User("mng", "123", Role.Manager);
    User manager = new User("JillWayne", "jillawesome1", Role.Manager);
    User easymaintenances = new User("mnt", "123", Role.Maintenance);
    User maintenances = new User("GregGregsky", "supergreg1", Role.Maintenance);
    List<User> seedUsers = new List<User>() { 
        easyadministrator, administrator, easymanager, manager, easymaintenances, maintenances };
    
    userService.Seed(seedUsers);

    Car car1 = new Car("Auris (Toyota)", "AFW950", new DateTime(2023, 12, 1));
    Car car2 = new Car("Auris (Toyota)", "CKE480", new DateTime(2021, 10, 15));
    Car car3 = new Car("Transporter (Volkswagen)", "GZDR69", new DateTime(2024, 5, 30));
    Car car4 = new Car("Mondeo (Ford)", "5RIP283", new DateTime(2022, 5, 13));
    Car car5 = new Car("Premier (Peugeot)", "2AR9907", new DateTime(2022, 11, 9));
    Car car6 = new Car("Vito (Mercedes)", "6RND294", new DateTime(2023, 3, 11));
    List<Car> seedCars = new List<Car>() { car1, car2, car3, car4, car5, car6 };
    carService.Seed(seedCars);

    Driver driver1 = new Driver("Romario", "Walsh", Shift.NoShift, null, "LC12456123", new DateTime(2023, 11, 5));
    Driver driver2 = new Driver("Kathleen", "Rankin", Shift.Morning, car1, "LC54435234", new DateTime(2022, 1, 12));
    Driver driver3 = new Driver("Ashanti", "Mooney", Shift.Evening, car1, "LC65803245", new DateTime(2022, 5, 19));
    Driver driver4 = new Driver("Zakk", "Hook", Shift.Afternoon, car1, "LC20897583", new DateTime(2023, 9, 28));
    Driver driver5 = new Driver("Xavier", "Kelly", Shift.NoShift, null, "LC15636280", new DateTime(2024, 6, 1));
    Driver driver6 = new Driver("Joy", "Shelton", Shift.Evening, car2, "LC47845611", new DateTime(2023, 7, 3));
    Driver driver7 = new Driver("Kristy", "Riddle", Shift.Morning, car3, "LC19006543", new DateTime(2024, 6, 12));
    Driver driver8 = new Driver("Stuart", "Mayer", Shift.Evening, car3, "LC53187767", new DateTime(2023, 10, 10));
    List<Driver> seedDrivers = new List<Driver>() { driver1, driver2, driver3, driver4, driver5, driver6, driver7, driver8 };
    driverService.Seed(seedDrivers);
}