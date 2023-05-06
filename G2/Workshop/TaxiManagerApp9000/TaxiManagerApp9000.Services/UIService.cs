using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Domain.Enums;
using TaxiManagerApp9000.Helpers;
using TaxiManagerApp9000.Services.Interfaces;

namespace TaxiManagerApp9000.Services
{
    public class UIService : IUIservice
    {
        private List<MenuOptions> _menuOptions;

        public List<MenuOptions> MenuChoice
        {
            get => _menuOptions;
            set
            {
                if (_menuOptions != null)
                {
                    _menuOptions.Clear();
                }

                _menuOptions = value;
            }
        }

        public int ChooseEntityMenu<T>(List<T>? entities) where T : BaseEntity
        {
            int selectedEntityId = -1;
            try
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    TextHelper.TextGenerator($"{i + 1}) {entities[i].Print()}", ConsoleColor.Cyan);
                }

                int selected = StringHelper.ValidateNumber(Console.ReadLine(), entities.Count);
                if (selected == -1)
                {
                    return selectedEntityId;
                }
                selectedEntityId = selected;
            }
            catch (Exception ex)
            {
                TextHelper.TextGenerator(ex.Message, ConsoleColor.Red);
            }

            return selectedEntityId;
        }

        public int ChooseMenu<T>(List<T> items)
        {
            int selectedId = -1;
            try
            {
                Console.Clear();
                TextHelper.TextGenerator("Please insert the ID of the element you want to choose:", ConsoleColor.Cyan);
                for (int i = 0; i < items.Count; i++)
                {
                    TextHelper.TextGenerator($"{i + 1}) {items[i]}", ConsoleColor.Cyan);
                }

                selectedId = StringHelper.ValidateNumber(Console.ReadLine(), items.Count);
            }
            catch (Exception ex)
            {
                TextHelper.TextGenerator(ex.Message, ConsoleColor.Red);
            }

            return selectedId;
        }

        public User LogIn()
        {
            TextHelper.TextGenerator("Taxi Manager 9000", ConsoleColor.Cyan);
            TextHelper.Separator();
            TextHelper.TextGenerator("Log in", ConsoleColor.Cyan);

            string username = TextHelper.GetInput("Username: ");
            string password = TextHelper.GetInput("Password: ");

            return new User(username, password);
        }

        public int MainMenu(Role role)
        {
            List<MenuOptions> menuItems = new List<MenuOptions>() { MenuOptions.ChangePassword, MenuOptions.Exit };

            switch (role)
            {
                case Role.Administrator:
                    menuItems = menuItems.Prepend(MenuOptions.RemoveExistingUser).ToList();
                    menuItems = menuItems.Prepend(MenuOptions.AddNewUser).ToList();
                    break;
                case Role.Manager:
                    menuItems = menuItems.Prepend(MenuOptions.DriverManager).ToList();
                    menuItems = menuItems.Prepend(MenuOptions.TaxiLicenseStatus).ToList();
                    menuItems = menuItems.Prepend(MenuOptions.ListAllDrivers).ToList();
                    break;
                case Role.Maintenance:
                    menuItems = menuItems.Prepend(MenuOptions.ListAllCars).ToList();
                    menuItems = menuItems.Prepend(MenuOptions.LicensePlateStatus).ToList();
                    break;
            }

            MenuChoice = menuItems;
            return ChooseMenu(menuItems);
        }
    }
}
