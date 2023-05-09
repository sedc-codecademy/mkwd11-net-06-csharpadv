namespace TryBeingFit.Services.Interface
{
    public interface IUserTrainingService
    {
        void AddTrainingSessionToUser(int userId, int trainingId);
    }
}
