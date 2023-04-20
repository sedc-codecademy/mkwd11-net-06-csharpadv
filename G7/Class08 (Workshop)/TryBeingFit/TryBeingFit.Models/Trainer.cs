using TryBeingFit.Models.Enums;

namespace TryBeingFit.Models
{
    public class Trainer : User
    {
        public int YearsOfExperience { get; set; }
        public string Note { get; set; }
        public List<LiveTraining> LiveTrainings { get; set; }

        public Trainer(string firstName, string lastName, string username, string password, string email, string phone, int yearOfExperience, string note)
            : base(firstName, lastName, username, password, UserRole.Trainer, email, phone)
        {
            YearsOfExperience = yearOfExperience;
            Note = note;
            LiveTrainings = new List<LiveTraining>();
        }

        public override string GetInfo()
        {
            string note = string.IsNullOrEmpty(Note) ? "/" : Note;
            return $"{FirstName} {LastName} ({Email}/{Phone}), years of experience: {YearsOfExperience}, note: {note}";            
        }

        public LiveTraining RescheduleTraining(LiveTraining training, DateTime dateTime)
        {
            if(!LiveTrainings.Any(x => x.Id == training.Id))
            {
                throw new Exception("You cannot reschedule this training session, because is not yours");
            }

            training.NextSession = dateTime;
            return training;
        }
    }
}
