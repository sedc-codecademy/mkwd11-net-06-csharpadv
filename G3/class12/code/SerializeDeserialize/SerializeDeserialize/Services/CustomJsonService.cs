using SerializeDeserialize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDeserialize.Services
{
    public class CustomJsonService
    {
        public string SerializeStudent(Student student) 
        {
            string json = "{";
            json += $"\"FirstName\": \"{student.FirstName}\",";
            json += $"\"LastName\": \"{student.LastName}\",";
            json += $"\"Age\": \"{student.Age}\",";
            json += $"\"IsPartTime\": \"{student.IsPartTime.ToString().ToLower()}\"";
            json += "}";

            return json;
        }

        public Student DeserializeStudent(string json) 
        {
            //var jsonCount = json.Count();
            //var first = json.IndexOf("{") + 1;
            //var last = json.IndexOf("}") - 1;

            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\n", "")
                .Replace("\"", "");

            string[] properties = content.Split(",");

            Dictionary<string, string> propertiesDictionary 
                = new Dictionary<string, string>();

            foreach (string property in properties) 
            {
                string[] pair = property.Split(":");
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            Student student = new Student();
            student.FirstName = propertiesDictionary["FirstName"];
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["Age"]);
            student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]);

            return student;
        }
    }
}
