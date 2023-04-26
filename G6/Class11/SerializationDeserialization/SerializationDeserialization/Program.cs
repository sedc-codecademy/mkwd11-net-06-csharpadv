using Newtonsoft.Json;
using SerializationDeserialization;

string folderPath = @"..\..\..\Example";
string filePath = @"..\..\..\Example\jsonFile.json";

Student student = new Student()
{
    FirstName = "Marko",
    LastName = "Petrovski",
    Age = 30,
    IsPartTime = false
};

CustomReaderWriter readerWriter = new CustomReaderWriter();
if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

//1. serialize student object to JSON

//using our own Serializer
string jsonStudent = CustomSerializer.SerializeStudent(student);


//2. write JSON string to file
readerWriter.WriteToFile(filePath, jsonStudent);

//3. read json from file

string jsonFromFile = readerWriter.ReadFromFile(filePath);

//4. parse the read json

Student parsedStudent = CustomSerializer.DeserializeStudent(jsonFromFile);



//USING NewtonsoftJSON
//we need the library (package) from nuget package manager

Student anotherStudent = new Student()
{
    FirstName = "Ana",
    LastName = "Petrovska",
    Age = 32,
    IsPartTime = true
};

//1. serialize
string jsonString = JsonConvert.SerializeObject(anotherStudent);

//2.write to file
readerWriter.WriteToFile(filePath, jsonString);

//3. read from file
string jsonFileContent = readerWriter.ReadFromFile(filePath);

//4. parse the json content
Student studentAna = JsonConvert.DeserializeObject<Student>(jsonFileContent);


List<int> integers = new List<int> { 5, 7, 8, 8 };

string jsonList = JsonConvert.SerializeObject(integers);

List<int> parsedIntegers = JsonConvert.DeserializeObject<List<int>>(jsonList);

Console.ReadLine();