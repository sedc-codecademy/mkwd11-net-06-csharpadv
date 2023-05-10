using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBeingFit.Models;
using TryBeingFit.Models.Database;
using TryBeingFit.Services.Helpers;
using TryBeingFit.Services.Interface;

namespace TryBeingFit.Services
{
    public class UserTrainingService : IUserTrainingService
    {
        private IDatabase<User> _userDatabase;
        private IDatabase<Training> _trainingDatabase;

        public UserTrainingService(IDatabase<User> userDatabase, IDatabase<Training> trainingDatabase)
        {
            _userDatabase = userDatabase;
            _trainingDatabase = trainingDatabase;
        }

        public void AddTrainingSessionToUser(int userId, int trainingId)
        {
            User u = _userDatabase.GetById(userId);
            Training training = _trainingDatabase.GetById(trainingId);

            if (u.UserRole == Models.Enums.UserRole.Standard)
            {
                if (training.IsLiveTraining())
                {
                    throw new Exception("Standard user cannot select Live Training session, please choose a video training session.");
                }

                StandardUser standardUser = (StandardUser)u;
                VideoTraining videoTraining = (VideoTraining)training;

                if (standardUser.VideoTrainings.Any(x => x.Id == videoTraining.Id))
                {
                    throw new Exception($"{standardUser.FullName} is already assgined to {videoTraining.Title} training session");
                }

                standardUser.VideoTrainings.Add(videoTraining);
                _userDatabase.Update(standardUser);
            }

            if (u.UserRole == Models.Enums.UserRole.Premium)
            {
                PremiumUser premiumUser = (PremiumUser)u;

                if (training.IsLiveTraining())
                {
                    LiveTraining liveTraining = (LiveTraining)training;

                    if (premiumUser.LiveTrainings.Any(x => x.Id == liveTraining.Id))
                    {
                        throw new Exception($"{premiumUser.FullName} is already assgined to {liveTraining.Title} training session");
                    }

                    premiumUser.LiveTrainings.Add(liveTraining);
                }
                else
                {
                    VideoTraining videoTraining = (VideoTraining)training;

                    if (premiumUser.VideoTrainings.Any(x => x.Id == videoTraining.Id))
                    {
                        throw new Exception($"{premiumUser.FullName} is already assgined to {videoTraining.Title} training session");
                    }

                    premiumUser.VideoTrainings.Add(videoTraining);
                }

                _userDatabase.Update(premiumUser);
            }

            if(u.UserRole == Models.Enums.UserRole.Trainer)
            {
                throw new Exception("Trainers account cannot be assgined as a participant to training session. The trainer can be instructor of the session");
            }
        }
    }
}
