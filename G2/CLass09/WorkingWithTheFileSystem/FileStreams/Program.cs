using FileSystem;

#region Initial setup

TextHelper.TextGenerator("Check if the folder exists.", ConsoleColor.Cyan);
string relativeFolderPath = "../../../StreamFolder";

if (!Directory.Exists(relativeFolderPath))
{
    Directory.CreateDirectory(relativeFolderPath);
    TextHelper.TextGenerator("Folder created.", ConsoleColor.Green);
}

TextHelper.TextGenerator("Check if the file exists.", ConsoleColor.Cyan);
string relativeFilePath = relativeFolderPath + "/streamFile.txt";

if (!File.Exists(relativeFilePath))
{
    File.Create(relativeFilePath).Close();
    TextHelper.TextGenerator("File created.", ConsoleColor.Green);
}
#endregion

#region File manipulation with streams
TextHelper.TextGenerator("\n\n\nWriting in the newly created file with the StreamWriter.", ConsoleColor.Cyan);

StreamWriter sw = new StreamWriter(relativeFilePath);
sw.WriteLine("Hello batinja");
sw.WriteLine("I am writing in the file with StreamWriter batinja !");
sw.WriteLine("Bye batinja");
sw.Close();

TextHelper.TextGenerator("\nWriting in the file completed.", ConsoleColor.Green);

TextHelper.TextGenerator("\n\n\nWriting in the newly created file with the StreamWriter. But we are using [USING]", ConsoleColor.Cyan);

using (sw = new StreamWriter(relativeFilePath, true))
{
    sw.WriteLine("Hello batinja we are in the USING");
    sw.WriteLine("bye bye bye");
    TextHelper.TextGenerator("\nWriting in the file completed. And stream is closed.", ConsoleColor.Green);
}

using (StreamReader sr = new StreamReader(relativeFilePath))
{
    string text = sr.ReadToEnd();
    TextHelper.TextGenerator("\nReading from the stream file...", ConsoleColor.Yellow);
    TextHelper.TextGenerator(text, ConsoleColor.DarkGray);
    TextHelper.TextGenerator("Reading has been completed.", ConsoleColor.Green);
}
#endregion