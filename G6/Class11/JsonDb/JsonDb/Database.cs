using JsonDb.Models;
using Newtonsoft.Json;

namespace JsonDb
{
    public class Database<T> where T : BaseEntity
    {
        //private List<T> _items; we don't want to keep data in memory

        private string _folderPath;
        private string _filePath;
        private int _id;

        public Database()
        {
            _folderPath = @"..\..\..\Database";
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
            List<T> data = ReadFromFile();
            if(data == null)
            {
                //invalid json content or empty json content
                _id = 0;
            }
            else
            {
                if(data.Count > 0)
                {
                    _id = data.Last().Id;
                }
                else
                {
                    _id = 0;
                }
               
            }
        }

        private List<T> ReadFromFile()
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

        private void WriteToFile(List<T> data)
        {
            try
            {
                //because we want to write to json file, we need to serialize list to json and send that json to file
                string jsonData = JsonConvert.SerializeObject(data);
                using (StreamWriter sw = new StreamWriter(_filePath))
                {
                    sw.WriteLine(jsonData);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<T> GetAll()
        {
            List<T> data = ReadFromFile();
            return data;
        }

        public T GetById(int id)
        {
            List<T> data = ReadFromFile();
            return data.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(T item)
        {
            List<T> data = ReadFromFile();
            _id++;
            item.Id = _id;
            data.Add(item);
            WriteToFile(data);
        }

    }


}
