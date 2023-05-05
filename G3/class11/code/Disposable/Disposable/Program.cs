
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

void ManualExample() 
{
    try
    {
        Console.WriteLine("Enter text pt1: ");
        string text1 = Console.ReadLine();
        AppendTextInFile(text1, filePath);

        //Console.WriteLine("Enter text pt2: ");
        //string text2 = Console.ReadLine();
        //AppendTextInFile(text2, filePath);

        //Console.WriteLine("Enter text pt3: ");
        //string text3 = Console.ReadLine();
        //AppendTextInFile(text3, filePath);
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





CreateFolder(appPath);
CreateFile(filePath);

ManualExample();


