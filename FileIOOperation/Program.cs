using System;
using System.IO;

namespace FileIOOperation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program.FileExists();
            Program.FileCopy();
            Program.ReadAllLines();
            Program.ReadAllText();
            Program.DeleteFile();
            ReadThroughStreamReader readThroughStreamReader = new ReadThroughStreamReader();
            readThroughStreamReader.WriteUsingStreamWriter();
            readThroughStreamReader.ReadFromStreamReader();
        }

        public static void FileExists()
        {
            String path = @"E:\Example.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }

        public static void ReadAllLines()
        {
            String path = @"E:\Example.txt";

            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            Console.ReadKey();
        }

        public static void ReadAllText()
        {
            String path = @"E:\Example.txt";

            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);

            Console.ReadKey();
        }

        public static void FileCopy()
        {
            String path = @"E:\Example.txt";

            String copypath = @"E:\ExampleNew.txt";

            File.Copy(path, copypath);

            Console.ReadKey();
        }

        public static void DeleteFile()
        {
            String path = @"E:\Example.txt";

            File.Delete(path);

            Console.ReadKey();
        }
    }
}
