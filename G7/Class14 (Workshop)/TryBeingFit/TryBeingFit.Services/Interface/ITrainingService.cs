using TryBeingFit.Models;

namespace TryBeingFit.Services.Interface
{
    public interface ITrainingService
    {
        void AddTraining(Training training);
        void RemoveTraining(Training training);
        void RescheduleTraining(Trainer trainer, LiveTraining liveTraining, DateTime newDate);
        LiveTraining GetLiveTraining(int trainingSessionId);
        List<VideoTraining> GetAllVideoTrainings();
        List<LiveTraining> GetAllLiveTrainings();
    }
}
