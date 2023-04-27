using Generics.Entities;

namespace Generics.Services
{
    public class PersonService<T> : IPersonService<T> where T : BaseEntity
    {
        public void Print(T entity)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            if(typeof(T) == typeof(Female))
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }

            if (typeof(T) == typeof(Male))
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            Console.WriteLine("Hello guys.");
            Console.WriteLine("This is an example for generics");
            Console.WriteLine($"Hello this is {entity.FullName}");
            Console.WriteLine("We use this method for both entities\n\n\n");

            Console.ResetColor();
        }
    }
}
