using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.SerializationDeserialization.Entities
{
    public class User
    {
        public int Id { get; set; }
        [JsonProperty("name")]
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
