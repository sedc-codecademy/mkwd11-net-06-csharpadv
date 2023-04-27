string folderPath = "../../../DemoFolder";
string filePath = folderPath + "/text.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
}

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    Console.WriteLine("Please enter some text:");
    string textInput = Console.ReadLine();
    sw.WriteLine(textInput);
}

using (StreamReader sr = new StreamReader(filePath))
{
    Console.WriteLine("\n\n\nReading:");
    string text = sr.ReadToEnd();
    Console.WriteLine(text);
}