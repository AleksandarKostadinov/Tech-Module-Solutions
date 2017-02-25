using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var pattern = new Regex(@"\d+([\s\t]+)#[\w']+([\s\t]+@[\w']+)*");
            var eventsAndParticipants = new Dictionary<string, HashSet<string>>();

            while (line != "Time for Code")
            {
                if (!pattern.IsMatch(line))
                {
                    line = Console.ReadLine();
                    continue;
                }
                
                var tokens = line.Split('#');
                var id = tokens[0].Trim();

                var eventAndPartInfo = tokens[1].Split('@').Select(d => d.Trim()).ToArray();
                var currentEvent = eventAndPartInfo[0];

                var idAndEvent = id +"#" + currentEvent;

                if (eventsAndParticipants.Any(e => e.Key.Substring(0, e.Key.IndexOf("#")) == id)
                    && !eventsAndParticipants.ContainsKey(idAndEvent))
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (!eventsAndParticipants.ContainsKey(idAndEvent))
                {
                    eventsAndParticipants[idAndEvent] = new HashSet<string>();
                }
                for (int i = 1; i < eventAndPartInfo.Length; i++)
                {
                    eventsAndParticipants[idAndEvent].Add(eventAndPartInfo[i]);
                }

                line = Console.ReadLine();
            }

            foreach (var kvp in eventsAndParticipants.OrderByDescending( e => e.Value.Count).ThenBy(e => e.Key.Substring(e.Key.IndexOf("#") + 1, e.Key.Length - 1 - e.Key.IndexOf("#"))))
            {
                var eventName = kvp.Key.Substring(kvp.Key.IndexOf("#")+1, kvp.Key.Length - 1 - kvp.Key.IndexOf("#"));

                Console.WriteLine($"{eventName} - {kvp.Value.Count}");

                foreach (var participant in kvp.Value.OrderBy(w => w))
                {
                    Console.WriteLine("@" + participant);
                }
            }
        }
    }
}
