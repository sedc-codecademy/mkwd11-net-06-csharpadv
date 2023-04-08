using SEDC.TryBeingFit.Domain.Models;
using System.Collections.Generic;

namespace SEDC.TryBeingFit.Services.Interfaces
{
    public interface ITrainingService<T> where T : Training
    {
        List<T> GetAllTrainings();
        T GetTraining(int id);
        void AddTraining(T training);
    }
}
