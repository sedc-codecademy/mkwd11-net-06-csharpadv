namespace TryBeingFit.Models.Database
{
    // ltDatabase = new Database<LiveTraining>();
    // LiveTraining l1 = new LiveTraingin....;
    // ltDatabase.Insert(l1);
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        private List<T> _dataset { get; set; }

        public Database()
        {
            _dataset = new List<T>();
        }

        public List<T> GetAll()
        {
            return _dataset;
        }

        public T GetById(int id)
        {
            T item = _dataset.FirstOrDefault(x => x.Id == id);

            if(item == null)
            {
                throw new Exception($"Entity with id {id} is not found");
            }

            return item;
        }

        public int Insert(T entity)
        {
            _dataset.Add(entity);
            return entity.Id;
        }

        public void Remove(T entity)
        {
            T item = _dataset.FirstOrDefault(x => x.Id == entity.Id);

            if (item == null)
            {
                throw new Exception($"Entity with id {entity.Id} is not found");
            }

            _dataset.Remove(item);
        }

        public void RemoveById(int id)
        {
            T item = _dataset.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                throw new Exception($"Entity with id {id} is not found");
            }

            _dataset.Remove(item);
        }

        //Program.cs;
        //lv = ltDatabase.GetById(2); => {2, "Jump and Jacks", 30 }
        //lv.Duration = 60;
        //ltDatabase.Update(lv) => {2, "Jump and Jacks", 60 }
        public void Update(T entity)
        {
            //firstly find the item in the list
            //original value => {2, "Jump and Jacks", 30 }
            T item = _dataset.FirstOrDefault(x => x.Id == entity.Id);

            if (item == null)
            {
                throw new Exception($"Entity with id {entity.Id} is not found");
            }

            //if the item exists, then by changing its value in the varaible, we are changing the list item;
            //originalValue = {2, "Jump and Jacks", 60 }
            int indexOfElement = _dataset.IndexOf(item);
            _dataset[indexOfElement] = entity;
        }
    }
}
