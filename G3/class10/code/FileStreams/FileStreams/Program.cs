string appPath = @"..\..\..\";
string folderPath = Path.Combine(appPath, "myFolder");
string filePath = Path.Combine(folderPath, "test.txt");

if (!Directory.Exists(folderPath)) 
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("New folder was created.");
}

// Writing with StreamWriter

using (StreamWriter sw = new StreamWriter(filePath)) 
{
    sw.WriteLine("Hello SEDC");
    sw.WriteLine("We are writing text from StreamWriter!");

    Console.WriteLine("Writing is complete.");
}

// true default // false will erase previous content
using (StreamWriter sw = new StreamWriter(filePath, true)) 
{
    sw.WriteLine("Hello again");
    sw.WriteLine("We are writing again.");

    Console.WriteLine("Write Again");
}

// Reading with StreamReader

using (StreamReader sr = new StreamReader(filePath)) 
{
    string firstLine = sr.ReadLine();
    string secondLine = sr.ReadLine();

    string restContent = sr.ReadToEnd();
}

Console.ReadLine();

