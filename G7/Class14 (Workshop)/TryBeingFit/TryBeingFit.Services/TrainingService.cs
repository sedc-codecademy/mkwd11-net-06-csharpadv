using TryBeingFit.Models;
using TryBeingFit.Models.Database;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interface;

namespace TryBeingFit.Services
{
    public class TrainingService : ITrainingService
    {
        public IDatabase<Training> _trainingDatabase;

        public TrainingService(IDatabase<Training> trainingDatabase)
        {
            _trainingDatabase = trainingDatabase;
        }

        public void AddTraining(Training training)
        {
            if(string.IsNullOrEmpty(training.Title) || training.Title.Length < 3)
            {
                throw new ArgumentException("Invalid data for title");
            }

            if(training.Duration < 5)
            {
                throw new ArgumentException("Invalid data for duration, it should be more than 5 mins");
            }

            if(training.Rating < 1 || training.Rating > 5)
            {
                throw new ArgumentOutOfRangeException("Invalid data for rating, it should be between 1 and 5");
            }

            if(string.IsNullOrEmpty(training.Link) || training.Link.Length < 5)
            {
                throw new ArithmeticException("Invalid data for link");
            }

            if (training.IsLiveTraining())
            {
                LiveTraining l = (LiveTraining)training;

                if(l.NextSession < DateTime.Now)
                {
                    throw new ArgumentException("Invalid data for next session, it should be in future");
                }

                if(l.Trainer == null)
                {
                    throw new ArgumentException("Invalid data for trainer");
                }
            }

            _trainingDatabase.Insert(training);
        }

        public void RemoveTraining(Training training)
        {
            //_trainingDatabase.Remove(training);
            _trainingDatabase.RemoveById(training.Id);
        }

        public void RescheduleTraining(Trainer trainer, LiveTraining liveTraining, DateTime newDate)
        {
            if(DateTime.Now > newDate)
            {
                throw new ArgumentException("Invalid data, new scheduled date should be in future");
            }

            LiveTraining updatedTraining = trainer.RescheduleTraining(liveTraining, newDate);
            _trainingDatabase.Update(updatedTraining);
        }
    }
}
