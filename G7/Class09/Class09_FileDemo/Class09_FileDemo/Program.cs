using Models;

namespace Class09_FileDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Working with folders
            #region Absolute Path
            string absolutePath = @"C:\";
            Directory.CreateDirectory(absolutePath + "Class09Folder"); //C:\Class09Folder
            Directory.CreateDirectory(absolutePath + @"Class09Folder\Folder01\NestedFolder");
            #endregion

            //absolute path of the folder where our exe is.
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            //if we do not change the path, the new folder will be created in the execution folder path (the one specified above)
            Directory.CreateDirectory("MyAppFolder");

            //Class09 root folder (5 levels above the current path (exe path))
            string class09Root = @"..\..\..\..\..\";

            //relative path based on the current path
            //Directory.CreateDirectory(currentDirectory + class09Root + "RootFolder");
            string newFolderPath = class09Root + "RootFolder";
            Directory.CreateDirectory(newFolderPath);
            Directory.CreateDirectory(newFolderPath + @"\SubFolder");

            //bool folderExists = Directory.Exists(class09Root + "RootFolder");

            //if(folderExists)
            //{
            //    Directory.Delete(class09Root + "RootFolder");
            //}

            //Renaming
            string newPath = class09Root + @"RenamedFolder";
            Directory.Move(newFolderPath, newPath);

            if (Directory.Exists(newPath))
            {
                //removes the folder only if it is empty
                //Directory.Delete(newFolderPath);

                //remove the folder and all its content
                Directory.Delete(newPath, true);
            }
            #endregion

            string folderFilePath = "WorkingWithFiles";
            Directory.CreateDirectory(folderFilePath);
            string filePath = folderFilePath + @"\example.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            //string fileJsonPath = folderFilePath + @"\example.json";
            //if (!File.Exists(fileJsonPath))
            //{
            //    File.Create(fileJsonPath).Close();
            //}

            if(File.Exists(filePath))
            {
                //write some content in the file
                File.WriteAllText(filePath, "Hello everyone, welcome to SEDC\nThis is our class");
            }

            //WriteAllText replace (overwrites) the previous content
            if (File.Exists(filePath))
            {
                //write some content in the file
                File.WriteAllText(filePath, "Hello this is a new text");
            }

            if (File.Exists(filePath))
            {
                //appends some content in the file
                File.AppendAllText(filePath, "\nThis is additional text");
            }

            if (File.Exists(filePath))
            {
                //read file content
                string text = File.ReadAllText(filePath);                
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}