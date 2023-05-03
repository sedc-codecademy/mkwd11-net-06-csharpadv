# Serializing and Deserialization🍘🍙

## The basics🔹

We can build object-oriented C# applications with the C# structure, classes, collections, and objects. But when we need to transfer that data somewhere we run into a problem. We can't really transfer the objects as C# objects and even if we could, the other system or destination may not be able to understand the structure of the data. Therefore we need to send or save the information in some understandable format for both sides. The same goes for receiving information. That is why we need to convert our data before we can do any communicate with it.

### Serialization

Serialization is the process of converting our data that is written and structured in the C# language into a data type that can easily be sent to another system, saved somewhere, and easily understood. In our case, we can convert the data to a JSON file. Although in our case we are using C# and converting to JSON, serialization as a process is not exclusive to these types. Serialization can be done in almost any language that is used for web development and can convert into things other than JSON such as XML.

### Deserializaiton

Deserialization is the reverse process of Serialization. It converts a data type that is widely used, easily transported, and understood by many systems into a more specific and complex one. This means that with this system we can convert a data type into our native C# structure such as objects, collections, etc. So if we accept a JSON we can convert it to our native C# code, even though the code on the other side was maybe written in another language. Deserialization, as serialization is not exclusive to C# and JSON and can be used in different languages and with different data types for conversion.

### Uses

Serialization and Deserialization are very commonly used when building web applications. They are used to convert HTTP request payloads that come in and out of our applications. They can also be used for converting data into XML or JSON and storing the data on the file system. We can store configurations or some local data changes into our file system this way. Since we are not using any databases at the moment for this subject, these features can be used to even simulate a database on the file system. The database will be JSON files and we will serialize the data each time we want to read from the database and deserialize when we want to write in it. With this, there is a possibility to create a console application that can save data even when the application is closed and re-opened again.

### Manually serialize and deserialize objects

It is not easy to deserialize and serialize manually. We have to parse the string that we get, take out the important values, and map them to the correct properties. We need to do the same process in reverse as well for the deserialization. This can take a lot of effort, so there are already built libraries that do this for us.

#### Manually serialize/deserialize a Student class

```csharp
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool IsPartTime { get; set; }
}
```

```csharp
// Serializes only a student object 
public string SerializeStudent(Student student)
{
    string json = "{";
    json += $"\"FirstName\" : \"{student.FirstName}\",";
    json += $"\"LastName\" : \"{student.LastName}\",";
    json += $"\"Age\" : \"{student.Age}\",";
    json += $"\"IsPartTime\" : \"{student.IsPartTime.ToString().ToLower()}\"";
    json += "}";
    return json;
}

// Deserializes only student object
public Student DeserializeStudent(string json)
{
    // Cleaning the json
    string content = json
        .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
        .Replace("\r", "")
        .Replace("\n", "")
        .Replace("\"", "");
    string[] properties = content.Split(',');

    // Creating dictionary with clean keys( properties ) and values
    Dictionary<string, string> propertiesDictionary =
        new Dictionary<string, string>();
    foreach (string property in properties)
    {
        string[] pair = property.Split(':');
        propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
    }

    // Creating a Student object with the values from the dictionary
    Student student = new Student();
    student.FirstName = propertiesDictionary["FirstName"];
    student.LastName = propertiesDictionary["LastName"];
    student.Age = int.Parse(propertiesDictionary["Age"]);
    student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]);

    return student;
}
```

## NuGet 🔹

Package managers are a very useful tool in a developer's toolset. It helps with picking the right library, tracking the version, installing and uninstalling the library at any time. We already covered the NPM package manager for JavaScript. C# also has a package manager of its own. That is the NuGet package manager. This package manager is built in Visual Studio so that we can easily manage our packages directly from our solution and project. All we need to do is right-click on our project and go **Manage NuGet Packages**. There we can see all the installed packages, their versions and we can browse through new packages and install them with one click.

## Newtonsoft.Json 🔹

One of the most famous libraries for serialization and deserialization in C# is the Newtonsoft.Json library. We can add it from the NuGet package manager to our project very easily. This library gives us the option to automatically serialize and deserialize stuff without much configuration and settings. We can even configure the properties, their mapping as well as what happens when an object is serialized or deserialized.

### Serialization Example

```csharp
Student bob = new Student()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 40,
    IsPartTime = false
};
string bobSerialized = JsonConvert.SerializeObject(bob);
```

### Deserialization Example

```csharp
Student bobDeserialized = JsonConvert.DeserializeObject<Student>(bobSerialized);
```

## Extra Materials 📘

* [Microsoft - Serialization](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization)
* [Newtonsoft.Json Documentation](https://www.newtonsoft.com/json/help/html/Introduction.htm)
* [Channel9 - Learn Nuget](https://channel9.msdn.com/Series/NuGet-101/?&WT.mc_id=EducationalNuget-c9-niner)
