using SEDC.TryBeingFit.Domain.Enums;

namespace SEDC.TryBeingFit.Domain.Models
{
    public abstract class Training : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Time { get; set; }
        public TrainingDifficulty Difficulty { get; set; }
        public double Rating { get; set; }
    }
}
