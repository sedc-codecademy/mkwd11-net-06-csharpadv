using SEDC.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Domain.Models
{
    public class LiveTraining : Training, ILiveTraining
    {
        public DateTime NextSession { get; set; }

        public override string GetInfo()
        {
            return $"{Title} - {Description}, duration: {Duration}, Trainer: {Trainer.FirstName} {Trainer.FirstName}";
        }

        //we must be able to find out how many hours are left to the next session of each Live Training
        public int HoursToNextSession()
        {
            return (NextSession - DateTime.Now).Hours;
        }
    }
}
