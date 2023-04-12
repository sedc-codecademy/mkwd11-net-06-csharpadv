namespace TryBeingFit.Models
{
    public class PremiumUser : StandardUser
    {
        public List<LiveTraining> LiveTrainings { get; set; }

        internal PremiumUser(string firstName, string lastName, string username, string password, string email, string phone) :
            base(firstName, lastName, username, password, email, phone)
        {
            LiveTrainings = new List<LiveTraining>();
        }
        public override string GetInfo()
        {
            return base.GetInfo() + ", Live Training: " + string.Join(", ", LiveTrainings);
        }
    }
}
