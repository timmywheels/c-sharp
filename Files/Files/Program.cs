using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory (static method)...DirectoryInfo (instance method)
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\c-sharp", "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
                System.Console.WriteLine(file);


            var directories = Directory.GetDirectories(@"c:\projects\c-sharp", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                System.Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");

            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();






            // 'File' provides static methods
            // 'FileInfo' provides instance methods

            //var path = @"c:\somefile.jpg";
            //File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true, );
            //File.Delete();

            //if (File.Exists(path))
            //{
            //    //
            //}


            //var content = File.ReadAllText(path);
            //var fileInfo = new FileInfo(path);


            //fileInfo.CopyTo("...");
            //fileInfo.Delete();

            //if (fileInfo.Exists)
            //{
            //    //
            //}
        }
    }
}
