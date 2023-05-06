using SEDC.TryBeingFit.Domain.Enums;

namespace SEDC.TryBeingFit.Domain.Models
{
    public abstract class Training : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Duration { get; set; }
        public TrainingLevel Level { get; set; }
        public Trainer Trainer { get; set; }
    }
}
