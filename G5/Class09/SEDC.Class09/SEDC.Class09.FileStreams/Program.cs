string appPath = @"..\..\..\";
string folderPath = appPath + @"MainFolder\";
string filePath = folderPath + "helloFile.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("New direcotry was created!");
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
    Console.WriteLine("New file was created!");
}


#region FileManipulation - Streams

StreamWriter streamWriter = new StreamWriter(filePath);

streamWriter.WriteLine("Hello G5");
streamWriter.WriteLine("We are writing text from StreamWriter");

// Manually disposing resources held by the stream writer/reader
streamWriter.Dispose();


// 'using' automatically disposes all the resources when the block ends
using (StreamWriter sw = new StreamWriter(filePath, true))
{
    sw.WriteLine("Hello again!");
    sw.WriteLine("This is written on top of the previous one!");
}


using (StreamReader sr = new StreamReader(filePath))
{
    //Console.WriteLine($"[1] {sr.ReadLine()}");
    //Console.WriteLine($"[2] {sr.ReadLine()}");
    //Console.WriteLine($"[REST] {sr.ReadToEnd()}");

    string content = sr.ReadToEnd();
    Console.WriteLine(content);
}

#endregion