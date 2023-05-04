
using SEDC.Dispose;

string appPath = @"..\..\..\Text";
string filePath = appPath + @"\text.txt";

void CreateFolder(string path)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

void CreateFile(string path)
{
    if(!File.Exists(path))
    {
        File.Create(path).Close();
    }
}

string ReadInput(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

#region Manual Dispose Methods

void AppendTextInFile(string text, string filePath)
{
    StreamWriter sw = new StreamWriter(filePath, true);
    if (text == "break")
        throw new Exception("Something broke unexpectedly!");
    sw.WriteLine(text);
    sw.Dispose();
}

void ReadTextFromFile(string filePath)
{
    StreamReader sr = new StreamReader(filePath);
    Console.WriteLine(sr.ReadToEnd());
    sr.Dispose();
}

void ManualExample()
{
    try
    {
        string text1 = ReadInput("Enter some text pt1:");
        string text2 = ReadInput("Enter some text pt2:");

        AppendTextInFile(text1, filePath);
        AppendTextInFile(text2, filePath);

    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in writing in the file.");
        Console.WriteLine(ex.Message);
    }


    try
    {
        Console.ReadLine();
        Console.WriteLine("--------- Read ----------");
        ReadTextFromFile(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the reading of the file.");
        Console.WriteLine(ex.Message);
    }

    Console.ReadLine();
}



#endregion

#region Dispose with Using block

void AppendTextInFileSafe(string text, string filePath)
{
    using (StreamWriter sw = new StreamWriter(filePath, true))
    {
        if (text == "break")
            throw new Exception("Something broke unexpectedly!");
        sw.WriteLine(text);
    }
}

void ReadTextFromFileSafe(string filePath)
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}


void UsingExample()
{
    try
    {
        string text1 = ReadInput("Enter some text pt1:");
        string text2 = ReadInput("Enter some text pt2:");

        AppendTextInFileSafe(text1, filePath);
        AppendTextInFileSafe(text2, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in writing in the file.");
        Console.WriteLine(ex.Message);
    }


    try
    {
        Console.ReadLine();
        Console.WriteLine("--------- Read ----------");
        ReadTextFromFileSafe(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the reading of the file.");
        Console.WriteLine(ex.Message);
    }

    Console.ReadLine();
}


#endregion

#region Dispose with our own class

void AppendTextInFileOurImplementation(string text, string path)
{
    using (OurWriter ow = new OurWriter(path))
    {
        ow.Write(text);
    }
}

void ReadTextFromFileOurImplementation(string path)
{
    using (OurReader or = new OurReader(path))
    {
        Console.WriteLine(or.Read());
    }
}


void OurDisposableExample()
{
    try
    {
        string text1 = ReadInput("Enter text pt1:");
        string text2 = ReadInput("Enter text pt2:");

        AppendTextInFileOurImplementation(text1, filePath);
            AppendTextInFileOurImplementation(text2, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the writing of the file.");
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.ReadLine();
        Console.WriteLine("---------- Read ---------");
        ReadTextFromFileOurImplementation(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("There was a problem in the reading of the file.");
        Console.WriteLine(ex.Message);
    }

    Console.ReadLine();
}



#endregion

CreateFolder(appPath);
CreateFile(filePath);


//ManualExample();
//UsingExample();
OurDisposableExample();