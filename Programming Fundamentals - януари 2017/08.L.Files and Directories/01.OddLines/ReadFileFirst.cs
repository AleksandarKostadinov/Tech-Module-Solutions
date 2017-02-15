namespace _01.OddLines
{
    using System.Collections.Generic;
    using System.IO;

    class ReadFileFirst
    {
        static void Main()
        {
            var file = "Input.txt";

            var fileLines =File.ReadAllLines(file);

            var oddLines = new List<string>();

            for (int i = 1; i < fileLines.Length; i += 2)
            {
                oddLines.Add(fileLines[i]);
            }

            File.WriteAllLines("Output.txt", oddLines);
        }
    }
}
