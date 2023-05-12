using Newtonsoft.Json;
using TaxiManagerApp9000.DataAccess.Interfaces;
using TaxiManagerApp9000.Domain.Entities;

namespace TaxiManagerApp9000.DataAccess
{
    public class FileSystemDb<T> : IDb<T> where T : BaseEntity
    {
        private string _databaseFolder;
        private string _databasePath;
        private string _idPath;

        public FileSystemDb()
        {
            _databaseFolder = @"..\..\..\DataBase";
            _databasePath = $@"{_databaseFolder}\{typeof(T).Name}s.json";
            _idPath = $@"{_databaseFolder}\{typeof(T).Name}Id.txt";

            if (!Directory.Exists(_databaseFolder))
            {
                Directory.CreateDirectory(_databaseFolder);
            }

            if (!File.Exists(_databasePath))
            {
                File.Create(_databasePath).Close();
            }

            if (!File.Exists(_idPath))
            {
                File.Create(_idPath).Close();
            }
        }

        public int Add(T entity)
        {
            List<T> data = new List<T>();
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
            if (data == null)
            {
                data = new List<T>();
            }

            entity.Id = GenerateId();
            data.Add(entity);
            WriteData(data);

            return entity.Id;
        }

        public List<T> GetAll()
        {
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
        }

        public T GetById(int id)
        {
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd()).FirstOrDefault(x => x.Id == id);
            }
        }

        public bool RemoveById(int id)
        {
            List<T> data = new List<T>();
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
            if (data == null)
            {
                data = new List<T>();
            }

            T item = data.SingleOrDefault(x => x.Id == id);

            if (item != null)
            {
                data.Remove(item);
                WriteData(data);
            }

            return true;
        }

        public bool Update(T entity)
        {
            List<T> data = new List<T>();
            using (StreamReader sr = new StreamReader(_databasePath))
            {
                data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }
            if (data == null)
            {
                data = new List<T>();
            }

            T item = data.SingleOrDefault(x => x.Id == entity.Id);

            if (item != null)
            {
                data[data.IndexOf(item)] = entity;
                WriteData(data);
            }

            return true;
        }

        private void WriteData(List<T> data)
        {
            using (StreamWriter sw = new StreamWriter(_databasePath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
            }
        }

        private int GenerateId()
        {
            int id = 1;
            using (StreamReader sr = new StreamReader(_idPath))
            {
                string currentId = sr.ReadLine();
                if (currentId != null)
                {
                    id = int.Parse(currentId);
                }
            }

            using (StreamWriter sw = new StreamWriter(_idPath))
            {
                sw.WriteLine(id + 1);
            }

            return id;
        }
    }
}
