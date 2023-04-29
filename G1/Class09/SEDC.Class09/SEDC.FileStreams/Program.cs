string appPath = @"..\..\..\";
string folderPath = appPath + @"MyFolder\";
string filePath = folderPath + @"myFile.txt";

// Calculate(5, 10) => '5 + 10 = 15'
string dummyText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";


if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("Directory created successfully!");
}
else
{
    Console.WriteLine("Directory already exists!");
}


using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine("Hello, this is more elegant way of writing in a file!");
    sw.WriteLine("This gets even more interesing!");
}

Console.ReadLine();

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    sw.WriteLine("Hello, this is more elegant way of writing in a file 123!");
    sw.WriteLine("This gets even more interesing 123!");
    sw.WriteLine(dummyText);
}


using(StreamReader sr = new StreamReader(filePath))
{
    string firstLine = sr.ReadLine();
    string secondLine = sr.ReadLine();
    string thirdLine = sr.ReadLine();

    string restContent = sr.ReadToEnd();

    Console.WriteLine($"First line: {firstLine}");
    Console.WriteLine($"Second line: {secondLine}");
    Console.WriteLine($"Third line: {thirdLine}");

    Console.WriteLine($"The rest content: {restContent}");
}