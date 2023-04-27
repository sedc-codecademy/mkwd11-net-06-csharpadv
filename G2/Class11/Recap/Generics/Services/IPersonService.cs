using Generics.Entities;

namespace Generics.Services
{
    public interface IPersonService<T> where T : BaseEntity
    {
        void Print(T entity);
    }
}
