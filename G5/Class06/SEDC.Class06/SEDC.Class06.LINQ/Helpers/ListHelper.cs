using SEDC.Class06.Domain.Entities;
using System.Threading.Channels;

namespace SEDC.Class06.LINQ.Helpers
{
    public static class ListHelper
    {
        public static void PrintEntities<T>(this List<T> list) where T : BaseEntity
        {
            Console.WriteLine();

            Console.WriteLine($"Printing {list[0].GetType().Name}s...");
            list.ForEach(x => Console.WriteLine(x.Info()));
        }

        public static void PrintSimple<T>(this List<T> list)
        {
            Console.WriteLine();

            Console.WriteLine("Printing...");
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
