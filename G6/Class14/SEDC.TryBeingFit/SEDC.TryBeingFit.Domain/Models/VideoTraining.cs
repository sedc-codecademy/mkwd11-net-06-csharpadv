using SEDC.TryBeingFit.Domain.Interfaces;

namespace SEDC.TryBeingFit.Domain.Models
{
    public class VideoTraining : Training, IVideoTraining
    {
        public double Rating { get; set; }
        public string Link { get; set; }

        public override string GetInfo()
        {
            return $"{Title}, you can watch it on the following Link {Link}. Duration: {Duration}, Rating: {Rating}";
        }

        //we should be able to update the rating
        public void UpdateRating(int grade)
        {
            Rating = (Rating + grade) / 2;
        }
    }
}
