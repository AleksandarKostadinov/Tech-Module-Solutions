namespace _03.UnicodeCharacters
{
    using System;
    using System.Linq;

    public class CharsUnicode
    {
        public static void Main()
        {
            Console.ReadLine()
                .ToCharArray()
                .ToList()
                .ForEach(b => { Console.Write("\\u{0:x4}", (int)b); });
                
        }
    }
}
