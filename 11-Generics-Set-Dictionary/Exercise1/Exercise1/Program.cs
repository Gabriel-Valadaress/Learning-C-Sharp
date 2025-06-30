using Exercise1.Entities;
using System;
using System.IO;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = "log.txt";

            HashSet<LogRecord> logRecords = new HashSet<LogRecord>();

            try
            {
                string[] lines = File.ReadAllLines(path);
                {
                    foreach (string line in lines)
                    {
                        string[] log = line.Split(' ');
                        logRecords.Add(new LogRecord(log[0], DateTime.Parse(log[1])));
                    }
                    Console.WriteLine("Total users: " + logRecords.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
