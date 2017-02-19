namespace _03.Replace_a_Tag
{
    using System;
    using System.Text.RegularExpressions;


    class PutURL
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            while (text != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*)<\/a>";
                var replaceWith = @"[URL href=$1]$2[/URL]";

                var replaced = Regex.Replace(text, pattern, replaceWith);

                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}
