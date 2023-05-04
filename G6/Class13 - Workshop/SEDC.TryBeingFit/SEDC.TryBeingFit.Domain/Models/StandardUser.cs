using SEDC.TryBeingFit.Domain.Enums;
using System.Collections.Generic;

namespace SEDC.TryBeingFit.Domain.Models
{
    public class StandardUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public StandardUser()
        {
            Role = UserRole.Standard;
            VideoTrainings = new List<VideoTraining>();
        }
        public override string GetInfo()
        {
            string result = $"{FirstName} {LastName}";
            result += "\n Video trainings: \n";
            foreach (VideoTraining videoTraining in VideoTrainings)
            {
                result += $" {videoTraining.Title} \n";
            }
            return result;
        }
    }
}
