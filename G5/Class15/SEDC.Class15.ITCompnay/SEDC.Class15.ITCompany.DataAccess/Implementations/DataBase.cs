using Newtonsoft.Json;
using SEDC.Class15.ITCompany.DataAccess.Interface;
using SEDC.Class15.ITCompnay.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class15.ITCompany.DataAccess.Implementations
{
    public class DataBase<T> : IDataBase<T> where T : BaseEntity
    {
        private string _folderPath;
        private string _filePath;
        private int _id;

        public DataBase()
        {
            _id = 0;
            _folderPath = @"..\..\..\DataBase";
            _filePath = _folderPath + $@"\{typeof(T).Name}s.json";

            if (!Directory.Exists(_folderPath)) Directory.CreateDirectory(_folderPath);

            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
                Writer(new List<T>());
            }
        }

        public void Writer(List<T> dbEntities)
        {
            using(StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(dbEntities));
            }
        }
        public List<T> Reader()
        {
            using(StreamReader sr = new StreamReader(_filePath))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
        }
        public void Delete(int id)
        {
            List<T> dbEntities = Reader();
            T entityDb = dbEntities.FirstOrDefault(x => x.Id == id);
            if(entityDb == null)
            {
                throw new Exception($"The entity with id {id} does not exists!");
            }
            dbEntities.Remove(entityDb);
            Writer(dbEntities);
        }

        public List<T> GetAll()
        {
            return Reader();
        }

        public T GetById(int id)
        {
            List<T> dbEntities = Reader();
            return dbEntities.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(T entity)
        {
            List<T> dbEntities = Reader();
            if(dbEntities == null)
            {
                dbEntities = new List<T>();
                _id = 1;
            }
            if(dbEntities.Count == 0)
            {
                _id = 1;
            }
            else
            {
                _id = dbEntities.Count + 1;
            }
            entity.Id = _id;
            dbEntities.Add(entity);
            Writer(dbEntities);
            return entity.Id;

        }

        public void Update(T entity)
        {
            List<T> dbEntities = Reader();
            T updatedEntity = dbEntities.FirstOrDefault(x=>x.Id == entity.Id);
            if(updatedEntity == null)
            {
                throw new Exception($"The entity with id {entity.Id} does not exists!");
            }
            dbEntities[dbEntities.IndexOf(updatedEntity)] = entity;
            Writer(dbEntities);
        }

        
    }
}
