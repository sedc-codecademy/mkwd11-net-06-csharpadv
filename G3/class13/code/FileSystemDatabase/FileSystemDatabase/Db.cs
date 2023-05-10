using FileSystemDatabase.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace FileSystemDatabase
{
    public class Db<T> where T : BaseEntity
    {
        private string _dbDirectory;
        private string _dbFile;

        private int _idTracker;

        public Db()
        {
            _dbDirectory = @"..\..\..\Database";
            _dbFile = $@"{_dbDirectory}\{typeof(T).Name}s.json";

            if (!Directory.Exists(_dbDirectory)) 
            {
                Directory.CreateDirectory(_dbDirectory);
            }

            if (!File.Exists(_dbFile)) 
            {
                File.Create(_dbFile).Close();
            }

            List<T> data = Read();

            if (data == null)
            {
                // write with empty list            
            }
            else if (data.Count > 0) 
            {
                _idTracker = data[data.Count - 1].Id;
            }
        }

        private List<T> Read()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_dbFile))
                {
                    string data = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<T>>(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<T>();
            }
        }

        private bool Write(List<T> entites) 
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_dbFile))
                {
                    string data = JsonConvert.SerializeObject(entites);
                    sw.Write(data);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<T> GetAll() 
        {
            return Read();
        }

        public T GetById(int id) 
        {
            List<T> data = Read();
            return data.SingleOrDefault(entity => entity.Id == id);
        }

        public int Insert(T entity) 
        {

        }

        public void ClearDb() 
        {
        }
    
    }
}
