namespace _04.MergeFiles
{
    using System.Collections.Generic;
    using System.IO;
    
    class TwoFilesInOne
    {
        static void Main()
        {
            var firstFileLines = File.ReadAllLines("FirstInput.txt");
            var secondFileLines = File.ReadAllLines("SecondInput.txt");

            var result = new List<string>();


            for (int i = 0; i < firstFileLines.Length; i++)
            {
                result.Add(firstFileLines[i]);
                result.Add(secondFileLines[i]);
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}
