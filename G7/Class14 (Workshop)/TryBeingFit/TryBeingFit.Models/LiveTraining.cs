using TryBeingFit.Models.Enums;

namespace TryBeingFit.Models
{
    public class LiveTraining : Training
    {
        public DateTime NextSession { get; set; }
        public Trainer Trainer { get; set; }

        public LiveTraining(string title, string description, int duration, double rating, TrainingDifficulty difficulty, string link, DateTime firstSession, Trainer trainer)
            : base(title, description, duration, rating, difficulty, link)
        {
            NextSession = firstSession;
            Trainer = trainer;
        }

        public override string GetInfo()
        {
            return $"[{Id}] {Title} - {Description}, duration: {Duration} min. difficulty: {Difficulty}, starts at: {NextSession.ToString("dd.MM.yyyy HH:mm")}, link: {Link}";
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
