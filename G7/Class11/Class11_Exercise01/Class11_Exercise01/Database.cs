using Newtonsoft.Json;

namespace Class11_Exercise01
{
    public class Database<T> where T : BaseEntity
    {
        private string _folderPath;
        private string _filePath;

        public Database()
        {
            _folderPath = @"..\..\..\Database";
            //typeof gives you the 'metadata' for the class that is send as T, that 'metadata' contains T class Name
            _filePath = _folderPath + $@"\{typeof(T).Name}s.json";

            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
        }

        //reads the content from file, deserialize (converts) the Json content to List of T (C# object)
        private List<T> ReadFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string content = sr.ReadToEnd();
                    List<T> result = JsonConvert.DeserializeObject<List<T>>(content);

                    //if(result == null)
                    //{
                    //    return new List<T>();
                    //}

                    //return result == null ? new List<T>() : result;
                    //return result != null ? result : new List<T>();

                    //Null-coalescing Operator
                    //if result is diffrent than null, it will be return as it is
                    //if result is null than the statement after the ?? will be returned
                    return result ?? new List<T>();
                }
            }
            catch
            {
                throw new Exception("Error happend during file deserialization");
            }
        }

        private void SaveToFile(List<T> items)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_filePath))
                {
                    string jsonContent = JsonConvert.SerializeObject(items);
                    sw.WriteLine(jsonContent);
                }
            }
            catch
            {
                throw new Exception("Error happend during file deserialization");
            }
        }

        public List<T> GetAll()
        {
            return ReadFromFile();
        }

        public T GetById(int id)
        {
            T item = ReadFromFile().FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                throw new Exception($"Entity with id {id} is not found");
            }

            return item;
        }

        //1. Read the content from the file
        //2. Convert it to C# object (structure)
        //3. Modify it (Add new item, Remove item, Update item)
        //4. Convert it as a json format
        //5. Save it (overwrite) the content of the file
        public int Insert(T entity)
        {
            List<T> items = ReadFromFile();
            items.Add(entity);
            SaveToFile(items);
            return entity.Id;
        }

        public void Remove(T entity)
        {
            List<T> items = ReadFromFile();
            T item = items.FirstOrDefault(x => x.Id == entity.Id);

            if (item == null)
            {
                throw new Exception($"Entity with id {entity.Id} is not found");
            }

            items.Remove(item);
            SaveToFile(items);
        }

        public void RemoveById(int id)
        {
            List<T> items = ReadFromFile();
            T item = items.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                throw new Exception($"Entity with id {id} is not found");
            }

            items.Remove(item);
            SaveToFile(items);
        }

        public void Update(T entity)
        {
            List<T> items = ReadFromFile();
            T item = items.FirstOrDefault(x => x.Id == entity.Id);

            if (item == null)
            {
                throw new Exception($"Entity with id {entity.Id} is not found");
            }

            int indexOfElement = items.IndexOf(item);
            items[indexOfElement] = entity;
            SaveToFile(items);
        }
    }
}
