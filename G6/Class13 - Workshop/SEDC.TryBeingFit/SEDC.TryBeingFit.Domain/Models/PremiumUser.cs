using SEDC.TryBeingFit.Domain.Enums;
using System.Collections.Generic;

namespace SEDC.TryBeingFit.Domain.Models
{
    public class PremiumUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public LiveTraining LiveTraining { get; set; }
        public PremiumUser()
        {
            Role = UserRole.Premium;
            VideoTrainings = new List<VideoTraining>();
        }
        public override string GetInfo()
        {
            string liveTrainingMessage = LiveTraining == null ? " no live training" : LiveTraining.Title;
            return $"{FirstName} {LastName}, num. of video trainings {VideoTrainings.Count}, live training: {liveTrainingMessage}";
        }
    }
}
