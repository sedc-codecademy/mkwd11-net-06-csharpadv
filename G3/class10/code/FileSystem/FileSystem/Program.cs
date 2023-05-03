string currentDirectory = Directory.GetCurrentDirectory();
string appPath = @"..\..\..\";

//FOLDER MANIPULATION

//Check if folder exists
//relative path 
bool myFolderExists = Directory.Exists(appPath + "myFolder");
bool myFolder2Exists = Directory.Exists(appPath + "myFolder2");

//absolute path
bool myFolderExistAbsolute = Directory.Exists(@"C:\Users\viceb\Desktop\mkwd11-net-06-csharpadv\G3\class10\code\FileSystem\FileSystem\myFolder");

Console.WriteLine($"Does myFolder exists: {myFolderExists}");
Console.WriteLine($"Does myFolder2 exists: {myFolder2Exists}");

string newFolder = Path.Combine(appPath, "newFolder");
Console.WriteLine($"Does newFolder exists before: {Directory.Exists(newFolder)}");

//Create new folder
if (!Directory.Exists(newFolder)) 
{
    Directory.CreateDirectory(newFolder);
    Console.WriteLine("New folder was created!");
}

Console.WriteLine($"Does newFolder exists before: {Directory.Exists(newFolder)}");

//Delete a folder

//Console.WriteLine("press enter to delete newFolder..");
//Console.ReadLine();

//if (Directory.Exists(newFolder)) 
//{
//    Directory.Delete(newFolder);
//    Console.WriteLine("newFolder was deleted!");
//}


//FILE MANIPULATION

string folderPath = Path.Combine(appPath, @"myFolder\");
string filePath = Path.Combine(folderPath, "test.txt");

if (!Directory.Exists(filePath)) 
{
    Directory.CreateDirectory(folderPath);
}

//check if file exists

bool txtExists = File.Exists(filePath);
Console.WriteLine($"Does test.txt exists: {txtExists}");

// create a file

if (!File.Exists(filePath)) 
{
    File.Create(filePath).Close();
    Console.WriteLine("A file was created!");
}

// delete a file 

Console.WriteLine("press enter to delete text.txt..");
Console.ReadLine();

if (File.Exists(filePath)) 
{
    File.Delete(filePath);
    Console.WriteLine("A file was deleted!");
}


Console.ReadLine();