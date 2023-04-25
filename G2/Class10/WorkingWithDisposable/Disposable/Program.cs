#region Initial setup
using Disposable;

string appPath = "../../../TextFolder";
string filePath = appPath + "/text.txt";

void CreateFolder(string path)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

void CreateFile(string path)
{
    if (!File.Exists(path))
    {
        File.Create(path).Close();
    }
}

CreateFolder(appPath);
CreateFile(filePath);
CreateFile("../leo.txt");

#endregion

#region Manual Dispose Methods
void AppendTextInFile(string text, string path)
{
    StreamWriter sw = new StreamWriter(path, true);
    if (text == "break") throw new Exception("Something broke unexpectedly...");
    sw.WriteLine(text);
    sw.Dispose();
}

void ReadTextFromFile(string path)
{
    StreamReader sr = new StreamReader(path);
    Console.WriteLine(sr.ReadToEnd());
    sr.Dispose();
}

void ManualExample()
{
    try
    {
        Console.WriteLine("Enter text pt1:");
        string text1 = Console.ReadLine();
        AppendTextInFile(text1, filePath);

        Console.WriteLine("Enter text pt2:");
        string text2 = Console.ReadLine();
        AppendTextInFile(text2, filePath);

        Console.WriteLine("Enter text pt3:");
        string text3 = Console.ReadLine();
        AppendTextInFile(text3, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the system !");
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.ReadLine();
        Console.WriteLine("---------------Reading from file-----------------");
        ReadTextFromFile(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the system !");
        Console.WriteLine(ex.Message);
    }
}

//ManualExample();

#endregion

#region Dispose with the USING BLOCK
void AppendTextInFileTheSafeWay(string text, string path)
{
    using (StreamWriter sw = new StreamWriter(path, true))
    {
        if (text == "break") throw new Exception("There is some kind of a problem...");
        sw.WriteLine(text);
    }
}

void ReadFromFileTheSafeWay(string path)
{
    using (StreamReader sr = new StreamReader(path))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}

void UsingExample()
{
    try
    {
        Console.WriteLine("Enter text pt1:");
        string text1 = Console.ReadLine();
        AppendTextInFileTheSafeWay(text1, filePath);

        Console.WriteLine("Enter text pt2:");
        string text2 = Console.ReadLine();
        AppendTextInFileTheSafeWay(text2, filePath);

        Console.WriteLine("Enter text pt3:");
        string text3 = Console.ReadLine();
        AppendTextInFileTheSafeWay(text3, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the system !");
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.ReadLine();
        Console.WriteLine("---------------Reading from file-----------------");
        ReadFromFileTheSafeWay(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the system !");
        Console.WriteLine(ex.Message);
    }
}

//UsingExample();
#endregion

#region Disposing with our own custom class
void AppendTextInFileWithOurImplementedClass(string text, string path)
{
    using (OurWriter ow = new OurWriter(path))
    {
        if (text == "break") throw new Exception("ERROR");
        ow.Write(text);
    }
}

void ReadTextFromFileWithOurImplementedClass(string path)
{
    using (OurReader or = new OurReader(path))
    {
        Console.WriteLine(or.Read());
    }
}

void OurDisposableClassExample()
{
    try
    {
        Console.WriteLine("Enter text pt1:");
        string text1 = Console.ReadLine();
        AppendTextInFileWithOurImplementedClass(text1, filePath);

        Console.WriteLine("Enter text pt2:");
        string text2 = Console.ReadLine();
        AppendTextInFileWithOurImplementedClass(text2, filePath);

        Console.WriteLine("Enter text pt3:");
        string text3 = Console.ReadLine();
        AppendTextInFileWithOurImplementedClass(text3, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the system !");
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.ReadLine();
        Console.WriteLine("---------------Reading from file-----------------");
        ReadTextFromFileWithOurImplementedClass(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the system !");
        Console.WriteLine(ex.Message);
    }
}

OurDisposableClassExample();
#endregion