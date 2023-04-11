using TryBeingFit.Models.Enums;

namespace TryBeingFit.Models
{
    public class VideoTraining : Training
    {
        public VideoTraining(string title, string description, int duration, double rating, TrainingDifficulty difficulty, string link)
            : base(title, description, duration, rating, difficulty, link)
        {
        }

        public override string GetInfo()
        {
            return $"{Title} - {Description}, duration: {Duration} min. difficulty: {Difficulty}, link: {Link}";
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
