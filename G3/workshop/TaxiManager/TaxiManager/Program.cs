﻿using TaxiManager.Domain.Enums;
using TaxiManager.Domain.Models;
using TaxiManager.Services.Abstraction;
using TaxiManager.Services.Implementation;
using TaxiManager.Services.Utilities;

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

    Console.ReadLine();
}


void InitializeStartingData() 
{
    User easyAdministrator = new User("test", "123", Role.Administrator);
    User administrator = new User("BobBobsky", "bobbest1", Role.Administrator);
    User manager = new User("JillWayne", "jillawesome1", Role.Manager);
    User maintenances = new User("GregGregsky", "supergreg1", Role.Maintenance);
    List<User> seedUsers = new List<User>() { easyAdministrator, administrator, manager, maintenances };
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