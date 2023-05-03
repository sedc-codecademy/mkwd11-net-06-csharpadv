
string currentDirectory = Directory.GetCurrentDirectory();
string appPath = @"..\..\..\";

//relative path 
bool myFolderExist = Directory.Exists(appPath + "myFolder");

//absolute path
bool myFolderExistAbsolute = Directory.Exists(@"C:\Users\viceb\Desktop\mkwd11-net-06-csharpadv\G3\class10\code\FileSystem\FileSystem\myFolder");












Console.ReadLine();