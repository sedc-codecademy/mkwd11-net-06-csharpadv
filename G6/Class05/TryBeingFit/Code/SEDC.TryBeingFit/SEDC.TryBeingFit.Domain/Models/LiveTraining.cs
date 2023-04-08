using SEDC.TryBeingFit.Domain.Interfaces;
using System;

namespace SEDC.TryBeingFit.Domain.Models
{
    public class LiveTraining : Training, ILiveTraining
    {
        public DateTime NextSession { get; set; }
        public Trainer Trainer { get; set; }

        public override string GetInfo()
        {
           return $"{Title} - {Description}, lasts: {Time}, trainer: {Trainer.GetInfo()}";
        }

        public int HoursToNextSession()
        {
            return (NextSession - DateTime.Now).Hours;
        }
    }
}
