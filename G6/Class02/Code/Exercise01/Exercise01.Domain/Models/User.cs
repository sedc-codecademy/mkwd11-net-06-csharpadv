using Exercise01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Models
{
    //We can't instantiate objects
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(int id, string name, string username, string password)
        {
            //todo validation
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }

        public abstract void PrintUser();
    }
}
