using System;
using System.IO;
using System.Collections.Generic;

namespace LessonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\017585631\Desktop\codes\Curso\LessonFile\File.txt";
            string targetPath = @"C:\Users\017585631\Desktop\codes\Curso\LessonFile\Failed.txt";
            ////FileStream fs = null;
            //StreamReader sr = null;
            //try
            //{

            //    //FileInfo fileInfo = new FileInfo(sourcePath);
            //    //fileInfo.CopyTo(targetPath);
            //    //string[] lines = File.ReadAllLines(sourcePath);
            //    //foreach(String line in lines)
            //    //{
            //    //    Console.WriteLine(line);
            //    //}

            //    //fs = new FileStream(sourcePath, FileMode.Open);
            //    //sr = new StreamReader(fs);

            //    sr = File.OpenText(sourcePath);
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An Error Occurred: " + e.Message);
            //}
            //finally
            //{
            //    if (sr != null)
            //        sr.Close();

            //    //if (fs != null)
            //    //    fs.Close();
            //}

            //==========================================================================

            //try
            //{
            //    using (StreamReader sr = File.OpenText(sourcePath))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}

            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);

            //    using (StreamWriter sw = File.AppendText(targetPath))
            //    {
            //        foreach(string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}

            //==========================================================================

            string path = @"C:\Users\017585631\Desktop\codes\Curso\LessonFile\Folder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newFolder");

                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                Console.WriteLine("GetExtension: " + Path.GetExtension(path));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
