using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Enums;
using TaxiManager.Domain.Models;
using TaxiManager.Services.Utilities.Models;

namespace TaxiManager.Services.Abstraction
{
    public interface IUiService
    {
        public List<MenuChoices> MenuItems { get; set; }
        User LogInMenu();
        void Welcome(User user);
        int MainMenu(Role role);
        int ChooseEntitiesMenu<T>(List<T> entites) where T : BaseEntity;
    }
}
