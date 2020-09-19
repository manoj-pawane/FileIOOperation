using System;
using System.IO;

namespace FileIOOperation
{
    public class ReadThroughStreamReader
    {
        public void WriteUsingStreamWriter()
        {
            String path = @"E:\Example.txt";

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello world - .Net is awesome");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }

        public void ReadFromStreamReader()
        {
            String path = @"E:\Example.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
