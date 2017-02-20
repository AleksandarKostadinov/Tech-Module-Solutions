namespace _05.UseYourChains_Buddy
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ManualDecrypting
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = new Regex(@"<\/?p>.*?<\/?p>");

            var extractedText = pattern.Matches(input);

            var textList = new List<string>();

            foreach (Match text in extractedText)
            {
                textList.Add(text.Value);
            }
        }
    }
}
