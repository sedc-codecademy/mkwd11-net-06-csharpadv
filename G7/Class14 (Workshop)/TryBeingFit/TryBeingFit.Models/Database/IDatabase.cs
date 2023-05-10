namespace TryBeingFit.Models.Database
{
    public interface IDatabase<T> where T : BaseEntity
    {
        //Returns back all the entities from the dataset
        List<T> GetAll();
        //Returns back the entity with the specific id
        T GetById(int id);
        //Creates and inserts new entity in the dataset
        int Insert(T entity);
        //Updates the specific entity inside the dataset
        void Update(T entity);
        //Removes the specific entity from the dataset
        void Remove(T entity);
        //Removes the enetity with specific id from the dateset
        void RemoveById(int id);
    }
}
