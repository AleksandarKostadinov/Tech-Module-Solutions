namespace _04.CharacterMultiplier
{
    using System;

    public class CharMultiply
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split();

            var greaterStr = string.Empty;
            var smallerStr = string.Empty;

            if (input[0].Length > input[1].Length)
            {
                greaterStr = input[0];
                smallerStr = input[1];
            }
            else
            {
                greaterStr = input[1];
                smallerStr = input[0];
            }

            long result = GetCharMultiplied(greaterStr, smallerStr);

            Console.WriteLine(result);
        }

        public static long GetCharMultiplied(string greaterStr, string smallerStr)
        {
            long result = 0;

            for (int i = 0; i < smallerStr.Length; i++)
            {
                result += greaterStr[i] * smallerStr[i];

            }

            for (int i = smallerStr.Length; i < greaterStr.Length; i++)
            {
                result += greaterStr[i];
            }

            return result;
        }
    }
}
