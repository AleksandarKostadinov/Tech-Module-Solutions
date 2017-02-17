namespace _01.ReverseString
{
    using System;
    using System.Linq;

    class ReverseWord
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            var reversedWord = word.Reverse();

            Console.WriteLine(string.Join(string.Empty, reversedWord));
        }
    }
}
