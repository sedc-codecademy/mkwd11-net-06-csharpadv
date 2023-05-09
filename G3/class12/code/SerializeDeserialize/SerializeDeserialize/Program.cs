using Newtonsoft.Json;
using SerializeDeserialize.Models;
using SerializeDeserialize.Services;

string folderPath = @"..\..\..\OurData";
string filePath = Path.Combine(folderPath, "myFirstJson.json");

FileService FileService = new FileService();

// Manual serialziation and deserialization

CustomJsonService JsonService = new CustomJsonService();

Student bob = new Student()
{
    FirstName = "Bob",
    LastName = "Bobski",
    Age = 40,
    IsPartTime = false,
};

// testing serialization
string bobSerialized = JsonService.SerializeStudent(bob);
FileService.WriteFile(filePath, bobSerialized);

// testing deserialization
string jsonStudent = FileService.ReadFile(filePath);
Student bobDeserialized = JsonService.DeserializeStudent(jsonStudent);

// serializing and deserializing using a library (Newtonsoft.Json)

Teacher teacher = new Teacher()
{
    FullName = "Jull Vayne",
    School = "SEDC"
};

//string jullSerialized = JsonService.SerializeStudent(teacher); not working
string jullSerializedNewtonsoft = JsonConvert.SerializeObject(teacher);

string bobSerializedNewtonsoft = JsonConvert.SerializeObject(bob);
FileService.WriteFile(filePath, bobSerializedNewtonsoft);

Student bobDeserializedNewtonsoft = JsonConvert.DeserializeObject<Student>(bobSerializedNewtonsoft);




Console.ReadLine();