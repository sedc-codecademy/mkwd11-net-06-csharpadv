using SEDC.SerializationDeserialization;
using SEDC.SerializationDeserialization.Entities;
using SEDC.SerializationDeserialization.FileSystemHelper;
using Newtonsoft.Json;
using System.Xml;

string folderPath = @"..\..\..\OurData";
string filePath = folderPath + @"\myFirstJson.json";
string filePath1 = folderPath + @"\NewtonsoftJsonData.json";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

#region Custom Serialization/Deserialization
Student bob = new Student()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 25,
    IsPartTime = false
};


string jsonResult = OurJsonSerializer.SerializeStudent(bob);
ReaderWriter.WriteFile(filePath, jsonResult);

string fileContent = ReaderWriter.ReadFile(filePath);
Student deserializedStudent = OurJsonSerializer.DeserializeStudent(fileContent);

Console.WriteLine("============ SERIALIZATION ==============");
Console.WriteLine(jsonResult);


Console.WriteLine("============ DESERIALIZATION ==============");
Console.WriteLine(deserializedStudent.FirstName);
#endregion



#region NewtonsoftJson serialization/deserialization

Student student = new Student()
{
    FirstName = "Martin",
    LastName = "Panovski",
    Age = 29,
    IsPartTime = false
};

//string jsonStudent = JsonConvert.SerializeObject(student);

//ReaderWriter.WriteFile(filePath1, jsonStudent);

string jsonData = ReaderWriter.ReadFile(filePath1);
Student deserializedStudent1 = JsonConvert.DeserializeObject<Student>(jsonData);
Console.WriteLine(deserializedStudent1.FirstName + " " + deserializedStudent1.LastName);


string usersJson = GetDataHelper.GetUsers("https://jsonplaceholder.typicode.com/users");

List<User> users = JsonConvert.DeserializeObject<List<User>>(usersJson);

users.ForEach(x => Console.WriteLine($"{x.FullName} - {x.Email}"));


#endregion