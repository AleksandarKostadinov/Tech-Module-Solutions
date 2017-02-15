namespace _02.IndexOfLetters
{
    using System.Collections.Generic;
    using System.IO;

    class IoLFile
    {
        static void Main(string[] args)
        {
            string word = File.ReadAllText("Input.txt");

            char[] alphabetArr = GetCharsInRange('a', 'z');

            var output = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                int index = GetCharsIndexInArr(word[i], alphabetArr);
                var currentOutput = $"{word[i]} -> {index}";

                output.Add(currentOutput);
            }

            File.WriteAllLines("Output.txt", output);
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
