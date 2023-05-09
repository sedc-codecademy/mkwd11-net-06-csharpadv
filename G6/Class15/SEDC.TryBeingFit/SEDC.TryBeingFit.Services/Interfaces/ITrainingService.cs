using SEDC.TryBeingFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services.Interfaces
{
    public interface ITrainingService<T> where T : Training
    {
        void AddTraining(T newTraining);

        List<T> GetAll();

        T GetChosenTraining();

        T ChangeInfo(T training);
    }
}
