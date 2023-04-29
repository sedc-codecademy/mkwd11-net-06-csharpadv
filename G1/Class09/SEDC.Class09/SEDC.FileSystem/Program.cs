#region Directory manipulation


string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);

string appPath = @"..\..\..\";
//bool isFolderExists = Directory.Exists($"{appPath}/Demo1");

if (!Directory.Exists($"{appPath}/Demo1"))
{
    Directory.CreateDirectory($"{appPath}/Demo1");
}
else
{
    Console.WriteLine($"Folder with Demo1 name exists!");
}

//if (Directory.Exists($"{appPath}/Demo1"))
//{
//    Directory.Delete($"{appPath}/Demo1");
//}
//else
//{
//    Console.WriteLine("There is no such folder! Maybe it's been deleted so far!");
//}


bool isFolderExistsOnAbsolutPath = Directory.Exists("D:\\SEDC\\2022-2023\\CSharp - Advanced\\Code\\mkwd11-net-06-csharpadv\\G1\\Class09\\SEDC.Class09\\SEDC.FileSystem\\Demo1");
if (!isFolderExistsOnAbsolutPath)
{
    Directory.CreateDirectory(@"D:\SEDC\2022-2023\CSharp - Advanced\Code\mkwd11-net-06-csharpadv\G1\Class09\SEDC.Class09\SEDC.FileSystem\Demo1");
}
else
{
    Console.WriteLine($"Folder with Demo1 name exists!");
}


var names = Directory.EnumerateDirectories(appPath);
var fileNamesInDirectory = Directory.GetFiles(appPath);
foreach (string name in names)
{ Console.WriteLine(name); }

Console.WriteLine("==================================");
foreach (string name in fileNamesInDirectory)
{ Console.WriteLine(name); }



#endregion


#region File manipulation

string folderPath = Path.Combine(appPath, @"Demo1\");
string filePath = $"{folderPath}/text.txt";


if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
    File.WriteAllText(filePath, "I will be firstly written!\n");
    Console.WriteLine("A file was created!");
}
else
{
    Console.WriteLine(@"File on path \Demo1 already exists!");
}


// How to write some text in a already created file
if (File.Exists(filePath))
{
    File.AppendAllLines(filePath, new List<string> { "Hello SEDC! This is the second line in the file", "And this will be third line"});
    Console.WriteLine("Successfully written in a file!");
}
Console.ReadLine();


Console.WriteLine("========================");

string fileContent = File.ReadAllText(filePath);
Console.WriteLine("Here it is what you stored in the text.txt file:");
Console.WriteLine(fileContent);

// Make sure to check if a file exists before deleting it!
//File.Delete(filePath);


//File.Move(filePath, $@"{appPath}/text.txt");



#endregion