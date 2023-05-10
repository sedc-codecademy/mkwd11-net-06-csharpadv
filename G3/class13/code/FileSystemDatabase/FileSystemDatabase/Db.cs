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
        }

        private List<T> Read()
        {
            using (StreamReader sr = new StreamReader(_dbFile)) 
            {
                string data = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<List<T>>(data);
            }
        }


        public List<T> GetAll() 
        {      
        }

        public T GetById(int id) 
        {
        }

        public int Insert(T entity) 
        {
        }

        public void ClearDb() 
        {
        }
    
    }
}
