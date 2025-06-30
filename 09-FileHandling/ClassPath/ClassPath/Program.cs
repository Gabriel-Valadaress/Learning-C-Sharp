using System;
using System.IO;

namespace ClassPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"c:\temp\file1.txt";

            string folderPath = Path.GetDirectoryName(filePath);
            Console.WriteLine($"File Path: {filePath}\nFolder Path: {folderPath}");

            char directorySeparator = Path.DirectorySeparatorChar;
            Console.WriteLine("The directory separator char is: " + directorySeparator);

            string fileName = Path.GetFileName(filePath);
            Console.WriteLine($"File name: {fileName}");

            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            Console.WriteLine($"File name without extension: {fileNameWithoutExtension}");

            string fileExtension = Path.GetExtension(filePath);
            Console.WriteLine($"File extension: {fileExtension}");

            string fullPath = Path.GetFullPath(filePath);
            Console.WriteLine("Full path: " + fullPath);

            string tempPath = Path.GetTempPath();
            Console.WriteLine("Temp path: " + tempPath);
        }
    }
}
