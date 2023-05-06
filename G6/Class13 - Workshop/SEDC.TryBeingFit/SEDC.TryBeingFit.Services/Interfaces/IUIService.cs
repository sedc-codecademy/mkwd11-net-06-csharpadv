using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services.Interfaces
{
    public interface IUIService
    {
        StandardUser FillRegisterData();

        string MainMenu(UserType userType);

        void GetChosenTraining<T>(List<T> trainingsFromDB) where T : Training;


    }
}
