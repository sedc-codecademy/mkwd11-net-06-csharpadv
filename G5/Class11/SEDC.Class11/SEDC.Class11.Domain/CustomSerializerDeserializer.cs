using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class11.Domain
{
    public static class CustomSerializerDeserializer
    {
        //Serializer

        //{ "FisrtName": "Angel", "LastName":"Mitrov", ...}

        public static string SerializerStudent(Student student)
        {
            string json = "{";
            json += $"\"FirstName\" : \"{student.FirstName}\",";
            json += $"\"LastName\" : \"{student.LastName}\",";
            json += $"\"Age\" : \"{student.Age}\",";
            json += $"\"IsLazy\" : \"{student.IsLazy.ToString().ToLower()}\"";
            json +=  "}";

            return json;
        }

        //Deserilizer

        public static Student DeserializerStudent(string json)
        {
            string content = 
                json.Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r\n", "")
                .Replace("\"","");

            string[] properties = content.Split(',');

            // Creating dictionary with clean keys( properties ) and values

            Dictionary<string,string> propertiesKeyValue = new Dictionary<string, string>();

            foreach(string property in properties)
            {
                string[] pair = property.Split(':');
                propertiesKeyValue.Add(pair[0].Trim(), pair[1].Trim());
            }

            // Creating a Student object with the values from the dictionary
            Student student = new Student();
            student.FirstName = propertiesKeyValue["FirstName"];
            student.LastName = propertiesKeyValue["LastName"];
            student.Age = int.Parse(propertiesKeyValue["Age"]);
            student.IsLazy = bool.Parse(propertiesKeyValue["IsLazy"]);

            return student;
        }
    }
}
