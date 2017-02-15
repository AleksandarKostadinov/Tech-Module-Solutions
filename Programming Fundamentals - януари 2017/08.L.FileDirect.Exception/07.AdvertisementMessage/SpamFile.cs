namespace _07.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class SpamFile
    {
        static void Main()
        {
            var phrases = File.ReadAllLines("Phrases.txt");
            var events = File.ReadAllLines("Events.txt");
            var authors = File.ReadAllLines("Authors.txt");
            var cities = File.ReadAllLines("Cities.txt");

            var rnd = new Random();
            var countOfPhrases = 6;
            var output = new List<string>();

            for (int i = 0; i < countOfPhrases; i++)
            {
                var phraseIndex = rnd.Next(phrases.Length);
                var eventIndex = rnd.Next(events.Length);
                var authorIndex = rnd.Next(authors.Length);
                var cityIndex = rnd.Next(cities.Length);

                output.Add($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} – {cities[cityIndex]}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
