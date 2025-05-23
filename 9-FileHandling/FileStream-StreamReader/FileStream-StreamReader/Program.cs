using System.IO;

namespace FileStream_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                using (fileStream = new FileStream(path, FileMode.Open))
                {
                    using (streamReader = new StreamReader(fileStream))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            string line = streamReader.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("IO Exception: " + e.Message);
            }
        }
    }
}
