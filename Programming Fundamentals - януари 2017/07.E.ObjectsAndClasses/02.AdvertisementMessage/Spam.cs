namespace _02.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;

    class Spam
    {
        static void Main(string[] args)
        {
            var phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int n = int.Parse(Console.ReadLine());

            var rand = new Random();

            for (int i = 0; i < n; i++)
            {
                var phraseIndex = rand.Next(phrases.Length);
                var eventIndex = rand.Next(events.Length);
                var autorIndex = rand.Next(authors.Length);
                var cityIndex = rand.Next(cities.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[autorIndex]} – {cities[cityIndex]}");
            }
        }
    }
}
