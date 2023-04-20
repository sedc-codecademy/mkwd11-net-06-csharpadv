using TryBeingFit.Models.Enums;

namespace TryBeingFit.Models
{
    public abstract class Training : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public double Rating { get; set; }
        public TrainingDifficulty Difficulty { get; set; }
        public string Link { get; set; }

        public Training(string title, string description, int duration, double rating, TrainingDifficulty difficulty, string link)
        {
            Title = title;
            Description = description;
            Duration = duration;
            Rating = rating;
            Difficulty = difficulty;
            Link = link;
        }
    }
}
