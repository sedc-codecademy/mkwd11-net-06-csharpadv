using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Implementations;
using SEDC.TryBeingFit.Services.Interfaces;
using System;

namespace SEDC.TryBeingFit.App
{
    class Program
    {
        //Added reference to SEDC.TryBeingFit.Services
        //each service has its own database
        public static ITrainingService<VideoTraining> _videoTrainingService = new TrainingService<VideoTraining>();
        public static ITrainingService<LiveTraining> _liveTrainingService = new TrainingService<LiveTraining>();

        public static IUserService<Trainer> _trainerService = new UserService<Trainer>();
        static void Main(string[] args)
        {
            _videoTrainingService.AddTraining(new VideoTraining()
            {
                Title = "Abs workout",
                Description = "Abs workout made easy",
                Difficulty = TrainingDifficulty.Easy,
                Link = "someLink",
                Rating = 3,
                Time = 15.55
            });
            _videoTrainingService.AddTraining(new VideoTraining()
            {
                Title = "Cardio",
                Description = "Dance cardio",
                Difficulty = TrainingDifficulty.Medium,
                Link = "someLink",
                Rating = 5,
                Time = 25
            });

            _liveTrainingService.AddTraining(new LiveTraining() {

                Title = "Cardio",
                Description = "Dance cardio",
                Difficulty = TrainingDifficulty.Medium,
                NextSession = DateTime.Now.AddDays(1),
                Trainer = new Trainer() { FirstName = "Paul" , LastName = "Berner"},
                Rating = 5,
                Time = 25

            });

            _trainerService.ChangePassword(1, "123", "456");

        }
    }
}
