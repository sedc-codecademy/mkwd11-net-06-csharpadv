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
            return new Student();
        }
    }
}
