namespace _04.WinningTicketRegex
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
            var tickets = Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
                .ToArray();

            var patternDolar = @"\${6,9}";
            var patternAt = @"@{6,9}";
            var patternHashTag = @"#{6,9}";
            var patternXOR = @"\^{6,9}";


            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (ticket == new string('@', 20))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10@ Jackpot!");
                }
                else if (ticket == new string('$', 20))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10$ Jackpot!");
                }
                else if (ticket == new string('^', 20))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10^ Jackpot!");
                }
                else if (ticket == new string('#', 20))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10# Jackpot!");
                }
                else
                {
                    var leftHalf = ticket.Substring(0, ticket.Length / 2);
                    var rightHalf = ticket.Substring(ticket.Length / 2);

                    if (Regex.IsMatch(leftHalf,patternAt) && Regex.IsMatch(rightHalf, patternAt))
                    {
                        Match atsLeft = Regex.Match(leftHalf, patternAt);
                        Match atsRight = Regex.Match(rightHalf, patternAt);
                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(atsLeft.Value.Length, atsRight.Value.Length)}@");
                    }
                    else if (Regex.IsMatch(leftHalf, patternDolar) && Regex.IsMatch(rightHalf, patternDolar))
                    {
                        Match dolarsLeft = Regex.Match(leftHalf, patternDolar);
                        Match dolarsRight = Regex.Match(rightHalf, patternDolar);
                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(dolarsLeft.Value.Length, dolarsRight.Value.Length)}$");
                    }
                    else if (Regex.IsMatch(leftHalf, patternHashTag) && Regex.IsMatch(rightHalf, patternHashTag))
                    {
                        Match hashTagsLeft = Regex.Match(leftHalf, patternHashTag);
                        Match hashTagsRight = Regex.Match(rightHalf, patternHashTag);
                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(hashTagsLeft.Value.Length, hashTagsRight.Value.Length)}#");
                    }
                    else if (Regex.IsMatch(leftHalf, patternXOR) && Regex.IsMatch(rightHalf, patternXOR))
                    {
                        Match xorsLeft = Regex.Match(leftHalf, patternXOR);
                        Match xorsRight = Regex.Match(rightHalf, patternXOR);
                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(xorsLeft.Value.Length, xorsRight.Value.Length)}^");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
