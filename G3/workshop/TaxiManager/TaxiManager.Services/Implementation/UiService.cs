using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Enums;
using TaxiManager.Domain.Models;
using TaxiManager.Services.Abstraction;
using TaxiManager.Services.Utilities;
using TaxiManager.Services.Utilities.Models;

namespace TaxiManager.Services.Implementation
{
    public class UiService : IUiService
    {
        private List<MenuChoices> _menuItems;
        public List<MenuChoices> MenuItems 
        { 
            get => _menuItems;
            set 
            {
                if (_menuItems != null) 
                {
                    _menuItems.Clear();
                }

                _menuItems = value;
            }
        }

        public User LogInMenu()
        {
            Console.WriteLine("Taxi Manager 9000");
            ExtendedConsole.Separator();
            Console.WriteLine("Log In:");
            string username = ExtendedConsole.GetInput("Username: ");
            string password = ExtendedConsole.GetInput("Password: ");

            var user = new User()
            {
                Username = username,
                Password = password
            };

            return user;
        }
        public void Welcome(User user)
        {
            Console.WriteLine($"Welcome {user.Role} user");
        }
        public int MainMenu(Role role)
        {
            var menuItems = new List<MenuChoices>() { MenuChoices.ChangePassword, MenuChoices.Exit };

            switch (role)
            {
                case Role.Administrator:
                    menuItems = menuItems.Prepend(MenuChoices.RemoveExistingUser).ToList();
                    menuItems = menuItems.Prepend(MenuChoices.AddNewUser).ToList();
                    break;
                case Role.Manager:
                    menuItems = menuItems.Prepend(MenuChoices.ListAllDivers).ToList();
                    menuItems = menuItems.Prepend(MenuChoices.TaxiLicenseStatus).ToList();
                    menuItems = menuItems.Prepend(MenuChoices.DriverManager).ToList();
                    break;
                case Role.Maintenance:
                    menuItems = menuItems.Prepend(MenuChoices.ListAllCars).ToList();
                    menuItems = menuItems.Prepend(MenuChoices.LicensePlateStatuses).ToList();
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
                ExtendedConsole.NoItemsMessage<T>();
                Console.ReadLine();
                return -1;
            }

            while (true) 
            {
                Console.WriteLine("Enter number to choose one of the following: ");

                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {items[i]}");
                }

                int choice = StringValidator.ValidateNumber(Console.ReadLine(), items.Count);

                if (choice == -1) 
                {
                    ExtendedConsole.WriteLine("[Error] Input incorect. Please try again", ConsoleColor.Red);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                return choice;
            }
        }
        public int ChooseEntitiesMenu<T>(List<T> entites) where T : BaseEntity
        {
            Console.Clear();

            if (entites.Count == 0) 
            {
                ExtendedConsole.NoItemsMessage<T>();
                Console.ReadLine();
                return -1;
            }

            while (true) 
            {
                Console.WriteLine("Enter a number to choose one of the following: ");

                for (int i = 0; i < entites.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {entites[i].Print()}");
                }

                int choice = StringValidator.ValidateNumber(Console.ReadLine(), entites.Count);

                if (choice == -1) 
                {
                    ExtendedConsole.WriteLine("[Error] Input incorect. Please try again", ConsoleColor.Red);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                return choice;
            }
        }
    }
}
