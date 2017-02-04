namespace _05.ShortWordsSorted
{
    using System;
    using System.Linq;

    class OrderWordsLessThanK
    {

        static void Main()
        {
            int k = 5;
            Console.WriteLine(string.Join(", "
                , Console.ReadLine()
                .ToLower()
                .Split(
                    new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .OrderBy(x => x)
                .Where(w => w.Length < k)
                .ToList()));
        }
    }
}
