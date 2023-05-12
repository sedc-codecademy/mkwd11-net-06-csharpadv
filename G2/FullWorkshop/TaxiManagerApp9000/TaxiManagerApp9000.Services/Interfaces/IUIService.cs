using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Domain.Enums;

namespace TaxiManagerApp9000.Services.Interfaces
{
    public interface IUIService
    {
        List<MenuOptions> MenuChoice { get; set; }

        User LogIn();

        int MainMenu(Role role);

        int ChooseMenu<T>(List<T> item);

        int ChooseEntityMenu<T>(List<T>? entities) where T : BaseEntity;
    }
}
