namespace _02.LineNumbers
{
    using System.IO;
    using System.Collections.Generic;

    class NumberOfLine
    {
        static void Main()
        {
            var file = "Input.txt";
            var lines = File.ReadAllLines(file);

            var result = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                var currentLine = $"{i + 1}. " + lines[i];
                result.Add(currentLine);
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}
