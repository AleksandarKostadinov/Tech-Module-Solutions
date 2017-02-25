namespace _02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class Aword
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToList();
            var songs = Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToList();


            var line = Console.ReadLine();

            var participantsAwards = new Dictionary<string, HashSet<string>>();

            while (line != "dawn")
            {
                var tokens = line.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim())
                    .ToList();
                var currentParticipant = tokens[0];
                var currentSong = tokens[1];
                var currentAward = tokens[2];

                if (participants.Contains(currentParticipant) && songs.Contains(currentSong))
                {
                    if (!participantsAwards.ContainsKey(currentParticipant))
                    {
                        participantsAwards[currentParticipant] = new HashSet<string>();
                    }

                    participantsAwards[currentParticipant].Add(currentAward);
                }

                line = Console.ReadLine();
            }

            foreach (var participant in participantsAwards.OrderByDescending(o => o.Value.Count).ThenBy(h => h.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                foreach (var award in participant.Value.OrderBy(w => w))
                {
                    Console.WriteLine("--" + award);
                }
            }

            if (participantsAwards.Count == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
