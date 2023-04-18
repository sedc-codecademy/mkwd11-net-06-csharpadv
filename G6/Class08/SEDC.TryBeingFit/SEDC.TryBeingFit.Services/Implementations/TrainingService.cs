using SEDC.TryBeingFit.Domain.Database;
using SEDC.TryBeingFit.Domain.DbInterfaces;
using SEDC.TryBeingFit.Domain.Models;
using SEDC.TryBeingFit.Services.Helpers;
using SEDC.TryBeingFit.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services.Implementations
{
    public class TrainingService<T> : ITrainingService<T> where T : Training
    {
        //Service communicates with db
        private Domain.DbInterfaces.IDatabase<T> _database;

        public TrainingService()
        {
            _database = new Domain.Database.IDatabase<T>();
        }
        public void AddTraining(T newTraining)
        {
            //1. validation
            if (string.IsNullOrEmpty(newTraining.Title))
            {
                throw new Exception("Title can not be empty");
            }
            if (!ValidationHelper.ValidateTrainingDuration(newTraining.Duration))
            {
                throw new Exception("Duration must be at least 10 minutes");
            }
            if(newTraining.Trainer == null)
            {
                throw new Exception("Each training must have a trainer");
            }


            //2. insert into db
            _database.Add(newTraining);
        }
    }
}
