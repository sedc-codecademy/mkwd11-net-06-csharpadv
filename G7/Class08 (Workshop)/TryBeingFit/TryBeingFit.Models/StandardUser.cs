using TryBeingFit.Models.Enums;

namespace TryBeingFit.Models
{
    public class StandardUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }

        public StandardUser(string firstName, string lastName, string username, string password, string email, string phone)
            : base(firstName, lastName, username, password, UserRole.Standard, email, phone)
        {
            VideoTrainings = new List<VideoTraining>();
        }

        public override string GetInfo()
        {
            string videoTrainings = VideoTrainings.Count == 0 ? "/" : string.Join(", ", VideoTrainings);
            return $"{FullName} ({Email}), Video Trainings: " + videoTrainings;
        }

        public PremiumUser UpgradeToPremiumUser()
        {
            PremiumUser premiumUser = new PremiumUser(FirstName, LastName, Username, Password, Email, Phone);
            premiumUser.UserRole = UserRole.Premium;
            premiumUser.Id = Id;

            return premiumUser;
        }
    }
}
