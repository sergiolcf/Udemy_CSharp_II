using System.IO;
using System.Runtime.ConstrainedExecution;
using System;


namespace File_FileInfo_IOException
{
    class Program
    {
        static void Main(string[] args) {

            string sourcePath = @"C:\TEMP\file1.txt";

            string targetPath = @"C:\TEMP\file2.txt";

            try {

                FileInfo fileInfo = new FileInfo(sourcePath);

                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach (var item in lines) {

                    Console.WriteLine(item);

                }

            } catch (IOException e) {

                Console.WriteLine("An error occured");

                Console.WriteLine(e.Message);
            }

        }
    }
}
