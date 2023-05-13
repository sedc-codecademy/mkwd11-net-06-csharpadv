using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Enums;
using TaxiManager.Domain.Models;

namespace TaxiManager.Services.Abstraction
{
    public interface IUiService
    {
        User LogInMenu();
        void Welcome(User user);
        int MainMenu(Role role);
    }
}
