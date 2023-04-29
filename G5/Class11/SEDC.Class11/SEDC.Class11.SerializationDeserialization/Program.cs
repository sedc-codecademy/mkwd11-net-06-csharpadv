using Newtonsoft.Json;
using SEDC.Class11.Domain;

string folderPath = @"..\..\..\DataBase";
string filePath = @"..\..\..\DataBase\jsonFile.json";


Student student = new Student()
{
    FirstName = "Mitko",
    LastName = "Veljusliev",
    Age = 39,
    IsLazy = false
};

ReaderWriter readerWriter = new ReaderWriter();

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}


if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}


//Custom Serializer

//1. serialize student object to JSON
//string jsonStudent = CustomSerializerDeserializer.SerializerStudent(student);

//2. write JSON string to file
//readerWriter.Writer(filePath, jsonStudent);


//Custom Deserializer

//3. read json from file
//string jsonFromFile = readerWriter.Reader(filePath);

//4. parse the read json
//Student deserializerStudent = CustomSerializerDeserializer.DeserializerStudent(jsonFromFile);

//Console.WriteLine(deserializerStudent.FirstName + " " + deserializerStudent.LastName+ " " + deserializerStudent.Age + " " +  deserializerStudent.IsLazy);



// USING NEWTONSOFRT.JSON
Student studentNewtonSoft = new Student()
{
    FirstName = "Dimitar",
    LastName = "Milkovski",
    Age = 27,
    IsLazy = false
};


// NewtonSoft Serializer
//we need the library (package) from nuget package manager

//1. serialize student object to JSON
string jsonString = JsonConvert.SerializeObject(new List<Student>() { student,studentNewtonSoft});

//string jsonStringOneStudent = JsonConvert.SerializeObject(studentNewtonSoft);

//2. write JSON string to file
readerWriter.Writer(filePath,jsonString);

// NewtonSoft Deserializer
//3. read json from file
string jsonFileContent = readerWriter.Reader(filePath);

//4. parse the read json
List<Student> studentList = JsonConvert.DeserializeObject<List<Student>>(jsonFileContent);

//Student oneStudent = JsonConvert.DeserializeObject<Student>(jsonFileContent);