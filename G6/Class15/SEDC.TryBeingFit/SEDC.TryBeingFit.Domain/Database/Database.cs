using SEDC.TryBeingFit.Domain.DbInterfaces;
using SEDC.TryBeingFit.Domain.Models;

namespace SEDC.TryBeingFit.Domain.Database
{
    //for each Entity we must have the CRUD operations available (CRUD -> Create, Read, Update, Delete)
    //Database<T> : IDatabase<T> -> class Database inherits and must implement methods defined in interface IDatabase
    //T : BaseEntity -> class Database can work with entities (classes) that inherit from BaseEntity, we can only use it
    // like this: Database<Trainer>, Database<VideoTraining> etc. but not like this Database<bool> -> bool doesn't inherit
    //from BaseEntity
    public class Database<T> : DbInterfaces.IDatabase<T> where T : BaseEntity
    {
        private List<T> _items { get; set; }
        private int _id;
        public Database()
        {
            _items = new List<T>();
            _id = 1;
        }
        public int Add(T entity)
        {
            //first we assign the _id value to entity.Id, then we increment the _id
            entity.Id = _id++;
            _items.Add(entity);
            Console.WriteLine($"Item with id {entity.Id} added");

            return entity.Id;
        }

        public List<T> GetAll()
        {
            return _items;
        }

        public T GetById(int id)
        {
            T item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                throw new Exception($"Item with id {id} was not found");
            }
            return item;
        }

        public void RemoveById(int id)
        {
            //first we must check if there is an item in the list with the given id
            T item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                throw new Exception($"Item with id {id} was not found");
            }
            _items.Remove(item);
            Console.WriteLine($"Item with id {id} was removed");
        }

        public void Update(T entity) //entity is always a ready object, validated, and holds all the new data
        {
            //first we must check if there is an item in the list with the given id
            T item = _items.FirstOrDefault(x => x.Id == entity.Id);
            if (item == null)
            {
                throw new Exception($"Item with id {entity.Id} was not found");
            }
            //first way
            item = entity;
        }
    }
}
