using SEDC.Class02.Exercises1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class02.Exercises1.Entities
{
    public abstract class User : IUser
    {
        public User(int id, string name, string userName, string password)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Password = password;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set ; }
        public string Password { get; set; }

        public virtual void PrintUser()
        {
            Console.WriteLine($"{Id} {Name} {UserName}");
        }
    }
}
