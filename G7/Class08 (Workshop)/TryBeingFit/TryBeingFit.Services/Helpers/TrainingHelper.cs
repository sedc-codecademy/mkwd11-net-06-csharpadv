using TryBeingFit.Models;

namespace TryBeingFit.Services.Helpers
{
    public static class TrainingHelper
    {
        public static bool IsLiveTraining(this Training training)
        {
            //Because unboxing throws an exception if it does not pass, we need to try to do the unboxing. If it passes, true will be returned, if not, exception will be thrown that we handle in the catch block and return false as result.
            try
            {
                LiveTraining t1 = (LiveTraining)training;
                return true;
            } catch(Exception ex)
            {
                return false;
            }
        }
    }
}
