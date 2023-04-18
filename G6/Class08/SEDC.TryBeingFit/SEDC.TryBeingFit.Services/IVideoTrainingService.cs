using SEDC.TryBeingFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services
{
    //example of specific interface, when you don't use generics, because the logic for both types of trainings differs
    public interface IVideoTrainingService
    {
        void Add(VideoTraining videoTraining);
    }
}
