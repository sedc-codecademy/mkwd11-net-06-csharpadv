using SEDC.TryBeingFit.Domain.Enums;

namespace SEDC.TryBeingFit.Domain.Models
{
    //this way it will get inherited members fromBaseEntity (because User inherits from BaseEntity) + from User
    public class StandardUser : User
    {
        List<VideoTraining> VideoTrainings { get; set; }

        public StandardUser()
        {
            UserType = UserType.StandardUser;
            //avoid null
            VideoTrainings = new List<VideoTraining>();
        }

        public override string GetInfo()
        {
            string info = $"{FirstName} {LastName} \n Video trainings: \n";
            foreach(VideoTraining videoTraining in VideoTrainings)
            {
                info += videoTraining.GetInfo() + "\n";
            }
            return info;
        }
    }
}
