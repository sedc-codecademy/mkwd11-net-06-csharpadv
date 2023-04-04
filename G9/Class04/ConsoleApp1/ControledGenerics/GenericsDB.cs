using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControledGenerics
{
    public class GenericsDB<T> where T : BaseEntity
    {
        public static List<T> List { get; set; } = 
            new List<T>();


        public T GetById(int id)
        {
            return List.Single(x=>x.Id==id);
        }

        public void Add(T entity)
        {
            List.Add(entity);
        }

        public static void Remove(int id)
        {
            T ent = List.Single(x => x.Id == id);
            
            if (ent != null)            
            {
                List.Remove(ent);
            }
           
        }

        public static void PrintAll ()
        {
            foreach (T item in List)
            {
                item.GetInfo();
            }
        }

       


    }
}
