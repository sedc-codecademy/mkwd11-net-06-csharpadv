using TaxiManager.DomainModels.Enums;
using TaxiManager.DomainModels.Models;
using TaxiManager.Services.Implementations;

namespace TaxiManager.Services.Interfaces
{
    public interface IUIService
    {
        List<MenuChoice> MenuItems { get; set; }
        User LogInMenu();
        void Welcome(User user);
        int MainMenu(Role role);
        int ChooseMenu<T>(List<T> items);
        int ChooseEntitiesMenu<T>(List<T> entities) where T : BaseEntity;
    }
}
