using SEDC.TryBeingFit.Domain.Enums;

namespace SEDC.TryBeingFit.Domain.Models
{
    //this way it will get inherited members from BaseEntity (because User inherits from BaseEntity) + from User
    public class PremiumUser : User
    {
        public List<VideoTraining> VideoTrainings;
        public LiveTraining LiveTraining;

        public PremiumUser()
        {
            UserType = UserType.PremiumUser;
            VideoTrainings = new List<VideoTraining>();
        }

        public override string GetInfo()
        {
            string info = $"{FirstName} {LastName} \n Video trainings: \n";
            foreach (VideoTraining videoTraining in VideoTrainings)
            {
                info += videoTraining.GetInfo() + "\n";
            }

            info += $"Live training: \n {LiveTraining.GetInfo()} ";
            return info;
        }
    }
}
