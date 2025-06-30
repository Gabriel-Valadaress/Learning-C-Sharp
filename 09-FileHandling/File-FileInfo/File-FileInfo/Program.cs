using System.IO;

namespace File_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\newFile.txt";
            string copyPath = @"c:\temp\copyFile.txt";
            string content = "Hello World!";

            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    File.AppendAllText(sourcePath, i + " - " + content + "\n");
                }

                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(copyPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
