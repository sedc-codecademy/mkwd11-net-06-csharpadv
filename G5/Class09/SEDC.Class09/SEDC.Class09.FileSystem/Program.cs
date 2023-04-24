#region DirectoryManipulation - Folder

Console.WriteLine("=== Folder Manipulation ===");

// We have two versions of our app
// - normal version
// - compiled version

// Check in what folder is your application living
string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);
Console.WriteLine("Hello from my compiled app!");
//Console.ReadKey();

// If you create empty folder, it wont show up inside the solution explorer, but you can include it manually
// By Default a folder is going to be created inside the compiled app folder
Directory.CreateDirectory("myFolder");


// Absolute path to our application folder
//string appAbsolutePath = @"C:\Users\angel.mitrov\Desktop\Class09\SEDC.Class09\SEDC.Class09.FileSystem\";

// Relative path to my application folder
string appRelativePath = @"..\..\..\";

// Create Folder
// Will throw error
// Directory.CreateDirectory(appAbsolutePath + "First");

Directory.CreateDirectory(appRelativePath + "First");
Directory.CreateDirectory(appRelativePath + "Second");

string firstFolder = appRelativePath + "First";
string secondFolder = appRelativePath + "Second";


// Exists
// Check if folder exists
bool doesFirstExist = Directory.Exists(firstFolder);
bool doesModelsExist = Directory.Exists(appRelativePath + "Models");

Console.WriteLine($"Does First Exist? - {doesFirstExist}");
Console.WriteLine($"Does Models Exist? - {doesModelsExist}");


// Delete Folder

// When deleting a directory it is a good idea to check if that path actually exists to prevent causing an error\

// We have a second boolean param that we can pass to the Delete
// - Delete the folder if there is anything inside it
if (Directory.Exists(firstFolder))
{
    Directory.Delete(firstFolder, true);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("'First' was deleted!");
    Console.ResetColor();
}

if (Directory.Exists(appRelativePath + "Models"))
{
    Directory.Delete(appRelativePath + "Models");
}

#endregion

#region FileManipulation - File

Console.WriteLine();
Console.WriteLine("=== File Manipulation ===");

string filesPath = appRelativePath + @"MainFolder\";

if (!Directory.Exists(filesPath))
{
    Directory.CreateDirectory(filesPath);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("'MainFolder' was created!");
    Console.ResetColor();
}

// File exists
bool doesNotesExist = File.Exists(filesPath + "notes.txt");
bool doesNotes2Exist = File.Exists(filesPath + "notes2.txt");

Console.WriteLine($"Does Notes Exist? - {doesNotesExist}");
Console.WriteLine($"Does Notes2 Exist? - {doesNotes2Exist}");


// Create File
if (!File.Exists(filesPath + "notes.txt"))
{
    // If you dont specify path, by default the file will be created inside the compiled app folder
    // If you do not close the connection, the process will be active and this will cause an error
    File.Create(filesPath + "notes.txt").Close();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("'notes.txt' was created!");
    Console.ResetColor();
}

//Console.WriteLine();
//Console.WriteLine("Press any key to delete this file...");
//Console.ReadKey();

// Delete File
//File.Delete(filesPath + "random.txt");

//if (File.Exists(filesPath + "notes.txt"))
//{
//    File.Delete(filesPath + "notes.txt");
//    Console.ForegroundColor = ConsoleColor.DarkRed;
//    Console.WriteLine("'notes.txt' was deleted!");
//    Console.ResetColor();
//}



Console.WriteLine();
Console.WriteLine("=== Read/Write ===");
Console.WriteLine();

// Everyting that ends with 'Lines' works with IEnumerable
// Everyting that ends with 'Text' works with string

string notesFilePath = filesPath + "notes.txt";

// Write in a file
if (File.Exists(notesFilePath))
{
    File.WriteAllText(notesFilePath, "Note 1");
    Console.WriteLine("Successfully written in a file!");
    File.WriteAllText(notesFilePath, "Note 2");
    Console.WriteLine("Successfully written in a file again!");
}

Console.WriteLine();

// Read from a file
if (File.Exists(notesFilePath))
{
    string content = File.ReadAllText(notesFilePath);
    Console.WriteLine("Content:");
    Console.WriteLine(content);
}

Console.WriteLine();

// Write in a file
if (File.Exists(notesFilePath))
{
    File.AppendAllText(notesFilePath, "Note 3");
    Console.WriteLine("Successfully appended text in a file!");

    List<string> listOfNotes = new List<string>() { "Note 4", "Note 5", "Note 6" };
    File.AppendAllLines(notesFilePath, listOfNotes);
}

// Read from a file
if (File.Exists(notesFilePath))
{
    string[] fileLines = File.ReadAllLines(notesFilePath);

    foreach (string line in fileLines)
    {
        Console.WriteLine(line);
    }
}

#endregion