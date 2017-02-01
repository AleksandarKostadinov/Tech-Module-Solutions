using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = ReadListFrom();
            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                bool isLowerCaseWord = GetIsLowerCaseword(words[i]);
                if (isLowerCaseWord)
                {
                    lowerCaseWords.Add(words[i]);
                }
                else if (GetIsUpperCaseWord(words[i]))
                {
                    upperCaseWords.Add(words[i]);
                }
                else
                {
                    mixedCaseWords.Add(words[i]);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));
        }

        public static bool GetIsUpperCaseWord(string word)
        {
            bool upperCaseOnly = true; 

            foreach (var symbol in word)
            {
                if (symbol < 65 || symbol > 90)
                {
                    upperCaseOnly = false;
                }
            }

            return upperCaseOnly;
        }

        public static bool GetIsLowerCaseword(string word)
        {
            bool lowerCaseOnly = true;

            foreach (var symbol in word)
            {
                if (symbol < 97 || symbol > 122)
                {
                    lowerCaseOnly = false;
                }
            }

            return lowerCaseOnly;
        }

        public static List<string> ReadListFrom()
        {
            List<string> words = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"',  '\'', '\\', '/', '[', ']' }
                , StringSplitOptions.RemoveEmptyEntries).ToList();

            return words;
        }
    }
}
