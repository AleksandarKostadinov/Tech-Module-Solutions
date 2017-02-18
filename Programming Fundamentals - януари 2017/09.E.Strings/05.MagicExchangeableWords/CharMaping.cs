namespace _05.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CharMaping
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .OrderByDescending(s => s.Length)
                .ToList();

            var greaterStr = input[0];
            var smallerStr = input[1];

            bool areExchageable = StringsAreExchangeable(greaterStr, smallerStr);

            Console.WriteLine(areExchageable.ToString().ToLower());
        }

        public static bool StringsAreExchangeable(string greaterStr, string smallerStr)
        {
            bool areExchangeable = true;

            var chMap = new Dictionary<char, char>();

            for (int i = 0; i < smallerStr.Length; i++)
            {
                var firstChar = smallerStr[i];
                var secondChar = greaterStr[i];

                if (!chMap.ContainsKey(firstChar))
                {
                    chMap[firstChar] = secondChar;
                }

                if (chMap.Where(c => c.Key != firstChar).Any(h => h.Value == secondChar))
                {
                    chMap.Remove(firstChar);
                    return false;
                }

                if (chMap[firstChar] != secondChar)
                {
                    return false;
                }
            }

            for (int i = smallerStr.Length; i < greaterStr.Length; i++)
            {
                var currentCh = greaterStr[i];

                if (!chMap.ContainsValue(currentCh))
                {
                    return false;
                }
            }
            
            return areExchangeable;
        }
    }
}
