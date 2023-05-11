using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.DomainModels.Enums;
using TaxiManager.DomainModels.Models;
using TaxiManager.Services.Interfaces;
using TaxiManager.Services.Utils;

namespace TaxiManager.Services.Implementations
{
    public class UIService : IUIService
    {
        public List<MenuChoice> MenuItems { get; set; }


        public void Welcome(User user)
        {
            Console.WriteLine($"Welcome {user.Role} user!");
        }

        public User LogInMenu()
        {
            Console.WriteLine("Taxi Manager 9000");
            ConsoleExtensions.Separator();
            Console.WriteLine("Log In:");
            string? username = ConsoleExtensions.GetInput("Username:");
            string? password = ConsoleExtensions.GetInput("Password:");
            return new User
            {
                Username = username,
                Password = password
            };
        }

        public int MainMenu(Role role)
        {
            var menuItems = new List<MenuChoice>() { MenuChoice.ChangePassword, MenuChoice.Exit };
            switch (role)
            {
                case Role.Administrator:
                    menuItems = menuItems.Prepend(MenuChoice.AddNewUser).ToList();
                    menuItems = menuItems.Prepend(MenuChoice.RemoveExistingUser).ToList();
                    break;
                case Role.Manager:
                    menuItems = menuItems.Prepend(MenuChoice.ListAllDrivers).ToList();
                    menuItems = menuItems.Prepend(MenuChoice.TaxiLicenseStatus).ToList();
                    menuItems = menuItems.Prepend(MenuChoice.DriverManager).ToList();
                    break;
                case Role.Maintenence:
                    menuItems = menuItems.Prepend(MenuChoice.ListAllCars).ToList();
                    menuItems = menuItems.Prepend(MenuChoice.LicensePlateStatus).ToList();
                    break;
            }
            MenuItems = menuItems;
            return ChooseMenu(menuItems);
        }

        public int ChooseMenu<T>(List<T> items)
        {
            Console.Clear();
            if (items.Count == 0)
            {
                ConsoleExtensions.NoItemsMessage<T>();
                Console.ReadLine();
                return -1;
            }
            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following:");
                for (int i = 0; i < items.Count; i++)
                {
                    // 1. AddNewUser
                    // 2. RemoveExistingUser
                    // 3. ChangePassword
                    // 4. Exit
                    Console.WriteLine($"{i + 1}. {items[i]}");
                }
                int choice = StringValidator.ValidNumber(Console.ReadLine(), items.Count);
                if (choice == -1)
                {
                    ConsoleExtensions.WriteLine("[Error] Input incorrect. Please try again!", ConsoleColor.Red);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                return choice;
            }
        }

        public int ChooseEntitiesMenu<T>(List<T> entities) where T : BaseEntity
        {
            Console.Clear();
            if (entities.Count == 0)
            {
                ConsoleExtensions.NoItemsMessage<T>();
                Console.ReadLine();
                return -1;
            }
            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following:");
                for (int i = 0; i < entities.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {entities[i].Print()}");
                }
                int choice = StringValidator.ValidNumber(Console.ReadLine(), entities.Count);
                if (choice == -1)
                {
                    ConsoleExtensions.WriteLine("[Error] Input incorrect. Please try again!", ConsoleColor.Red);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                return choice;
            }
        }

    }

    public enum MenuChoice
    {
        AddNewUser,
        RemoveExistingUser,
        ListAllDrivers,
        ListAllCars,
        TaxiLicenseStatus,
        LicensePlateStatus,
        DriverManager,
        ChangePassword,
        Exit
    }

    public enum DriverManagerChoice
    {
        AssignDriver,
        UnassignDriver
    }

}
