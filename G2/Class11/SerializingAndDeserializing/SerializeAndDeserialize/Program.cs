using Newtonsoft.Json;
using SerializeAndDeserialize.Entities;

string folderPath = "../../../OurData";
string filePath = folderPath + "/ourFile.json";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

void WriteToJson(string json)
{
    using (StreamWriter sw = new StreamWriter(filePath))
    {
        sw.WriteLine(json);
    }
}

void ReadFromJson()
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}

Student zarko = new Student()
{
    FirstName = "Zarko",
    LastName = "Ilievski",
    Age = 40,
    IsPartTime = true
};

string zarkoString = zarko.SerializeStudent();
//WriteToJson(zarkoString);
//ReadFromJson();

//Student deserializedStudent = zarkoString.DeserializeStudent();
//Console.WriteLine(deserializedStudent.FirstName);
//Console.WriteLine(deserializedStudent.LastName);
//Console.WriteLine(deserializedStudent.Age);
//Console.WriteLine(deserializedStudent.IsPartTime.ToString());

//THIS IS HOW WE DO IT
string zareSerializedNewtonsoftJson = JsonConvert.SerializeObject(zarko);
WriteToJson(zareSerializedNewtonsoftJson);

ReadFromJson();

Student zareDeserializedNewtonsoftJson = JsonConvert.DeserializeObject<Student>(zareSerializedNewtonsoftJson);

Console.WriteLine(zareDeserializedNewtonsoftJson.FirstName);
Console.WriteLine(zareDeserializedNewtonsoftJson.LastName);
Console.WriteLine(zareDeserializedNewtonsoftJson.Age);
Console.WriteLine(zareDeserializedNewtonsoftJson.IsPartTime.ToString());