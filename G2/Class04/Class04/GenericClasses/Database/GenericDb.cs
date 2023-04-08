using GenericClasses.Entities;

namespace GenericClasses.Database
{
    public static class GenericDb<T> where T : BaseEntity
    {
        public static List<T> Db;

        static GenericDb()
        {
            Db = new List<T>();
        }

        public static void PrintAll()
        {
            foreach (T item in Db)
            {
                item.GetInfo();
            }
        }

        public static void Insert(T item)
        {
            Db.Add(item);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"The item {item.GetType().Name} was added to the GenericDb.");
            Console.ResetColor();
        }

        public static T GetById(int id) => Db.FirstOrDefault(x => x.Id == id);
    }
}
