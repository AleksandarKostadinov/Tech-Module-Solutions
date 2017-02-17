namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FindPalind
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(", .?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .OrderBy(m => m)
                .ToArray();

            var result = new List<string>();

            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }

        public static bool IsPalindrome(string str)
        {
            int lenghtOfNumber = str.Length;
            for (int i = 0; i < lenghtOfNumber / 2; i++)
            {

                if (str[i] != str[lenghtOfNumber - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
