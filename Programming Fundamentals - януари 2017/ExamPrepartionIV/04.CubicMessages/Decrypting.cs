namespace _04.CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Decrypting
    {
        static void Main()
        {
            var masagePattern = @"^([\d]+)([a-zA-Z]*)([^a-zA-Z]*)$";

            var line = Console.ReadLine();
            

            while (line != "Over!")
            {
                var masageLength = int.Parse(Console.ReadLine());

                if (!Regex.IsMatch(line, masagePattern))
                {
                    line = Console.ReadLine();
                    continue;
                }

                var match = Regex.Match(line , masagePattern);

                var masage = match.Groups[2].Value;

                if (masage.Length != masageLength)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var indices = match.Groups[1].Value;

                var nonDigitPattern = @"[^\d]";
                var secondHalfOfDigits = Regex.Replace(match.Groups[3].Value, nonDigitPattern, String.Empty);

                var allIndicesAsStr = indices + secondHalfOfDigits;
                var allIndices = new List<int>();

                for (int i = 0; i < allIndicesAsStr.Length; i++)
                {
                    var currentNum = int.Parse(allIndicesAsStr[i].ToString());
                    allIndices.Add(currentNum);
                }

                var key = String.Empty;

                for (int i = 0; i < allIndices.Count; i++)
                {
                    var currentIndex = allIndices[i];

                    if (currentIndex >= 0 && currentIndex < masage.Length)
                    {
                        key += masage[currentIndex];
                    }
                    else
                    {
                        key += " ";
                    }
                }

                Console.WriteLine($"{masage} == {key}");
                
                line = Console.ReadLine();
            }
        }
    }
}
