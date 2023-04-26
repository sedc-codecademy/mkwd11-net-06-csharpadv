//MANUALLY DISPOSE

using DisposingClasses;

string appPath = @"..\..\..\Example";
string filePath = appPath + @"\example.txt";

#region ManualDispose
void AppendTextToFile(string text, string filePath)
{
    StreamWriter sw = new StreamWriter(filePath, true);
    sw.WriteLine(text);
    //StreamWriter implements IDisposable interface. That means that it implements the Dispose method.
    //This method has to be called, so the sw object is destroyed and connection to the file is closed.
    //We call this method explicitly, since we don't have an using block.
    sw.Dispose();
}

void ReadTextFromFile(string filePath)
{
    StreamReader streamReader = new StreamReader(filePath);
    string text = streamReader.ReadToEnd(); 
    Console.WriteLine(text);
    //StreamReader implements IDisposable interface. That means that it implements the Dispose method.
    //This method has to be called, so the streamReader object is destroyed and connection to the file is closed.
    //We call this method explicitly, since we don't have an using block.
    streamReader.Dispose();
}

if(!Directory.Exists(appPath))
{
    Directory.CreateDirectory(appPath);
}

try
{
    AppendTextToFile("Hello world", filePath);
    ReadTextFromFile(filePath);
}
catch(Exception e)
{
    Console.WriteLine($"{e.Message}");
}
#endregion

#region Dispose with using block

void AppendTextInFileWithUsing(string text, string filePath)
{
    using(StreamWriter sw = new StreamWriter(filePath, true))
    {
        sw.WriteLine(text);
    } //here sw.Dispose() is automatically called
}

void ReadFromFileWithUsing(string filePath)
{
    using(StreamReader streamReader = new StreamReader(filePath))
    {
        string text = streamReader.ReadToEnd();
        Console.WriteLine(text);
    }
}

try
{
    Console.WriteLine("==========using block ===============");
    AppendTextInFileWithUsing("Hello world", filePath);
    ReadFromFileWithUsing(filePath);
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}

#endregion


#region Custom Disposable class

void AppendTextToFileCustom(string text, string filePath)
{
    //CustomWriter implements IDisposable interface, has Dispose method, so we can use it in a using block
    using(CustomWriter cw =  new CustomWriter(filePath))
    {
        cw.Write(text);
    }//here the Dispose method with our implementation will be called
}

AppendTextToFileCustom("Hello world from Custom Writer", filePath);

#endregion