using FileSystem;

#region Directory manipulation

TextHelper.TextGenerator("Working with the file system", ConsoleColor.Cyan);
string currentDirectory = Directory.GetCurrentDirectory();
TextHelper.TextGenerator($"Currently we are here: {currentDirectory}", ConsoleColor.Magenta);

string relativePath = "../../../";

TextHelper.TextGenerator("\n\n================ FOLDER ================\n\n", ConsoleColor.Cyan);
TextHelper.TextGenerator("Check if the folder exists.\n\nResult:", ConsoleColor.Cyan);

bool doesFolderExist = Directory.Exists(relativePath + "/DemoFolder");
if (!doesFolderExist)
{
    TextHelper.TextGenerator("Folder does not exist !", ConsoleColor.Red);
}
else
{
    TextHelper.TextGenerator("Folder exists !", ConsoleColor.Green);
}

TextHelper.TextGenerator("\n\n================ CREATE A FOLDER ================\n\n", ConsoleColor.Cyan);

if (!doesFolderExist)
{
    TextHelper.TextGenerator("Folder does not exist !", ConsoleColor.Red);
    TextHelper.TextGenerator("Creating a new folder...", ConsoleColor.Yellow);
    Directory.CreateDirectory(relativePath + "/DemoFolder");
    TextHelper.TextGenerator("Folder created !", ConsoleColor.Green);
}
else
{
    TextHelper.TextGenerator("Folder exists !", ConsoleColor.Green);
}

TextHelper.TextGenerator("\n\n================ DELETE A FOLDER ================\n\n", ConsoleColor.Cyan);

if (!doesFolderExist)
{
    TextHelper.TextGenerator("Folder does not exist !", ConsoleColor.Red);
}
else
{
    TextHelper.TextGenerator("Folder exists !", ConsoleColor.Green);
    TextHelper.TextGenerator("Deleting the existing folder...", ConsoleColor.Yellow);
    Directory.Delete(relativePath + "/DemoFolder", true);
    TextHelper.TextGenerator("Folder deleted !", ConsoleColor.Green);
}
#endregion

#region File manipulation
TextHelper.TextGenerator("\n\n================ FILE ================\n\n", ConsoleColor.Cyan);
string relativeFilePath = "../../../FolderWithFile";

if (!Directory.Exists(relativeFilePath))
{
    TextHelper.TextGenerator("Folder does not exist !", ConsoleColor.Red);
    TextHelper.TextGenerator("Creating a new folder...", ConsoleColor.Yellow);
    Directory.CreateDirectory(relativeFilePath);
    TextHelper.TextGenerator("Folder created.", ConsoleColor.Green);
}
else
{
    TextHelper.TextGenerator("Folder exists and ready to use.", ConsoleColor.Green);
}

TextHelper.TextGenerator("\n\n================ CREATE A FILE ================\n\n", ConsoleColor.Cyan);

string file = "/test.txt";
string fileFullPath = relativeFilePath + file;

if (!File.Exists(fileFullPath))
{
    TextHelper.TextGenerator("File does not exist !", ConsoleColor.Red);
    TextHelper.TextGenerator("Creating a new file...", ConsoleColor.Yellow);
    File.Create(fileFullPath).Close();
    TextHelper.TextGenerator("File created.", ConsoleColor.Green);
}
else
{
    TextHelper.TextGenerator("File exists and ready to use.", ConsoleColor.Green);
}

TextHelper.TextGenerator("\n\n================ DELETE A FILE ================\n\n", ConsoleColor.Cyan);

if (!File.Exists(fileFullPath))
{
    TextHelper.TextGenerator("File does not exist !", ConsoleColor.Red);
}
else
{
    TextHelper.TextGenerator("File exists.", ConsoleColor.Green);
    TextHelper.TextGenerator("Deleting the file.", ConsoleColor.Yellow);
    File.Delete(fileFullPath);
    TextHelper.TextGenerator("File deleted.", ConsoleColor.Green);
}

TextHelper.TextGenerator("\n\n================ WRITE IN A FILE ================\n\n", ConsoleColor.Cyan);

if (!File.Exists(fileFullPath))
{
    TextHelper.TextGenerator("File does not exist !", ConsoleColor.Red);
    TextHelper.TextGenerator("Creating a new file...", ConsoleColor.Yellow);
    File.Create(fileFullPath).Close();
    File.WriteAllText(fileFullPath, "Writing in the file on creation !");
    TextHelper.TextGenerator("File created. And written in it.", ConsoleColor.Green);
}
else
{
    TextHelper.TextGenerator("File exists and ready to use.", ConsoleColor.Green);
    File.WriteAllText(fileFullPath, "Writing in the file, because it already exists !");
    //File.AppendAllText(fileFullPath, "Writing in the file, because it already exists !"); This adds text to the existing previous text.
    TextHelper.TextGenerator("Written in the file.", ConsoleColor.Green);
}

TextHelper.TextGenerator("\n\n================ READ FROM A FILE ================\n\n", ConsoleColor.Cyan);

TextHelper.TextGenerator("Reading from the file:", ConsoleColor.Yellow);

if (File.Exists(fileFullPath))
{
    string text = File.ReadAllText(fileFullPath);
    TextHelper.TextGenerator(text, ConsoleColor.DarkGray);
}
#endregion