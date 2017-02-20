namespace _03.ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    class LongestTwoUsernames
    {
        static void Main(string[] args)
        {
            var potentialUsernames = Console.ReadLine()
                .Split(new[] { '\\', '/', ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            var pattern = @"^[A-Za-z]\w{2,24}$";

            var regex = new Regex(pattern);

            var validUsernames = new List<string>();

            foreach (var username in potentialUsernames)
            {
                if (regex.IsMatch(username))
                {
                    validUsernames.Add(username);
                }
            }

            var maxLenghtOfPair = int.MinValue;
            var leftUName = string.Empty;
            var rightUName = string.Empty;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                var currentLenght = validUsernames[i].Length + validUsernames[i + 1].Length;

                if (currentLenght > maxLenghtOfPair)
                {
                    maxLenghtOfPair = currentLenght;
                    leftUName = validUsernames[i];
                    rightUName = validUsernames[i + 1];
                }
            }

            Console.WriteLine(leftUName);
            Console.WriteLine(rightUName);
        }
    }
}
