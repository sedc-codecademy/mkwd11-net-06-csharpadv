using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services.Implementations
{
    public class UIService : IUIService
    {
        public StandardUser FillRegisterData()
        {
            //ask for data
            
            string firstName = EnterData("first name");
            string lastName = EnterData("last name");
            string username = EnterData("username");
            string password = EnterData("password");
            string confirmedPassword = EnterData("confirm password");

            if(password != confirmedPassword)
            {
                throw new Exception("Passwords do not match");
            }

            //if data is not empty create standard user that would be registered

            StandardUser standardUser = new StandardUser()
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password
            };
            return standardUser;
        }

        public string MainMenu(UserType userType)
        {
            List<string> menuItems = new List<string>();
            menuItems.Add("Account info");
            menuItems.Add("Logout");

            switch (userType)
            {
                case UserType.StandardUser:
                    menuItems.Add("Train");
                    menuItems.Add("Upgrade to premium");
                    break;
                case UserType.PremiumUser:
                    menuItems.Add("Train");
                    break;
                case UserType.Trainer:
                    menuItems.Add("Reschedule a training");
                    break;

            }

            int numInput = 0;

            while (true)
            {
                Console.WriteLine("Choose an option");
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }

                string input = Console.ReadLine();

                bool isNumber = int.TryParse(input, out numInput);
                if (!isNumber)
                {
                    Console.WriteLine("You must enter a number");
                    continue;
                }

                if (numInput < 1 || numInput > menuItems.Count)
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }

                break;
            }

            return menuItems[numInput - 1];

        }


        public void GetChosenTraining<T>(List<T> trainingsFromDB) where T : Training
        {
            //show
            int numInput = 0;
            while (true)
            {
                Console.WriteLine("Choose a training");
                for (int i = 0; i < trainingsFromDB.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {trainingsFromDB[i].Title}");
                }

                string input = Console.ReadLine();

                bool isNumber = int.TryParse(input, out numInput);
                if (!isNumber)
                {
                    Console.WriteLine("You must enter a number");
                    continue;
                }

                if (numInput < 1 || numInput > trainingsFromDB.Count)
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }

                break;
            }


            T chosenTraining = trainingsFromDB[numInput - 1];
            Console.WriteLine("You chose the following training:");
            Console.WriteLine(chosenTraining.GetInfo());
        }

        private string EnterData(string field)
        {
            Console.WriteLine($"Enter {field}");
            string data = Console.ReadLine();
            if (string.IsNullOrEmpty(data))
            {
                throw new Exception($"You must enter {field}");
            }
            return data;
        }
    }
}
