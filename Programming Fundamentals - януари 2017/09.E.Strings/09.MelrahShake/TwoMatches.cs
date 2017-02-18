namespace _09.MelrahShake
{
    using System;

    class TwoMatches
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            var leftIndex = text.IndexOf(pattern);
            var rightIndex = text.LastIndexOf(pattern);


            while (leftIndex >= 0 && rightIndex > 0 && leftIndex != rightIndex
                && pattern.Length > 0 && text.Length > 0 && rightIndex - leftIndex >= pattern.Length)
            {
                text = text.Remove(rightIndex, pattern.Length);
                text = text.Remove(leftIndex, pattern.Length);

                pattern = pattern.Remove(pattern.Length / 2, 1);

                Console.WriteLine("Shaked it.");

                leftIndex = text.IndexOf(pattern);
                rightIndex = text.LastIndexOf(pattern);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
