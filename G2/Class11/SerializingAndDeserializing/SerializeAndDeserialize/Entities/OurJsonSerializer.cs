namespace SerializeAndDeserialize.Entities
{
    public static class OurJsonSerializer
    {
        public static string SerializeStudent(this Student student)
        {
            string json = "{";
            json += $"\"FirstName\":\"{student.FirstName}\",";
            json += $"\"LastName\":\"{student.LastName}\",";
            json += $"\"Age\":\"{student.Age}\",";
            json += $"\"IsPartTime\":\"{student.IsPartTime.ToString().ToLower()}\"";
            json += "}";

            return json;
        }

        public static Student DeserializeStudent(this string json)
        {
            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\"", "");

            string[] properties = content.Split(",");

            Dictionary<string, string> propertiesDictionary =
                new Dictionary<string, string>();

            foreach (string property in properties)
            {
                string[] pair = property.Split(':');
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
