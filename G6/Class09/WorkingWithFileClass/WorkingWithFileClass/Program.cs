using System.IO;

//absolute path
string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);

//relative path to console app folder
string appPath = @"..\..\..\";

// ..\..\..\myFolder -> check if this path exists, check if three levels above exists a folder called myFolder
bool myFolderExists = Directory.Exists(appPath + "myFolder");
Console.WriteLine($"My folder exists: {myFolderExists}");

//..\..\..\newFolder
string newFolderPath = appPath + "newFolder";
if (!Directory.Exists(newFolderPath))
{
    Directory.CreateDirectory(newFolderPath);
    Console.WriteLine("New folder succesfully created.");
}

Console.WriteLine($"New folder exists: {Directory.Exists(newFolderPath)}");

if (Directory.Exists(newFolderPath))
{
    Directory.Delete(newFolderPath);
    Console.WriteLine("New folder deleted");
}

//WORKING WITH FILES
if(!Directory.Exists(appPath + "myFolder"))
{
    Directory.CreateDirectory(appPath + "myFolder");
    Console.WriteLine("My folder succesfully created.");
}

//       ..\..\..\myFolder\test.txt
bool testTxtExists = File.Exists(appPath + @"myFolder\test.txt");
Console.WriteLine($"Test txt exists: {testTxtExists}");

if (!testTxtExists)
{
    File.Create(appPath + @"myFolder\test.txt").Close();
    Console.WriteLine("test.txt was created.");
}

if(File.Exists(appPath + @"myFolder\test.txt"))
{
    //overwrite the content of test.txt
    File.WriteAllText(appPath + @"myFolder\test.txt", "Hello  SEDC!");
}

if (File.Exists(appPath + @"myFolder\test.txt"))
{
    //overwrite the content of test.txt
    File.WriteAllText(appPath + @"myFolder\test.txt", "Hello  SEDC again! This is another text!");
}

if (File.Exists(appPath + @"myFolder\test.txt"))
{
    //append text to the content of test.txt
    File.AppendAllText(appPath + @"myFolder\test.txt", Environment.NewLine + "Goodbye \n SEDC");
}

//delete
if (File.Exists(appPath + @"myFolder\test.txt"))
{
    File.Delete(appPath + @"myFolder\test.txt");
}
