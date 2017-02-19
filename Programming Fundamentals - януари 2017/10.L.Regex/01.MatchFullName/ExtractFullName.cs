namespace _01.MatchFullName
{
    using System.Text.RegularExpressions;
    using System.IO;
    using System.Collections.Generic;

    class ExtractFullName
    {
        static void Main()
        {
            var text = File.ReadAllText("Input.txt");

            var pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            var names = pattern.Matches(text);

            var result = new List<string>();

            foreach (Match name in names)
            {
                result.Add(name.Value);
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}
