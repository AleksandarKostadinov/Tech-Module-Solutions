namespace _03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    class RepeatedWords
    {
        static void Main(string[] args)
        {
            var file = "Words.txt";

            var checkWords = File.ReadAllText(file)
                .Split(' ')
                .Distinct()
                .ToList();

            var dictOfWords = new Dictionary<string, int>();

            checkWords
                .ForEach(c => dictOfWords[c] = 0);

            var textWords = File.ReadAllText("Text.txt")
                .ToLower()
                .Split(",. ?!-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < checkWords.Count; i++)
            {
                for (int j = 0; j < textWords.Length; j++)
                {
                    if (checkWords[i] == textWords[j])
                    {
                        dictOfWords[checkWords[i]]++;
                    }
                }
            }

            dictOfWords =  dictOfWords.OrderByDescending(j => j.Value).ToDictionary(m => m.Key, m => m.Value);

            var result = new List<string>();

            foreach (var word in dictOfWords)
            {
                var currentLine = $"{word.Key} - {word.Value}";
                result.Add(currentLine);
            }

            File.WriteAllLines("output.txt", result);
        }
    }
}
