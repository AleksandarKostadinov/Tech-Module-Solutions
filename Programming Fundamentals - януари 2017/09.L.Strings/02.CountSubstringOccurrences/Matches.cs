namespace _02.CountSubstringOccurrences
{
    using System;

    class Matches
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var substr = Console.ReadLine().ToLower();

            var count = 0;
            var index = text.IndexOf(substr);


            while (index != -1)
            {
                count++;
                index = text.IndexOf(substr, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
