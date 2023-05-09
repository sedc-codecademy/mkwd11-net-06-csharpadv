using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Domain.Enums;
using TaxiManagerApp9000.Helpers;
using TaxiManagerApp9000.Services;
using TaxiManagerApp9000.Services.Interfaces;

#region Setup
IUIservice uiService = new UIService();
UserService userService = new UserService();

InitializeStartingData();
#endregion

#region UI
while (true)
{
    Console.Clear();
    if (userService.CurrentUser == null)
    {
        try
        {
            User loginUser = uiService.LogIn();
            userService.Login(loginUser.Username, loginUser.Password);

            TextHelper.TextGenerator($"Successful login ! Welcome [{userService.CurrentUser.Role}] {userService.CurrentUser.Username} !", ConsoleColor.Green);
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            TextHelper.TextGenerator(ex.Message, ConsoleColor.Red);
            Console.ReadLine();
            continue;
        }
    }

    bool loopActive = true;
    while (loopActive)
    {
        Console.Clear();
        int selectedItem = uiService.MainMenu(userService.CurrentUser.Role);
        if (selectedItem == -1)
        {
            TextHelper.TextGenerator("Wrong option selected", ConsoleColor.Red);
            Console.ReadLine();
            continue;
        }
        MenuOptions choice = uiService.MenuChoice[selectedItem - 1];
        switch (choice)
        {
            case MenuOptions.AddNewUser:
                {
                    try
                    {
                        Console.Clear();

                        string username = TextHelper.GetInput("Username: ");
                        string password = TextHelper.GetInput("Password: ");
                        List<string> roles = new List<string>() { "Administrator", "Manager", "Maintenance" };

                        int enumInt = uiService.ChooseMenu(roles);

                        if (enumInt < 0 || enumInt > 2)
                        {
                            TextHelper.TextGenerator("Invalid role selection!", ConsoleColor.Red);
                            break;
                        }

                        Role role = (Role)enumInt;
                        User user = new User(username, password, role);
                        userService.Add(user);

                        TextHelper.TextGenerator("New user added !", ConsoleColor.Green);
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        TextHelper.TextGenerator(ex.Message, ConsoleColor.Red);
                    }
                    break;
                }
            case MenuOptions.RemoveExistingUser:
                {
                    try
                    {
                        Console.Clear();

                        TextHelper.TextGenerator("Select a User for removal (insert number infront of the username):", ConsoleColor.Cyan);

                        var usersForRemoval = userService.GetUsersForRemoval();
                        int selectedUser = uiService.ChooseEntityMenu(usersForRemoval);

                        if (selectedUser == -1)
                        {
                            TextHelper.TextGenerator("Wrong option selected", ConsoleColor.Red);
                            Console.ReadLine();
                            continue;
                        }

                        if (userService.Remove(usersForRemoval[selectedUser - 1].Id))
                        {
                            TextHelper.TextGenerator("User removed !", ConsoleColor.Yellow);
                            Console.ReadLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        TextHelper.TextGenerator(ex.Message, ConsoleColor.Red);
                    }
                    break;
                }
            case MenuOptions.ChangePassword:
                {
                    Console.Clear();

                    string oldPass = TextHelper.GetInput("Insert old password: ");
                    string newPass = TextHelper.GetInput("Insert new password: ");

                    if (userService.ChangePassword(userService.CurrentUser.Id, oldPass, newPass))
                    {
                        TextHelper.TextGenerator("Password changed !", ConsoleColor.Green);
                        Console.ReadLine();
                        continue;
                    }
                    break;
                }
            case MenuOptions.Exit:
                {
                    userService.CurrentUser = null;
                    loopActive = false;
                    break;
                }
        }
    }
}
#endregion

#region Seeding
void InitializeStartingData()
{
    User administrator = new User("BobBobsky", "bobbest1", Role.Administrator);
    User manager = new User("JillWayne", "jillawesome1", Role.Manager);
    User maintenances = new User("GregGregsky", "supergreg1", Role.Maintenance);
    List<User> seedUsers = new List<User>() { administrator, manager, maintenances };
    userService.Seed(seedUsers);

    Car car1 = new Car("Auris (Toyota)", "AFW950", new DateTime(2023, 12, 1));
    Car car2 = new Car("Auris (Toyota)", "CKE480", new DateTime(2021, 10, 15));
    Car car3 = new Car("Transporter (Volkswagen)", "GZDR69", new DateTime(2024, 5, 30));
    Car car4 = new Car("Mondeo (Ford)", "5RIP283", new DateTime(2022, 5, 13));
    Car car5 = new Car("Premier (Peugeot)", "2AR9907", new DateTime(2022, 11, 9));
    Car car6 = new Car("Vito (Mercedes)", "6RND294", new DateTime(2023, 3, 11));
    List<Car> seedCars = new List<Car>() { car1, car2, car3, car4, car5, car6 };
    //carService.Seed(seedCars);

    Driver driver1 = new Driver("Romario", "Walsh", Shift.NoShift, null, "LC12456123", new DateTime(2023, 11, 5));
    Driver driver2 = new Driver("Kathleen", "Rankin", Shift.Morning, car1.Id, "LC54435234", new DateTime(2022, 1, 12));
    Driver driver3 = new Driver("Ashanti", "Mooney", Shift.Evening, car1.Id, "LC65803245", new DateTime(2022, 5, 19));
    Driver driver4 = new Driver("Zakk", "Hook", Shift.Afternoon, car1.Id, "LC20897583", new DateTime(2023, 9, 28));
    Driver driver5 = new Driver("Xavier", "Kelly", Shift.NoShift, null, "LC15636280", new DateTime(2024, 6, 1));
    Driver driver6 = new Driver("Joy", "Shelton", Shift.Evening, car2.Id, "LC47845611", new DateTime(2023, 7, 3));
    Driver driver7 = new Driver("Kristy", "Riddle", Shift.Morning, car3.Id, "LC19006543", new DateTime(2024, 6, 12));
    Driver driver8 = new Driver("Stuart", "Mayer", Shift.Evening, car3.Id, "LC53187767", new DateTime(2023, 10, 10));
    List<Driver> seedDrivers = new List<Driver>() { driver1, driver2, driver3, driver4, driver5, driver6, driver7, driver8 };
    //driverService.Seed(seedDrivers);
}
#endregion