namespace _05.UseYourChainBuddy
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            //var input = @"<html><head><title></title></head><body><h1>Intro</h1><ul><li>Item01</li><li>Item02</li><li>Item03</li></ul><p>jura qevivat va jrg fyvccrel fabjl</p><div><button>Click me, baby!</button></div><p> pbaqvgvbaf fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx </p><span>This manual is false, do not trust it! The illuminati wrote it down to trick you!</span><p>vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</p><p> pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf</p></body>";

            var pattern = new Regex(@"<p>(.+?)<\/p>");

            var extractedText = pattern.Matches(input);

            var matches = string.Empty;

            foreach (Match text in extractedText)
            {
                matches += text.Groups[1].Value;
            }

            matches = Regex.Replace(matches, @"[^a-z\d]", " ");
            matches = Regex.Replace(matches, @"\s+|\n+", " ");

            var result = string.Empty;

            foreach (var symbol in matches)
            {
                if (symbol >= 97 && symbol <= 109)
                {
                    result += (char)(symbol + 13);
                }
                else if (symbol >=110 && symbol <= 122)
                {
                    result += (char)(symbol - 13);
                }
                else
                {
                    result += symbol;
                }
            }

            Console.WriteLine(result);
        }
    }
}
