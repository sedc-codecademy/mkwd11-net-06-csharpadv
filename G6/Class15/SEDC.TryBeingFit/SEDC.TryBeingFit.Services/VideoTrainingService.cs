using SEDC.TryBeingFit.Domain.Database;
using SEDC.TryBeingFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services
{
    public class VideoTrainingService : IVideoTrainingService
    {
        private Database<VideoTraining> _database;

        public void Add(VideoTraining videoTraining)
        {
            throw new NotImplementedException();
        }

        public List<VideoTraining> GetAllVideoTrainings()
        {
            return _database.GetAll(); ;
        }
    }
}
