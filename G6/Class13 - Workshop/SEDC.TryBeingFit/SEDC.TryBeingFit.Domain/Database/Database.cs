using SEDC.TryBeingFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.TryBeingFit.Domain.Database
{
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        private List<T> _table { get; set; }
        public int Id { get; set; }

        public Database()
        {
            _table = new List<T>();
            Id = 1;
        }
        public List<T> GetAll()
        {
            return _table;
        }

        public T GetbyId(int id)
        {
            T dbEntity = _table.FirstOrDefault(x => x.Id == id);
            if(dbEntity == null)
            {
                throw new Exception($"Entity with id {id} not found");
            }
            return dbEntity;
        }

        public int Insert(T entity)
        {
            //we set the Id property of the entity and then we increment the Id property of the database
            //the Id of the entity is first zero, before we assign value to it
            entity.Id = Id++;
            _table.Add(entity);
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            //first we search if the entity we want to delete exists
            T dbEntity = _table.FirstOrDefault(x => x.Id == id);
            if (dbEntity == null)
            {
                throw new Exception($"Entity with id {id} not found");
            }
            _table.Remove(dbEntity);
        }

        public void Update(T entity)
        {
            //first we search if the entity we want to update exists
            T dbEntity = _table.FirstOrDefault(x => x.Id == entity.Id);
            if (dbEntity == null)
            {
                throw new Exception($"Entity with id {entity.Id} not found");
            }
            //if it exists update to the object with the new values
            dbEntity = entity;
        }
    }
}
