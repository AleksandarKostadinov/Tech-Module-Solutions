namespace ProblemTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var privateMessagePattern = @"^(\d+) <-> ([a-zA-Z\d]+)$";
            var broadcatsPattern = @"^([^\d]+?) <-> ([a-zA-Z\d]+)$";

            var messages = new List<Message>();
            var broadCasts = new List<BroadCast>();

            while (line != "Hornet is Green")
            {
                if (Regex.IsMatch(line, privateMessagePattern))
                {
                    var match = Regex.Match(line, privateMessagePattern);

                    var code = match.Groups[1].Value.ToString();
                    var message = match.Groups[2].Value.ToString();

                    var reversedCode = GetReversedString(code);

                    var currentMessage = new Message
                    {
                        Text = message,
                        RecipientCode = reversedCode
                    };

                    messages.Add(currentMessage);
                }
                else if (Regex.IsMatch(line, broadcatsPattern))
                {
                    var match = Regex.Match(line, broadcatsPattern);
                    var message = match.Groups[1].Value.ToString();
                    var frequency = match.Groups[2].Value.ToString();

                    string fixedFriquency = GetFixedFrequecy(frequency);

                    var currentBroadCast = new BroadCast
                    {
                        MessageText = message,
                        Frequency = fixedFriquency
                    };

                    broadCasts.Add(currentBroadCast);
                }

                line = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadCasts.Any())
            {
                foreach (var broadC in broadCasts)
                {
                    Console.WriteLine($"{broadC.Frequency} -> {broadC.MessageText}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }


            Console.WriteLine("Messages:");
            if (messages.Any())
            {
                foreach (var message in messages)
                {
                    Console.WriteLine($"{message.RecipientCode} -> {message.Text}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        public static string GetFixedFrequecy(string frequency)
        {
            var result = new StringBuilder();

            for (int i = 0; i < frequency.Length; i++)
            {
                var symbol = frequency[i];
                if (symbol >= 'a' && symbol <= 'z')
                {
                    result.Append(symbol.ToString().ToUpper());
                }
                else if (symbol >= 'A' && symbol <= 'Z')
                {
                    result.Append(symbol.ToString().ToLower());
                }
                else
                {
                    result.Append(symbol);
                }
            }

            return result.ToString();
        }

        public static string GetReversedString(string number)
        {
            string reversedStr = string.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedStr += number[i];
            }

            return reversedStr;
        }
    }

    class BroadCast
    {
        public string Frequency { get; set; }
        public string MessageText { get; set; }
    }

    class Message
    {
        public string Text { get; set; }
        public string RecipientCode { get; set; }
    }
}
