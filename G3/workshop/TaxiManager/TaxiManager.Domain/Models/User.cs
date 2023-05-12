using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Enums;

namespace TaxiManager.Domain.Models
{
    public class User : BaseEntity
    {      
        private string _username;
        public string Username 
        { 
            get => _username; 
            set => _username = value.ToLower(); 
        }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User() { }
        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public override string Print()
        {
            return $"{Username} with the role {Role}";
        }
    }
}
