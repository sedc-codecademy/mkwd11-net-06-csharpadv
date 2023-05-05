using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Models;
using System.Collections.Generic;

namespace SEDC.TryBeingFit.Services.Interfaces
{
    public interface IUIService
    {
        List<string> MenuItems { get; set; }
        int ChooseMenuItem(List<string> menuItems);
        int LogInMenu();
        int RoleMenu();
        StandardUser FillNewUserData();
        int MainMenu(UserRole userRole);
        int TrainMenu();
        int TrainMenuItems<T>(List<T> trainings) where T : Training;
        void UpgradeToPremiumInfo();
        int AccountMenu();
    }
}
