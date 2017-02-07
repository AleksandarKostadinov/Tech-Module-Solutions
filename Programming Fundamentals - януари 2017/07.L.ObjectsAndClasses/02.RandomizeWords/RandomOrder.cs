namespace _02.RandomizeWords
{
    using System;

    public class RandomOrder
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split();

            var rand = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentIndex = rand.Next(words.Length);

                var temp = words[i];
                words[i] = words[currentIndex];
                words[currentIndex] = temp;
            }
            foreach (var word in words)
            {
                Console.WriteLine( word);
            }
        }
    }
}
