using SEDC.SerializationDeserialization;
using SEDC.SerializationDeserialization.Entities;
using SEDC.SerializationDeserialization.FileSystemHelper;

string folderPath = @"..\..\..\OurData";
string filePath = folderPath + @"\myFirstJson.json";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}


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