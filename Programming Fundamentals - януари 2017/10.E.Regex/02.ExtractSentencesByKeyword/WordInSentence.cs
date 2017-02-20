namespace _02.ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    class WordInSentence
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentences = Console.ReadLine()
                .Split("!?.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var pattern = "\\b" + word + "\\b";
            var regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
