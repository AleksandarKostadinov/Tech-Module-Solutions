namespace ProblemFour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetArmada
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var legions = new List<Legion>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split("=->:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(k => k.Trim())
                    .ToArray();

                var currentActivity = long.Parse(tokens[0]);
                var legionName = tokens[1];
                var soldierType = tokens[2];
                var soldierCount = long.Parse(tokens[3]);

                var currentLegion = new Legion();
                currentLegion.Name = legionName;
                currentLegion.LastActivity = currentActivity;
                currentLegion.SoldierType = new Dictionary<string, long>();
                currentLegion.SoldierType[soldierType] = soldierCount;

                if (!legions.Any( k => k.Name == legionName))
                {
                    legions.Add(currentLegion);
                }
                else 
                {
                    var existingLegion = legions.First(k => k.Name == legionName);

                    if (existingLegion.LastActivity < currentActivity)
                    {
                        existingLegion.LastActivity = currentActivity;
                    }


                    if (!existingLegion.SoldierType.Keys.Contains(soldierType))
                    {
                        existingLegion.SoldierType[soldierType] = 0;
                    }

                    existingLegion.SoldierType[soldierType] += soldierCount;
                }
                
            }

            var secondTokens = Console.ReadLine()
                .Split('\\')
                .Select(t => t.Trim())
                .ToArray();

            if (secondTokens.Length > 1)
            {
                var activity = long.Parse(secondTokens[0]);

                var result = new List<Legion>();

                foreach (var legion in legions.Where(j => j.LastActivity < activity) )
                {
                    var resultLegion = new Legion();
                    resultLegion.SoldierType = new Dictionary<string, long>();
                    resultLegion.Name = legion.Name;

                    var hasThatType = false;

                    foreach (var soldierType in legion.SoldierType)
                    {
                        if (soldierType.Key == secondTokens[1])
                        {
                            hasThatType = true;
                            resultLegion.SoldierType[secondTokens[1]] = legion.SoldierType[secondTokens[1]];
                        }
                    }

                    if (hasThatType)
                    {
                        result.Add(resultLegion);
                    }
                }

                foreach (var legion in result.OrderByDescending(l => l.SoldierType.Values.Sum()))
                {
                    Console.WriteLine(legion.Name + " -> " + legion.SoldierType.Values.First());
                }
            }
            else
            {
                foreach (var legion in legions.OrderByDescending(k => k.LastActivity))
                {
                    foreach (var soldier in legion.SoldierType)
                    {
                        if (soldier.Key == secondTokens[0])
                        {
                            Console.WriteLine($"{legion.LastActivity} : {legion.Name}");
                        }
                    }
                }
            }
        }
    }
    
    class Legion
    {
        public long LastActivity { get; set; }
        public string Name { get; set; }
        public Dictionary<string, long> SoldierType { get; set; }
    }
}
