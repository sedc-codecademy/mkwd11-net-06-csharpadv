using SEDC.SerializationDeserialization.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.SerializationDeserialization
{
    public class GetDataHelper
    {
        public static string GetUsers(string url)
        {
            using (HttpClient _client = new HttpClient())
            {
                var res = _client.GetAsync("https://jsonplaceholder.typicode.com/users").Result;
                var content = res.Content.ReadAsStringAsync().Result;
                return content;
            }
        }
    }
}
