using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;

namespace TaxiManager.DataAccess
{
    public class FileSystemDb<T> : IDb<T> where T : BaseEntity
    {
        private string _dbFolder;
        private string _dbPath;
        private string _idPath;

        public FileSystemDb()
        {
            _dbFolder = @"..\..\..\Db";
            _dbPath = $@"{_dbFolder}\{typeof(T).Name}s.json";
            _idPath = $@"{_dbFolder}\id.txt";

            if (!Directory.Exists(_dbFolder))
            {
                Directory.CreateDirectory(_dbFolder);
            }

            if (!File.Exists(_dbPath))
            {
                File.Create(_dbPath).Close();
            }

            if (!File.Exists(_idPath))
            {
                File.Create(_idPath).Close();
            }
        }

        public List<T> GetAll()
        {
            using (StreamReader sr = new StreamReader(_dbPath))
            {
                var result = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());

                if (result == null) 
                {
                    return new List<T>();
                }

                return result;
            }
        }

        public T GetById(int id)
        {
            using (StreamReader sr = new StreamReader(_dbPath))
            {
                return JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd()).SingleOrDefault(entity => entity.Id == id);
            }
        }

        public int Insert(T entity)
        {
            List<T> data = new List<T>();
            using (StreamReader sr = new StreamReader(_dbPath))
            {
                data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }

            if (data == null)
            {
                data = new List<T>();
            }

            entity.Id = GenerateId();
            data.Add(entity);

            WriteData(_dbPath, data);

            return entity.Id;
        }

        public void RemoveById(int id)
        {
            List<T> data = new List<T>();

            using (StreamReader sr = new StreamReader(_dbPath))
            {
                data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }

            T item = data.SingleOrDefault(entity => entity.Id == id);

            if (item != null)
            {
                data.Remove(item);
                WriteData(_dbPath, data);
            }
        }

        public void Update(T item)
        {
            List<T> data = new List<T>();
            using (StreamReader sr = new StreamReader(_dbPath))
            {
                data = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());
            }

            T itemForDelition = data.SingleOrDefault(entity => entity.Id == item.Id);

            if (itemForDelition != null)
            {
                data[data.IndexOf(itemForDelition)] = item;
                WriteData(_dbPath, data);
            }
        }

        private void WriteData(string path, List<T> updatedData)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(JsonConvert.SerializeObject(updatedData));
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
                };
            }
            using (StreamWriter sw = new StreamWriter(_idPath))
            {
                sw.WriteLine(id + 1);
            }
            return id;
        }
    }
}
