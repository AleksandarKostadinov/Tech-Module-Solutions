namespace _05.FolderSize
{
    using System.IO;
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var files = Directory.GetFiles("TestFolder");
            long sum = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            var sumInMB = (sum / 1024.0) / 1024.0;

            File.WriteAllText("result.txt", sumInMB.ToString());
        }
    }
}
