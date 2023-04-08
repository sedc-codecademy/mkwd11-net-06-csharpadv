using SEDC.TryBeingFit.Domain.Interfaces;

namespace SEDC.TryBeingFit.Domain.Models
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
