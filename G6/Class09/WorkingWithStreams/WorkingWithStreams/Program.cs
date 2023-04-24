string appPath = @"..\..\..\";
string folderPath = appPath + "myFolder";
//  ..\..\..\myFolder\test.txt
string txtPath = folderPath + @"\test.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}


using (StreamWriter sw = new StreamWriter(txtPath))
{
    sw.WriteLine("Hello SEDC");
    sw.WriteLine("We are writing from stream writer");
}
//sw exists and can only be used in the using block {}
//after } sw object is disposed and the connection with the filesystem is closed

//if there is already some text it will be overwritten
using(StreamWriter sw = new StreamWriter(txtPath))
{
    sw.WriteLine("Another text");
    sw.WriteLine("This is another line");
    sw.WriteLine("This is another text after two lines");
    sw.WriteLine("This is the rest of the text");
}

//this line will be appended
using (StreamWriter sw = new StreamWriter(txtPath, true))
{
    sw.WriteLine("This is appended text");
}

//reading
using (StreamReader streamReader = new StreamReader(txtPath))
{
    string firstLine = streamReader.ReadLine();
    string secondLIne = streamReader.ReadLine();
    string restOfText = streamReader.ReadToEnd();

    Console.WriteLine(firstLine);
    Console.WriteLine(secondLIne);
    Console.WriteLine(restOfText);
}
