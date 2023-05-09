using Newtonsoft.Json;
using SEDC.TryBeingFit.Domain.DbInterfaces;
using SEDC.TryBeingFit.Domain.Models;

namespace SEDC.TryBeingFit.Domain.Database
{
    public class FileDatabase<T> : IDatabase<T> where T : BaseEntity
    {
        private string _folderPath;
        private string _filePath;
        private int _id;

        public FileDatabase()
        {
            _folderPath = @"..\..\..\Database";
            _filePath = _folderPath + @$"\{typeof(T).Name}s.json";

            //if file exists read all records and set the id
            if (File.Exists(_filePath))
            {
                List<T> dbEntities = ReadEntitiesFromFile();
                if(dbEntities.Any())
                {
                    _id = dbEntities.Last().Id;
                }
                else
                {
                    _id = 0;
                }
            }
            else
            {
                //if file does not exist
                _id = 0;
            }

            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
                WriteEntitiesToFile(new List<T>());
            }
        }

        public int Add(T entity)
        {
            //first increment _id, then assign it to entity.Id
            entity.Id = ++_id;
            List<T> dbEntities = ReadEntitiesFromFile();
            dbEntities.Add(entity);

            //write to file
            WriteEntitiesToFile(dbEntities);
            return _id;
        }

        public List<T> GetAll()
        {
           return ReadEntitiesFromFile();
        }

        public T GetById(int id)
        {
            List<T> dbEntities = ReadEntitiesFromFile();
            return dbEntities.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveById(int id)
        {
            List<T> dbEntities = ReadEntitiesFromFile();
            T entityForRemove = dbEntities.FirstOrDefault(x => x.Id == id);
            if(entityForRemove == null)
            {
                throw new Exception($"Entity with id {id} was not found.");
            }

            dbEntities.Remove(entityForRemove);
            WriteEntitiesToFile(dbEntities);
        }

        public void Update(T entity)
        {
            List<T> dbEntities = ReadEntitiesFromFile();
            T entityForUpdate = dbEntities.FirstOrDefault(x => x.Id == entity.Id);
            if (entityForUpdate == null)
            {
                throw new Exception($"Entity with id {entity.Id} was not found.");
            }

            int index = dbEntities.IndexOf(entityForUpdate);
            dbEntities[index] = entity;

            WriteEntitiesToFile(dbEntities);
        }


        private List<T> ReadEntitiesFromFile()
        {
            //read the content from file
            string content = "";

            using (StreamReader reader = new StreamReader(_filePath))
            {
                content = reader.ReadToEnd();
            }

            //try to deserialize into a list
            List<T> result = JsonConvert.DeserializeObject<List<T>>(content);
            return result;
        }

        private void WriteEntitiesToFile(List<T> entities)
        {
            using(StreamWriter writer = new StreamWriter(_filePath))
            {
                //serialize
                string newContent = JsonConvert.SerializeObject(entities);

                //write
                writer.WriteLine(newContent);
            }
        }

    }
}


