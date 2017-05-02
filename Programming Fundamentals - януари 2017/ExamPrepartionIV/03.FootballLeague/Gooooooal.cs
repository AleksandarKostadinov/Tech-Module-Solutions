namespace _03.FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Gooooooal
    {
        static void Main()
        {
            var separator = Console.ReadLine();

            //string buggllesPattern = Regex.Escape(separator);

            //string separatorPattern = buggllesPattern.Substring(0, buggllesPattern.Length - 2);

            string separatorPattern = Regex.Escape(separator);

            var pattern = separatorPattern + "(.*)" + separatorPattern + ".*" + separatorPattern + "(.*)" + separatorPattern + ".*?([\\d]+):([\\d]+)";

            var teams = new List<Team>();

            var line = Console.ReadLine();

            while (line != "final")
            {
                var match = Regex.Match(line , pattern);

                var firstTeamName = GetReversedString(match.Groups[1].Value.ToString().ToUpper());
                var secondTeamName = GetReversedString(match.Groups[2].Value.ToString().ToUpper());

                var firstTeamGoals =long.Parse( match.Groups[3].Value.ToString());
                var secondTeamGoals =long.Parse( match.Groups[4].Value.ToString());

                var firstTeamCurrentPoints = 0;
                var secondTeamCurrentPoints = 0;

                if (firstTeamGoals > secondTeamGoals)
                {
                    firstTeamCurrentPoints = 3;
                }
                else if (secondTeamGoals > firstTeamGoals)
                {
                    secondTeamCurrentPoints = 3;
                }
                else
                {
                    secondTeamCurrentPoints = 1;
                    firstTeamCurrentPoints = 1;
                }

                if (teams.Any(t => t.Name == firstTeamName))
                {
                    var existingFirsTeam = teams.First(t => t.Name == firstTeamName);

                    existingFirsTeam.Points += firstTeamCurrentPoints;
                    existingFirsTeam.Goals += firstTeamGoals;
                }
                else
                {
                    var newFirstTeam = new Team
                    {
                        Name = firstTeamName,
                        Goals = firstTeamGoals,
                        Points = firstTeamCurrentPoints
                    };

                    teams.Add(newFirstTeam);
                }

                if (teams.Any(t => t.Name == secondTeamName))
                {
                    var existingSecondTeam = teams.First(t => t.Name == secondTeamName);

                    existingSecondTeam.Points += secondTeamCurrentPoints;
                    existingSecondTeam.Goals += secondTeamGoals;
                }
                else
                {
                    var newSecondTeam = new Team
                    {
                        Name = secondTeamName,
                        Goals = secondTeamGoals,
                        Points = secondTeamCurrentPoints
                    };

                    teams.Add(newSecondTeam);
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            var count = 1;

            foreach (var team in teams.OrderByDescending(t => t.Points).ThenBy(t => t.Name))
            {
                Console.WriteLine($"{count}. { team.Name} {team.Points}");
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            var secondCounter = 1;

            foreach (var team in teams.OrderByDescending(t => t.Goals).ThenBy(t => t.Name))
            {
                Console.WriteLine($"- {team.Name} -> {team.Goals}");
                secondCounter++;
                if (secondCounter > 3)
                {
                    break;
                }
            }
        }

        public static string GetReversedString(string number)
        {
            string reversedStr = string.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedStr += number[i];
            }

            return reversedStr;
        }
    }

    class Team
    {
        public string  Name { get; set; }

        public int Points { get; set; }

        public long Goals { get; set; }
    }
}
