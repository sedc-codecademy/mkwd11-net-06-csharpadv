using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Domain.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
