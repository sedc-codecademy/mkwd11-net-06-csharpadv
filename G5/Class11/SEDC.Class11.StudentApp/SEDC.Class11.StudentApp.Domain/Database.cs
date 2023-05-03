using Newtonsoft.Json;
using SEDC.Class11.StudentApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class11.StudentApp.Domain
{
    public class Database<T> where T : BaseEntity
    {
        //private List<T> _items; we don't want to keep data in memory
        private string _folderPath;
        private string _filePath;
        private int _id;


        public Database()
        {
            _folderPath = @"..\..\..\DataBase";
            // ..\..\..\Database\Students.json
            // ..\..\..\Database\Subjects.json
            _filePath = _folderPath + $@"\{typeof(T).Name}s.json";

            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }

            //read from json file and if there are records, take the last id
            List<T> data = Reader();

            if(data.Count > 0)
            {
                _id = data.Last().Id;
            }
            else
            {
                _id = 0;
            }
        }

        public List<T> Reader()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string data = sr.ReadToEnd();
                    //if the content is empty, no data in the json file, deserializtion will fail
                    return JsonConvert.DeserializeObject<List<T>>(data);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public void Writer(List<T> data)
        {
            try
            {
                //because we want to write to json file, we need to serialize list to json and send that json to file
                using (StreamWriter sw = new StreamWriter(_filePath))
                {
                    string jsonData = JsonConvert.SerializeObject(data);
                    sw.WriteLine(jsonData);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public List<T> GetAll()
        {
            List<T> data = Reader();
            return data;
        }

        public T GetById(int id)
        {
            List<T> data = Reader();
            return data.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(T item)
        {
            List<T> data = Reader();
            _id++;
            item.Id = _id;
            data.Add(item);
            Writer(data);
        }
    }
}
