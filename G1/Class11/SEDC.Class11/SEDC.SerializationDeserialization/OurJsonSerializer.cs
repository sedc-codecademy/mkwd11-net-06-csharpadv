using SEDC.SerializationDeserialization.Entities;

namespace SEDC.SerializationDeserialization
{
    public static class OurJsonSerializer
    {
        public static string SerializeStudent(Student student)
        {
            string json = "{";
            json += $"\"FirstName\" : \" {student.FirstName}\",";
            json += $"\"LastName\" : \"{student.LastName}\",";
            json += $"\"Age\" : \"{student.Age}\",";
            json += $"\"IsPartTime\" : \"{student.IsPartTime}\"";
            json += "}";
            return json;
        }

        public static Student DeserializeStudent(string json)
        {
            // The process
            // 0. {"FirstName" : " Bob","LastName" : "Bobsky","Age" : "25","IsPartTime" : "False"}
            // 1. "FirstName" : " Bob","LastName" : "Bobsky","Age" : "25","IsPartTime" : "False"
            //  1.1
            // FirstName : Bob,
            // LastName : Bobsky,
            // Age : 25,
            // IsPartTime : False,
            // 2. 
            // Key: FirstName, Value: Bob
            // Key: LastName, Value: Bobsky
            // Key: Age, Value: 25
            // Key: IsPartTime, Value: False

            // properties => {FirstName : Bob}, {LastName : Bobsky}

            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

            string[] properties = content.Split(',');

            Dictionary<string, string> propsDictionary = new Dictionary<string, string>();

            foreach (var prop in properties)
            {
                string[] pair = prop.Split(":");
                propsDictionary.Add(pair[0].Trim(), pair[1].Trim()); // "Bob"
            }

            Student student = new Student()
            {
                FirstName = propsDictionary["FirstName"],
                LastName = propsDictionary["LastName"],
                Age = int.Parse(propsDictionary["Age"]),
                IsPartTime = bool.Parse(propsDictionary["IsPartTime"])
            };

            return student;
        }
    }
}
