using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.TryBeingFit.Services.Implementations
{
    public class UIService : IUIService
    {
        public List<string> MenuItems { get; set; }
        public int ChooseMenuItem(List<string> menuItems)
        {
            while (true)
            {
                
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menuItems[i]}");
                }
                string input = Console.ReadLine();
                int choice = ValidationHelper.ValidateNumber(input, menuItems.Count);
                if (choice == -1)
                {
                    MessageHelper.PrintMessage("You must enter a valid option", ConsoleColor.Red);
                    continue;
                }
                return choice;
            }

        }

        public StandardUser FillNewUserData()
        {
            StandardUser standardUser = new StandardUser();

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            if (string.IsNullOrEmpty(firstName))
            {
                throw new Exception("You must enter first name");
            }
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            if (string.IsNullOrEmpty(lastName))
            {
                throw new Exception("You must enter last name");
            }

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
            standardUser.FirstName = firstName;
            standardUser.LastName = lastName;
            standardUser.Username = username;
            standardUser.Password = password;

            return standardUser;
        }

        public int LogInMenu()
        {
            List<string> menuItems = new List<string> { "LogIn", "Register" };
            Console.WriteLine("Choose option");
            return ChooseMenuItem(menuItems);
        }

        public int RoleMenu()
        {
            List<string> menuItems = Enum.GetNames(typeof(UserRole)).ToList(); //gets the names of members of UserRole enum
            Console.WriteLine("Choose role");
            return ChooseMenuItem(menuItems);
        }

        public int MainMenu(UserRole userRole)
        {
            MenuItems = new List<string>();
            MenuItems.Add("Account");
            MenuItems.Add("Log Out");

            switch (userRole)
            {
                case UserRole.Standard:
                    MenuItems.Add("Train");
                    MenuItems.Add("Upgrade to Premium");
                    break;
                case UserRole.Premium:
                    MenuItems.Add("Train");
                    break;
                case UserRole.Trainer:
                    MenuItems.Add("Reschedule training");
                    break;
            }
            return ChooseMenuItem(MenuItems);
        }

        public int TrainMenu()
        {
            List<string> trainMenuItems = new List<string>() { "Video", "Live" };
            return ChooseMenuItem(trainMenuItems);
        }

        public int TrainMenuItems<T>(List<T> trainings) where T : Training
        {
            Console.WriteLine("Choose a training:");
            return ChooseEntity(trainings);
        }

        public void UpgradeToPremiumInfo()
        {
            Console.WriteLine("Upgrade to premium offers:");
            Console.WriteLine("* Live trainings");
            Console.WriteLine("* Get discount in sport stores");
        }
        public int AccountMenu()
        {
            List<string> accountMenuItems = new List<string>() { "Change info", "Change password" };
            return ChooseMenuItem(accountMenuItems);
        }
        private int ChooseEntity<T>(List<T> entities) where T: Training
        {
            while (true)
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {entities[i].GetInfo()}");
                }
                string input = Console.ReadLine();
                int choice = ValidationHelper.ValidateNumber(input, entities.Count);
                if (choice == -1)
                {
                    MessageHelper.PrintMessage("You must enter a valid option", ConsoleColor.Red);
                    continue;
                }
                return choice;
            }
        }

        
    }
}
