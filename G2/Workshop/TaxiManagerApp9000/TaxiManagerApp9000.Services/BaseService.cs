using TaxiManagerApp9000.DataAccess;
using TaxiManagerApp9000.DataAccess.Interfaces;
using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Services.Interfaces;

namespace TaxiManagerApp9000.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private IDb<T> Db;

        public BaseService()
        {
            Db = new FileSystemDb<T>(); //HERE I TELL THE BASE SERVICE PROPERTY WITH THE NAME DB, that it will be of type FileSystemDb and with that I will be able to use all the Generic method inside of this service and the FileSystemDb !!!
        }

        public bool Add(T entity) //This adds the new entity to the Db, it can be USER/DRIVER/CAR
        {
            try
            {
                Db.Add(entity); //This here is a reference to the Add method in what ? IN THE FILESYSTEMDB !!!
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //The same from the previous comments goes for all the methods !!!

        public List<T> GetAll()
        {
            return Db.GetAll();
        }

        public T GetById(int id)
        {
            return Db.GetById(id);
        }

        public bool Remove(int id)
        {
            return Db.RemoveById(id);
        }

        //THIS IS JUST FOR SEEDING DATA, i need some data to begin with so i'll just put some in !!!
        public void Seed(List<T> items)
        {
            List<T> data = Db.GetAll();
            if (data != null && data.Count > 0)
            {
                return;
            }

            items.ForEach(x => Db.Add(x));
        }
    }
}
