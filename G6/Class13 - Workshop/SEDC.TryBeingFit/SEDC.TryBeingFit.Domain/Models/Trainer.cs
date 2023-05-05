using SEDC.TryBeingFit.Domain.Enums;
using SEDC.TryBeingFit.Domain.Interfaces;

namespace SEDC.TryBeingFit.Domain.Models
{
    public class Trainer : User, ITrainer
    {
        public int YearsOfExperience { get; set; }

        public Trainer()
        {
            Role = UserRole.Trainer;
        }
        public override string GetInfo()
        {
            return $"{FirstName} {LastName} - {YearsOfExperience} years of experience";
        }

        public void Reschedule(LiveTraining liveTraining, int days)
        {
            liveTraining.NextSession = liveTraining.NextSession.AddDays(days);
        }
    }
}
