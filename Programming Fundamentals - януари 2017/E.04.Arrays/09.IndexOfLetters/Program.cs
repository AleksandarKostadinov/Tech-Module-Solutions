using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            char[] alphabetArr = GetCharsInRange('a', 'z');

            for (int i = 0; i < words.Length; i++)
            {
                int index = GetCharsIndexInArr(words[i], alphabetArr);

                Console.WriteLine(words[i] + " -> " + index);
            }
        }

        public static int GetCharsIndexInArr(char symbol, char[] alphabetArr)
        {
            int index = 0;

            for (int i = 0; i < alphabetArr.Length; i++)
            {
                if (symbol == alphabetArr[i])
                {
                    index = i;
                }
            }

            return index;
        }

        public static char[] GetCharsInRange(char firstLetter, char lastLetter)
        {
            char[] alphabetArr = new char[lastLetter - firstLetter + 1];

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabetArr[i - 'a'] = i;
            }

            return alphabetArr;
        }
    }
}
