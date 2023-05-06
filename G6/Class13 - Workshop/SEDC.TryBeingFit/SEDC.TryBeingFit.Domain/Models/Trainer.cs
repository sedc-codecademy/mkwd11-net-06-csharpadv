using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Interfaces;

namespace SEDC.TryBeingFit.Domain.Models
{
    public class Trainer : User, ITrainer
    {
        public int YearsOfExperience { get; set; }

        public Trainer()
        {
            UserType = UserType.Trainer;
        }

        public void Reschedule(LiveTraining liveTraining, int hoursToReschedule)
        {
            //validate if it is his training
            if(liveTraining.Trainer.Username != Username)
            {
                throw new Exception($"Training: {liveTraining.Title} does not belong to {Username}");
            }
            liveTraining.NextSession = liveTraining.NextSession.AddHours(hoursToReschedule);
        }

        public override string GetInfo()
        {
            return $"{FirstName} {LastName} has {YearsOfExperience}";
        }
    }
}
