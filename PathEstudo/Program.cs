using System;
using System.IO;
namespace PathEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\myfolder\open01.txt";

            Console.WriteLine("DirectorySeparatorChar : " + Path.DirectorySeparatorChar);
            // deixa a porção(caminho) do arquivo de lado 
            Console.WriteLine("GetDirectoryName : " + Path.GetDirectoryName(path));

            Console.WriteLine("PathSeparator: " + Path.PathSeparator);

            Console.WriteLine("GetFileName :" + Path.GetFileName(path));

            Console.WriteLine("GetFileNameWithoutExtension : " + Path.GetFileNameWithoutExtension(path));

            Console.WriteLine("GetExtension :" + Path.GetExtension(path));

            Console.WriteLine("GetFullPath : " + Path.GetFullPath(path));
        }
    }
}
