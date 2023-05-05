using Disposable.CustomReaderWriter;

string appPath = @"..\..\..\Text";
string filePath = Path.Combine(appPath, "text.txt");

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

// manual disposing
void ManualExample() 
{
    try
    {
        Console.WriteLine("Enter text pt1: ");
        string text1 = Console.ReadLine();
        AppendTextInFile(text1, filePath);

        Console.WriteLine("Enter text pt2: ");
        string text2 = Console.ReadLine();
        AppendTextInFile(text2, filePath);

        Console.WriteLine("Enter text pt3: ");
        string text3 = Console.ReadLine();
        AppendTextInFile(text3, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was problem in the writing system.");
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.ReadLine();
        Console.WriteLine("---------Read(---------");

        ReadTextFromFile(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There wasa problem in the writing system.");
        Console.WriteLine(ex.Message);
    }
}
void AppendTextInFile(string text, string path) 
{
    StreamWriter sw = new StreamWriter(path, true);

    if (text == "break") 
    {
        throw new Exception("Something broke unexpectedly...");
    }

    sw.WriteLine(text);
    sw.Dispose();
}
void ReadTextFromFile(string path) 
{
    StreamReader sr = new StreamReader(path);

    string content = sr.ReadToEnd();

    Console.WriteLine(content);
    sr.Dispose();
}

// disposing with using keyword
void UsingExample() 
{
    try
    {
        Console.WriteLine("Enter text pt1: ");
        string text1 = Console.ReadLine();
        AppendTextInFileSafe(text1, filePath);

        Console.WriteLine("Enter text pt2: ");
        string text2 = Console.ReadLine();
        AppendTextInFileSafe(text2, filePath);

        Console.WriteLine("Enter text pt3: ");
        string text3 = Console.ReadLine();
        AppendTextInFileSafe(text3, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There wasa problem in the writing system.");
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.ReadLine();
        Console.WriteLine("---------Read(---------");

        ReadTextFromFile(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was problem in the writing system.");
        Console.WriteLine(ex.Message);
    }
}
void AppendTextInFileSafe(string text, string path) 
{
    using (StreamWriter sw = new StreamWriter(path, true))
    {
        if (text == "break") 
        {
            throw new Exception("Something broke unexpectedly...");
        }

        sw.WriteLine(text);
    }
}

// custom displosable example
void OurDisposableExample() 
{
    try
    {
        Console.WriteLine("Enter text pt1: ");
        string text1 = Console.ReadLine();
        AppendTextInFileOurExample(text1, filePath);

        Console.WriteLine("Enter text pt2: ");
        string text2 = Console.ReadLine();
        AppendTextInFileOurExample(text2, filePath);

        Console.WriteLine("Enter text pt3: ");
        string text3 = Console.ReadLine();
        AppendTextInFileOurExample(text3, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There wasa problem in the writing system.");
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.ReadLine();
        Console.WriteLine("---------Read---------");

        ReadTextFromFileOurExample(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There wasa problem in the writing system.");
        Console.WriteLine(ex.Message);
    }
}
void AppendTextInFileOurExample(string text, string path) 
{
    using (CustomWriter cw = new CustomWriter(path)) 
    {
        cw.Write(text);
    }
}
void ReadTextFromFileOurExample(string path) 
{
    using (CustomReader cr = new CustomReader(path)) 
    {
        Console.WriteLine(cr.Read());
    }
}

CreateFolder(appPath);
CreateFile(filePath);

//ManualExample();
//UsingExample();
OurDisposableExample();

