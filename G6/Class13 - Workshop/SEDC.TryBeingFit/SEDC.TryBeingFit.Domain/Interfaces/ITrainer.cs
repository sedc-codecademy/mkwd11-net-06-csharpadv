using SEDC.TryBeingFit.Domain.Models;

namespace SEDC.TryBeingFit.Domain.Interfaces
{
    public interface ITrainer
    {
        void Reschedule(LiveTraining liveTraining, int days);
    }
}
