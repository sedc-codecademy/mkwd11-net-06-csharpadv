using SEDC.Class10.CustomWriterAndReader;

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
    if (!File.Exists(path))
    {
        File.Create(path).Close();
    }
}


#region Manual Dispose Method

void WriteTextInFile(string text, string path)
{
    StreamWriter sw = new StreamWriter(path, true);
    sw.WriteLine(text);
    sw.Dispose();
}

void ReadTextInFile(string path)
{
    StreamReader sr = new StreamReader(path);
    Console.WriteLine(sr.ReadToEnd());
    sr.Dispose();
}

void ManualDispose()
{
    try
    {
        Console.WriteLine("Enter text one:");
        string textOne = Console.ReadLine();
        WriteTextInFile(textOne, filePath);
        Console.WriteLine("Enter text two:");
        string textTwo = Console.ReadLine();
        WriteTextInFile(textTwo, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.WriteLine("========== Read Text file ========");
        ReadTextInFile(filePath);
    }
    catch(Exception ex)
    {
        Console.WriteLine("Exception in reading system");
        Console.WriteLine(ex.Message);
    }
}

#endregion

#region Dispose with Using Block

void WriteTextFileUsingBlock(string text, string path)
{
    using (StreamWriter sw = new StreamWriter(path, true))
    {
        sw.WriteLine(text);
    }
}

void ReadTextFileUsingBlock(string path)
{
    using(StreamReader sr = new StreamReader(path))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}

void UsingDispose()
{
    try
    {
        Console.WriteLine("Enter text one:");
        string textOne = Console.ReadLine();
        WriteTextFileUsingBlock(textOne, filePath);
        Console.WriteLine("Enter text two:");
        string textTwo = Console.ReadLine();
        WriteTextFileUsingBlock(textTwo, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.WriteLine("========== Read Text file ========");
        ReadTextFileUsingBlock(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception in reading system");
        Console.WriteLine(ex.Message);
    }
}

#endregion


#region Custom Dispose
void WriterTextInFileCustomDispose(string text, string path)
{
    using(OurWriter ow = new OurWriter(path))
    {
        ow.Writer(text);
    }
}


void ReadTextFileCustomDispose(string path)
{
    using (OurReader or = new OurReader(path))
    {
        Console.WriteLine(or.Reader());
    }
}

void CustomDispose()
{
    try
    {
        Console.WriteLine("Enter text one:");
        string textOne = Console.ReadLine();
        WriterTextInFileCustomDispose(textOne, filePath);
        Console.WriteLine("Enter text two:");
        string textTwo = Console.ReadLine();
        WriterTextInFileCustomDispose(textTwo, filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.WriteLine("========== Read Text file ========");
        ReadTextFileCustomDispose(filePath);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception in reading system");
        Console.WriteLine(ex.Message);
    }
}
#endregion

CreateFolder(appPath);
CreateFile(filePath);


//ManualDispose();
//UsingDispose();

CustomDispose();