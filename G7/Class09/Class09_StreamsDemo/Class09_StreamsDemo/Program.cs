namespace Class09_StreamsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\WorkingWithStreams";
            string filePath = folderPath + @"\streams_example.txt";

            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            //Opens a streamWriter that is a disposable object that will be closed (damaged) once the using block finishes
            //Creating a StreamWriter only with filePath, creates a streamwriter with the option to override the content of that file.
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("This is a stream example");
                sw.WriteLine("Welcome to C# advance");
            }

            //Creating a StreamWriter with filePath and true (as append property), creates a streamwriter with the option to append the content in that file.
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("This is added later on");
                sw.WriteLine("");
                sw.WriteLine("Something else");
            }

            using(StreamReader sr = new StreamReader(filePath))
            {
                //Stream reader ReadLine give each line one by one, same as we have Queue of strings. It will return null when we reach the end
                //string firstLine = sr.ReadLine();
                //string secondLine = sr.ReadLine();
                //string thirdLine = sr.ReadLine();
                //string fourthLine = sr.ReadLine();

                int counter = 1;
                while(true)
                {
                    string line = sr.ReadLine();

                    if(line == null)
                    {
                        break;
                    }

                    Console.WriteLine($"We are on line {counter}: {line}");
                    counter++;
                }
            }

            using(StreamReader sr = new StreamReader(filePath))
            {
                //returns the full content till the end of the file
                string fullContent = sr.ReadToEnd();
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string firstLine = sr.ReadLine();
                string secondLine = sr.ReadLine();

                //returns the content from where ReadLine has stopped until the end
                string contentFromLine3ToTheEnd = sr.ReadToEnd();
            }

            //Requirement is to read the content of the file, close the stream, and then process the content
            string content;
            using(StreamReader rd = new StreamReader(filePath))
            {
                content = rd.ReadToEnd();
            }
            Console.WriteLine(content);

        }
    }
}