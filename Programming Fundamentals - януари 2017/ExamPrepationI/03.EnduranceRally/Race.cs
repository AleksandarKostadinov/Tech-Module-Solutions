namespace _03.EnduranceRally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Racer
    {
        public string Name { get; set; }
        public double Fuel { get; set; }
        public int StageReached { get; set; }
        public bool IsStillRecing { get; set; }
    }

    public class Race
    {
        public static void Main()
        {
            var racers = Console.ReadLine()
                .Split()
                .Select(d => new Racer
                {
                    Name = d,
                    Fuel = (int)d[0],
                    IsStillRecing = true,
                    StageReached = 0
                } )
                .ToArray();

            var layout = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var checkPoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < layout.Length; i++)
            {
                var currentFuel = layout[i]; 

                for (int j = 0; j < racers.Length; j++)
                {
                    var currentRacer = racers[j];

                    if (currentRacer.IsStillRecing)
                    {
                        if (checkPoints.Contains(i))
                        {
                            currentRacer.Fuel += currentFuel;
                        }
                        else
                        {
                            currentRacer.Fuel -= currentFuel;
                        }

                        if (currentRacer.Fuel <= 0)
                        {
                            currentRacer.IsStillRecing = false;
                            currentRacer.StageReached = i;
                        }
                    }
                }
            }

            for (int i = 0; i < racers.Length; i++)
            {
                if (racers[i].IsStillRecing)
                {
                    Console.WriteLine($"{racers[i].Name} - fuel left {racers[i].Fuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{racers[i].Name} - reached {racers[i].StageReached}");
                }
            }
        }
    }
}
