using Newtonsoft.Json;

namespace Class11_DatabaseJsonDemo
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

            if(!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if(!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
        }

        //reads the content from file, deserialize (converts) the Json content to List of T (C# object)
        private List<T> ReadFromFile()
        {
            try
            {
                using(StreamReader sr = new StreamReader(_filePath))
                {
                    string content = sr.ReadToEnd();
                    List<T> result = JsonConvert.DeserializeObject<List<T>>(content);

                    return result;
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

        public int Insert(T entity)
        {
            ReadFromFile().Add(entity);
            return entity.Id;
        }

        public void Remove(T entity)
        {
            T item = ReadFromFile().FirstOrDefault(x => x.Id == entity.Id);

            if (item == null)
            {
                throw new Exception($"Entity with id {entity.Id} is not found");
            }

            ReadFromFile().Remove(item);
        }

        public void RemoveById(int id)
        {
            T item = ReadFromFile().FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                throw new Exception($"Entity with id {id} is not found");
            }

            ReadFromFile().Remove(item);
        }

        public void Update(T entity)
        {
            T item = ReadFromFile().FirstOrDefault(x => x.Id == entity.Id);

            if (item == null)
            {
                throw new Exception($"Entity with id {entity.Id} is not found");
            }

            int indexOfElement = ReadFromFile().IndexOf(item);
            ReadFromFile()[indexOfElement] = entity;
        }
    }
}
